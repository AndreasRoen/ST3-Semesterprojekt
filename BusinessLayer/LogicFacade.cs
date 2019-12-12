using BeerProductionSystem.Aquaintence;
using BeerProductionSystem.BusinessLayer.BatchModule;
using BeerProductionSystem.PersistenceLayer;
using System.Collections.Generic;
using System.Diagnostics;
using System;
using BeerProductionSystem.DOClasses;
using System.Threading.Tasks;
using System.Windows.Forms;

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
            batchManager = new BatchManager(persistenceFacade.GetLastBatchReportID());
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
            int batchId = batchManager.CurrentBatch.BatchReportID;
            persistenceFacade.SetBatchParameters(productType, productionSpeed, batchSize, batchId);
            SaveBatchReport();
            previousState = currentState;
            startTime = DateTime.Now;
            productionRunning = true;
            persistenceFacade.SendCommand((int)Commands.START);
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
            liveRelevantData.BatchID = batchManager.CurrentBatch == null ? (ushort)0 : batchManager.CurrentBatch.BatchReportID;
            liveRelevantData.BatchSize = batchManager.CurrentBatch == null ? (ushort)0 : batchManager.CurrentBatch.BatchSize;
            liveRelevantData.AcceptableProducts = (liveRelevantData.ProducedProducts - liveRelevantData.DefectProducts);
            if (productionRunning)
            {
                Task task = Task.Run(() =>
                {
                    TimeSpan timeSpan = DateTime.Now.Subtract(startTime);
                    liveRelevantData.StateDictionary[(int)currentState] += timeSpan;
                    startTime = DateTime.Now;
                    
                    //    if (currentState != previousState)
                    //    {
                    //    this.previousState = currentState;
                    //}
                
                
                persistenceFacade.UpdateBatchReport(liveRelevantData);

                });
                
            }
            return liveRelevantData;
        }

        
        public bool SaveBatchReport()
        {
            bool success = false;
            Task task = Task.Run(() =>
            {
                success = persistenceFacade.SaveBatchReport(batchManager.CurrentBatch);
            });

            return success;
        }

        public int GetProductMaxSpeed(string productName)
        {
            Enum.TryParse(productName, out ProductMaxSpeed maxSpeed);
            return (int)maxSpeed;
        }

        public List<BatchDO> GetAllBatchReports()
        {
            return persistenceFacade.GetBatchReports();
        }

        public BatchDO GetSpecificReport(int id)
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
