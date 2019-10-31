using BeerProductionSystem.Aquaintence;
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

        public List<float> GetUpdateData()
        {
            List<float> values = new List<float>();
            values.Add(machineReadData.ReadTemperature(accessPoint));
            values.Add(machineReadData.ReadHumidity(accessPoint));
            values.Add(machineReadData.ReadVibration(accessPoint));
            values.Add(0); //batch id 
            values.Add(0); // batch size
            values.Add(machineReadData.ReadActualMachineSpeed(accessPoint));
            values.Add(machineReadData.ReadProducedProducts(accessPoint));
            values.Add(0); //acceptable products
            values.Add(machineReadData.ReadDefectProducts(accessPoint));
            values.Add(machineReadData.ReadBarleyAmount(accessPoint));
            values.Add(machineReadData.ReadHopsAmount(accessPoint));
            values.Add(machineReadData.ReadMaltAmount(accessPoint));
            values.Add(machineReadData.ReadWheatAmount(accessPoint));
            values.Add(machineReadData.ReadYeastAmount(accessPoint));
            values.Add(machineReadData.ReadMaintenanceCounter(accessPoint));
            values.Add(machineReadData.ReadCurrentState(accessPoint));

            return values;
        }
    }
}
