using BeerProductionSystem.Aquaintence;
using BeerProductionSystem.PersistenceLayer;
using BeerProductionSystem.BusinessLayer.BatchModule;

namespace BeerProductionSystem.BusinessLayer
{
    class LogicFacade : ILogicFacade
    {
        private IPersistenceFacade persistenceFacade;
        private IBatchController batchController;

        public LogicFacade()
        {
            persistenceFacade = new PersistenceFacade();
            batchController = new BatchController();
        }

        public string UpdateData()
        {
            return persistenceFacade.GetUpdateData();
        }

        public bool SaveBatchReport()
        {
            return persistenceFacade.CreateBatchReport(batchController.GetBatchReportDTO());
            
        }
    }
}
