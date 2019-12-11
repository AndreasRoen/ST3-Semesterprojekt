using BeerProductionSystem.Aquaintence;
using BeerProductionSystem.BusinessLayer.BatchModule;
using BeerProductionSystem.PersistenceLayer;
using System.Collections.Generic;
using System.Diagnostics;
using System;
using BeerProductionSystem.DOClasses;
using System.Threading.Tasks;

namespace BeerProductionSystem.BusinessLayer
{
    class LogicFacade : ILogicFacade
    {
        private IPersistenceFacade persistenceFacade;
        private IBatchManager batchManager;
        private ProductionCalculation calculator;
        private MachineState currentState;
        private MachineState previousState;
        private DateTime startTime;
        private bool productionRunning;

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
            productionRunning = false;
            
        }

        public void SendStartCommand(ushort productType, ushort productionSpeed, ushort batchSize)
        {
            calculator.CalculateError((ProductType)productType, productionSpeed);
            batchManager.CreateBatch(productType, productionSpeed, batchSize);
            ushort batchId = batchManager.CurrentBatch.BatchID;
            persistenceFacade.SetBatchParameters(productType, productionSpeed, batchSize, batchId);
            persistenceFacade.SendCommand((int)Commands.START);
            previousState = currentState;
            startTime = DateTime.Now;
            productionRunning = true;
            SaveBatchReport();
        }

        public void SendStopCommand()
        {
            persistenceFacade.SendCommand((int)Commands.STOP);
        }

        public bool checkBatchParameter()
        {
            return batchManager.CheckBatchParameter();
        }

        public LiveRelevantDataDO UpdateData()
        {
            LiveRelevantDataDO liveRelevantData = persistenceFacade.GetUpdateData();
            currentState = (MachineState) liveRelevantData.CurrentState;
            liveRelevantData.BatchID = batchManager.CurrentBatch == null ? (ushort)0 : batchManager.CurrentBatch.BatchID;
            liveRelevantData.BatchSize = batchManager.CurrentBatch == null ? (ushort)0 : batchManager.CurrentBatch.BatchSize;
            liveRelevantData.AcceptableProducts = (ushort)(liveRelevantData.ProducedProducts - liveRelevantData.DefectProducts);
            if (productionRunning)
            {
                UpdateTimeInState(currentState, previousState);
                Task task = Task.Run(() =>
                {
                    persistenceFacade.UpdateBatchReport(liveRelevantData);
                });
                
            }
            return liveRelevantData;
        }

        public void UpdateTimeInState(MachineState currentState, MachineState previousState)
        {
            if (currentState != previousState)
            {
                AmountOfTimeInState(previousState, startTime);
                startTime = DateTime.Now;
                this.previousState = currentState;
            }
        }

        public void AmountOfTimeInState(MachineState currentState, DateTime date)
        {
            TimeSpan timeSpan = date.Subtract(DateTime.Now);
            batchManager.SaveTimeInState(currentState, timeSpan);
        }

        public bool SaveBatchReport()
        {
            bool success = false;
            Task task = Task.Run(() =>
            {
                success = persistenceFacade.SaveBatchReport(batchManager.BatchReport);
            });

            return success;
        }

        public int GetProductMaxSpeed(string productName)
        {
            Enum.TryParse(productName, out ProductMaxSpeed maxSpeed);
            return (int)maxSpeed;
        }

        public List<BatchReport> GetAllBatchReports()
        {
            return persistenceFacade.GetBatchReports();
        }

        public BatchReport GetSpecificReport(int id)
        {
            return persistenceFacade.GetSpecificReport(id);
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

        public bool CheckMachineConnection()
        {
            return persistenceFacade.CheckMachineConnection();

        }
    }
}
