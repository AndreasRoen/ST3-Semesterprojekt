using BeerProductionSystem.Aquaintence;
using BeerProductionSystem.BusinessLayer.BatchModule;
using BeerProductionSystem.PersistenceLayer;
using System.Collections.Generic;
using System.Diagnostics;
using System;
using BeerProductionSystem.DOClasses;

namespace BeerProductionSystem.BusinessLayer
{
    class LogicFacade : ILogicFacade
    {
        private IPersistenceFacade persistenceFacade;
        private IBatchManager batchManager;
        private ProductionCalculation calculator;
        private int currentState;
        private DateTime startTime;

        public LogicFacade()
        {
            persistenceFacade = new PersistenceFacade();
            batchManager = new BatchManager();
            calculator = new ProductionCalculation();
        }

        public bool ConnectToMachine(string machineName)
        {
            return persistenceFacade.ConnectToMachine(machineName);
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

        public void SendStartCommand(ushort productType, ushort productionSpeed, ushort batchSize)
        {
            calculator.CalculateError((ProductType)productType, productionSpeed);
            batchManager.CreateBatch(productType, productionSpeed, batchSize);  //TODO why have a batch object??
            ushort batchId = batchManager.CurrentBatch.BatchID;
            persistenceFacade.SetBatchParameters(productType, productionSpeed, batchSize, batchId);
            persistenceFacade.SendCommand((int)Commands.START);
            currentState = 6;
            startTime = DateTime.Now;
        }

        public void SendStopCommand()
        {
            persistenceFacade.SendCommand((int)Commands.STOP);
            SaveBatchReport();
        }

        public bool checkBatchParameter()
        {
            return batchManager.CheckBatchParameter();
        }

        public LiveRelevantDataDO UpdateData()
        {
            LiveRelevantDataDO liveRelevantData = persistenceFacade.GetUpdateData();
            liveRelevantData.BatchID = batchManager.CurrentBatch == null ? (ushort)0 : batchManager.CurrentBatch.BatchID;
            liveRelevantData.BatchSize = batchManager.CurrentBatch == null ? (ushort)0 : batchManager.CurrentBatch.BatchSize;
            liveRelevantData.AcceptableProducts = (ushort)(liveRelevantData.ProducedProducts - liveRelevantData.DefectProducts);
            return liveRelevantData;
        }

        public void UpdateTimeInState(LiveRelevantDataDO liveRelevantDataDO)
        {
            if (!liveRelevantDataDO.CurrentState.Equals(currentState))
            {
                AmountOfTimeInState(currentState, startTime);
                startTime = DateTime.Now;
            }
        }

        public void AmountOfTimeInState(int currentState, DateTime date)
        {
            TimeSpan timeSpan = date.Subtract(DateTime.Now);
            batchManager.SaveTimeInState(currentState, timeSpan);
        }
        public bool SaveBatchReport()
        {
            return persistenceFacade.SaveBatchReport(batchManager.BatchReport);

        }

        public int GetProductMaxSpeed(string productName)
        {
            Enum.TryParse(productName, out ProductMaxSpeed maxSpeed);
            return (int)maxSpeed;
        }

        public int GetEstimatedError(ushort productType, ushort productionSpeed)
        {
            return calculator.CalculateError((ProductType)productType, productionSpeed);
        }

        public int GetOptimalEquipmentEfficiency()
        {
            return calculator.CalculateOptimalEquipmentEffectivness();
        }

        public int GetOptimalProductionSpeed(ushort productType)
        {
            ProductType p = (ProductType)productType;
            return (int)(OptimalProductionSpeed)Enum.Parse(typeof(OptimalProductionSpeed), p.ToString());
        }
    }
}
