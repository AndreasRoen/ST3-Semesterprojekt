using BeerProductionSystem.Aquaintence;
using BeerProductionSystem.DTOClasses;
using BeerProductionSystem.PersistenceLayer.ConnectionModule;
using BeerProductionSystem.PersistenceLayer.MachineModule;
using Opc.UaFx.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

        public PersistenceFacade()
        {
            machineReadData = new MachineReadData();
            machineWriteData = new MachineWriteData();
            opcConnection = new OPCConnectionManager();
            opcConnection.ConnectToServer();
            accessPoint = opcConnection.AccessPoint;
        }

        public LiveRelevantDataDTO GetUpdateData()
        {
            LiveRelevantDataDTO dto = new LiveRelevantDataDTO(
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
            return dto;
        }

        public void SendCommand(int command)
        {
            machineWriteData.WriteControlCommand(accessPoint, command);
        }
    }
}
