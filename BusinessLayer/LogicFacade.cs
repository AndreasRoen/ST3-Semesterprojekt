﻿using BeerProductionSystem.Aquaintence;
using BeerProductionSystem.BusinessLayer.BatchModule;
using BeerProductionSystem.PersistenceLayer;
using System.Collections.Generic;
using BeerProductionSystem.DTOClasses;
using System.Diagnostics;
using System;

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

    enum ProductMaxSpeed  //TODO move out of presentation layer
    {
        Pilsner = 600,
        Wheat = 300,
        IPA = 150,
        Stout = 200,
        Ale = 100,
        Alcohol_Free = 125
    }

    class LogicFacade : ILogicFacade
    {
        private IPersistenceFacade persistenceFacade;
        private IBatchManager batchManager;
        private int currentState;
        private DateTime startTime;

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

        public void SendStartCommand(ushort productType, ushort productionSpeed, ushort batchSize)
        {
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
            LiveRelevantDataDO dto = persistenceFacade.GetUpdateData();
            dto.BatchID = batchManager.CurrentBatch == null ? (ushort)0 : batchManager.CurrentBatch.BatchID;
            dto.BatchSize = batchManager.CurrentBatch == null ? (ushort)0 : batchManager.CurrentBatch.BatchSize;
            dto.AcceptableProducts = (ushort)(dto.ProducedProducts - dto.DefectProducts);
            return dto;
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
            return persistenceFacade.CreateBatchReport(batchManager.GetBatchReportDO());

        }

        public int GetProductMaxSpeed(string productName)
        {
            Enum.TryParse(productName, out ProductMaxSpeed maxSpeed);
            return (int)maxSpeed;
        }
    }
}
