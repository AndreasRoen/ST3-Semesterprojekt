using BeerProductionSystem.Aquaintence;
using BeerProductionSystem.PersistenceLayer.ConnectionModule;
using BeerProductionSystem.PersistenceLayer.MachineModule;
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

        public PersistenceFacade()
        {
            machineReadData = new MachineReadData();
            machineWriteData = new MachineWriteData();
            opcConnection = new OPCConnectionManager();
            opcConnection.ConnectToServer();
        }

        public string GetUpdateData()
        {
            return machineReadData.ReadCurrentState(opcConnection.AccessPoint).ToString();
        }
    }
}
