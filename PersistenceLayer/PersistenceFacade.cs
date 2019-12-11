using BeerProductionSystem.Aquaintence;
using BeerProductionSystem.DOClasses;
using BeerProductionSystem.PersistenceLayer.ConnectionModule;
using BeerProductionSystem.PersistenceLayer.MachineModule;
using Opc.UaFx.Client;
using BeerProductionSystem.PersistenceLayer.DatabaseModule;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BeerProductionSystem.BusinessLayer;

namespace BeerProductionSystem.PersistenceLayer
{
    /// <summary>
    /// Implementation of the IPersistenceFacade interface
    /// </summary>
    public class PersistenceFacade : IPersistenceFacade
    {
        private IMachineReadData machineReadData;
        private IMachineWriteData machineWriteData;
        private OPCConnectionManager opcConnection;
        private OpcClient accessPoint;
        private IDatabaseManager databaseManager;
        private string currentMachineName;


        public PersistenceFacade()
        {
            databaseManager = new DatabaseManager();
            machineReadData = new MachineReadData();
            machineWriteData = new MachineWriteData();
            opcConnection = new OPCConnectionManager();
        }

        public bool ConnectToMachine(string machineName)
        {
            if (machineName == "")
            {
                machineName = currentMachineName;
            }
            bool isSuccess = opcConnection.ConnectToServer(machineName);
            currentMachineName = machineName;
            accessPoint = opcConnection.AccessPoint;
            return isSuccess;
        }

        public bool SaveBatchReport(BatchReport batchReport)
        {
            return databaseManager.SaveBatchReport(batchReport);
        }

        public LiveRelevantDataDO GetUpdateData()
        {
            if (!opcConnection.CheckConnection())
            {
                opcConnection.ConnectToServer(currentMachineName);
            }

            LiveRelevantDataDO liveRelevantData = new LiveRelevantDataDO(
                machineReadData.ReadTemperature(accessPoint),
                machineReadData.ReadHumidity(accessPoint),
                machineReadData.ReadVibration(accessPoint),
                machineReadData.ReadActualMachineSpeed(accessPoint),
                machineReadData.ReadProducedProducts(accessPoint),
                machineReadData.ReadDefectProducts(accessPoint),
                machineReadData.ReadBarleyAmount(accessPoint),
                machineReadData.ReadHopsAmount(accessPoint),
                machineReadData.ReadMaltAmount(accessPoint),
                machineReadData.ReadWheatAmount(accessPoint),
                machineReadData.ReadYeastAmount(accessPoint),
                machineReadData.ReadMaintenanceCounter(accessPoint),
                machineReadData.ReadCurrentState(accessPoint)
                );
            return liveRelevantData;
        }

        public void SendCommand(int command)
        {
            machineWriteData.WriteControlCommand(accessPoint, command);
        }

        public void SetBatchParameters(float productType, ushort productionSpeed, ushort batchSize, ushort batchID)
        {
            machineWriteData.WriteNextBatchProductType(accessPoint, productType);
            machineWriteData.WriteDesiredMachineSpeed(accessPoint, productionSpeed);
            machineWriteData.WriteNextBatchSize(accessPoint, batchSize);
            machineWriteData.WriteNextBatchID(accessPoint, batchID);

        }

        public bool UpdateBatchReport(LiveRelevantDataDO liveRelevantData)
        {
            return databaseManager.UpdateBatchReport(liveRelevantData);
        }

        public List<BatchReport> GetBatchReports()
        {
            return databaseManager.GetBatchReports();
        }

        public BatchReport GetSpecificReport(int id)
        {
            return databaseManager.LoadBatchReport(id);
        }

        public bool CheckMachineConnection()
        {
            return opcConnection.CheckConnection();
        }
    }
}
