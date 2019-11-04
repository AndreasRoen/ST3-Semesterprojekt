using BeerProductionSystem.Aquaintence;
using BeerProductionSystem.PersistenceLayer.ConnectionModule;
using BeerProductionSystem.PersistenceLayer.MachineModule;
using BeerProductionSystem.PersistenceLayer.DatabaseModule;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BeerProductionSystem.DTOClasses;

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
        private IDatabaseController databaseController;

        public PersistenceFacade()
        {
            machineReadData = new MachineReadData();
            machineWriteData = new MachineWriteData();
            opcConnection = new OPCConnectionManager();
            opcConnection.ConnectToServer();
            this.databaseController = new FileWriter();
        }

        public bool CreateBatchReport(BatchReportDTO batchReport)
        {
            return databaseController.SaveBatchReport(batchReport);
        }

        public string GetUpdateData()
        {
            return machineReadData.ReadCurrentState(opcConnection.AccessPoint).ToString();
        }
    }
}
