using BeerProductionSystem.Aquaintence;
using BeerProductionSystem.BusinessLayer.BatchModule;
using BeerProductionSystem.PersistenceLayer;

namespace BeerProductionSystem.BusinessLayer
{
    class LogicFacade : ILogicFacade
    {
        private IPersistenceFacade persistenceFacade;

        private IBatchManager batchManager;

        public LogicFacade()
        {
            persistenceFacade = new PersistenceFacade();
            batchManager = new BatchManager();
        }

        public bool checkBatchParameter()
        {
            return batchManager.ChechBatchParameter();
        }

        public void setProductType(ushort productID)
        {
            batchManager.GetBatchDTO().ProductType = productID;
            //TODO call machine with changes (or wait for start production button?)
        }

        public void setSize(ushort size)
        {
            batchManager.GetBatchDTO().BatchSize = size;
            //TODO call machine with changes (or wait for start productin button?)
        }

        public void setSpeed(float speed)
        {
            batchManager.GetBatchDTO().ProductionSpeed = speed;
            //TODO call machine with changes (or wait for start production button?)
        }

        public string UpdateData()
        {
            return persistenceFacade.GetUpdateData();
        }
    }
}
