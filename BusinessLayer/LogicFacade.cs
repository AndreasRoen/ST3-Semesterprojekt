using BeerProductionSystem.Aquaintence;
using BeerProductionSystem.BusinessLayer.BatchModule;
using BeerProductionSystem.PersistenceLayer;
using System.Collections.Generic;
using BeerProductionSystem.DTOClasses;


namespace BeerProductionSystem.BusinessLayer
{
    enum Commands
    {
        RESET = 1,
        START,
        STOP,
        ABORT,
        CLEAR
    }

    class LogicFacade : ILogicFacade
    {
        private IPersistenceFacade persistenceFacade;
        private IBatchManager batchManager;

        public LogicFacade()
        {
            persistenceFacade = new PersistenceFacade();
            batchManager = new BatchManager();

        }

        public void SendAbortCommand()
        {
            persistenceFacade.SendCommand((int)Commands.ABORT);
        }

        public void SendClearCommand()
        {
            persistenceFacade.SendCommand((int)Commands.CLEAR);
        }

        public void SendResetCommand()
        {
            persistenceFacade.SendCommand((int)Commands.RESET);
        }

        public void SendStartCommand(float productType, ushort productionSpeed, ushort batchSize)
        {
            batchManager.CreateBatch(productType, productionSpeed, batchSize);  //TODO why have a batch object??
            persistenceFacade.SetBatchParameters(productType, productionSpeed, batchSize, batchManager.CurrentBatch.BatchID);
            persistenceFacade.SendCommand((int)Commands.START);
        }

        public void SendStopCommand()
        {
            persistenceFacade.SendCommand((int)Commands.STOP);
        }

        //public void SetBatchSize(ushort size)
        //{
        //    batchManager.GetBatch().BatchSize = size;
        //}

        //public void SetProductionSpeed(ushort speed)
        //{
        //    batchManager.GetBatch().ProductionSpeed = speed;
        //}

        //public void SetProductType(float productType)
        //{
        //    batchManager.GetBatch().ProductType = productType;
        //}

        public bool checkBatchParameter()
        {
            return batchManager.CheckBatchParameter();
        }

        public LiveRelevantDataDTO UpdateData()
        {
            LiveRelevantDataDTO dto = persistenceFacade.GetUpdateData();    //TODO read data from BatchModel
            dto.BatchID = 0;
            dto.BatchSize = 100;
            dto.AcceptableProducts = (ushort)(dto.ProducedProducts - dto.DefectProducts);
            return dto;
        }

        public bool SaveBatchReport()
        {
            return persistenceFacade.CreateBatchReport(batchManager.GetBatchReportDTO());

        }
    }
}
