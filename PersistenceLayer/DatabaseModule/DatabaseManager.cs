using BeerProductionSystem.BusinessLayer;
using BeerProductionSystem.DOClasses;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;

namespace BeerProductionSystem.PersistenceLayer.DatabaseModule
{
    class DatabaseManager : IDatabaseManager
    {

        public DatabaseManager()
        {

        }

        public int GetLastBatchReportID()
        {
            int batchReportID = 0;
            using (DataContext context = new DataContext())
            {
                try
                {
                    //Returns the latest Batch report saved in the database.
                    BatchDO batchReport = context.BatchReports.OrderByDescending(
                        b => b.BatchReportID).FirstOrDefault();
                    batchReportID = batchReport.BatchReportID;
                }
                catch (NullReferenceException)
                {

                }
            }
            return batchReportID;
        }
        public bool SaveBatchReport(BatchDO batchReport)
        {
            bool success = false;
            using (DataContext context = new DataContext())
            {
                //Create empty StateLog entry
                StateLogDO stateLog = new StateLogDO();
                stateLog.BatchReportID = batchReport.BatchReportID;
                //Save Batch Report
                context.BatchReports.Add(batchReport);
                context.StateLogs.Add(stateLog);
                context.SaveChanges();

                success = true;
            }
            return success;
        }


        public bool UpdateBatchReport(LiveRelevantDataDO liveRelevantData)
        {
            bool success = false;

            using (DataContext context = new DataContext())
            {
                //Returns the latest Batch report saved in the database.
                BatchDO batchReport = context.BatchReports.Find(liveRelevantData.BatchID);
                //Update batchReport data
                batchReport.ProducedProducts = liveRelevantData.ProducedProducts;
                batchReport.DefectProducts = liveRelevantData.DefectProducts;
                batchReport.ProductionEndTime = System.DateTime.Now;

                //Create a new entry of environmental log
                EnvironmentalLogDO environmentalLog = new EnvironmentalLogDO
                {
                    BatchReportID = batchReport.BatchReportID,
                    Temperature = liveRelevantData.Temperature,
                    Vibration = liveRelevantData.Vibration,
                    Humidity = liveRelevantData.Humidity,
                    Time = System.DateTime.Now
                };
                //Save environmental log entry
                batchReport.EnvironmentalLogs.Add(environmentalLog);

                StateLogDO stateLog = context.StateLogs.FirstOrDefault(s => s.BatchReportID == batchReport.BatchReportID);
                stateLog.SetTimeInStates(liveRelevantData.StateDictionary);

                context.SaveChanges();

                success = true;
            }
            return success;
        }

        public BatchDO LoadBatchReport(int BatchID)
        {
            DataContext context = new DataContext();

            BatchDO batchDO = context.BatchReports.Find(BatchID);
            StateLogDO stateLogDO = context.StateLogs.FirstOrDefault(s => s.BatchReportID == BatchID);

            return loadStateDictionaryOnBatchDO(batchDO, stateLogDO);
        }

        //Returns all info of all Batch Reports in Database as a List sorted by BatchID
        public List<BatchDO> GetBatchReports()
        {
            List<BatchDO> batchList = new List<BatchDO>();
            DataContext context = new DataContext();

            List<BatchDO> batches = (context.BatchReports.SqlQuery("SELECT * FROM dbo.BatchReport")).ToList();
            foreach (BatchDO br in batches)
            {
                br.EnvironmentalLogs = (context.EnvironmentalLogs.SqlQuery("SELECT * FROM dbo.EnvironmentalLog WHERE BatchReportID = @id", new SqlParameter("@id", br.BatchReportID))).ToList();
                StateLogDO stateLog = context.StateLogs.Find(br.BatchReportID);
                batchList.Add(loadStateDictionaryOnBatchDO(br, stateLog));
            }

            return batchList;
        }

        private BatchDO loadStateDictionaryOnBatchDO(BatchDO batchDO, StateLogDO stateLogDO)
        {
            batchDO.StateDictionary.Add((int)MachineState.Deactivated, new TimeSpan((stateLogDO.DeactivatedState.Value)));
            batchDO.StateDictionary.Add((int)MachineState.Clearing, new TimeSpan((stateLogDO.ClearingState.Value)));
            batchDO.StateDictionary.Add((int)MachineState.Stopped, new TimeSpan((stateLogDO.StoppedState.Value)));
            batchDO.StateDictionary.Add((int)MachineState.Starting, new TimeSpan((stateLogDO.StartingState.Value)));
            batchDO.StateDictionary.Add((int)MachineState.Idle, new TimeSpan((stateLogDO.IdleState.Value)));
            batchDO.StateDictionary.Add((int)MachineState.Suspended, new TimeSpan((stateLogDO.SuspendedState.Value)));
            batchDO.StateDictionary.Add((int)MachineState.Execute, new TimeSpan((stateLogDO.ExecuteState.Value)));
            batchDO.StateDictionary.Add((int)MachineState.Stopping, new TimeSpan((stateLogDO.StoppingState.Value)));
            batchDO.StateDictionary.Add((int)MachineState.Aborting, new TimeSpan((stateLogDO.AbortingState.Value)));
            batchDO.StateDictionary.Add((int)MachineState.Aborted, new TimeSpan((stateLogDO.AbortedState.Value)));
            batchDO.StateDictionary.Add((int)MachineState.Holding, new TimeSpan((stateLogDO.HoldingState.Value)));
            batchDO.StateDictionary.Add((int)MachineState.Held, new TimeSpan((stateLogDO.HeldState.Value)));
            batchDO.StateDictionary.Add((int)MachineState.Resetting, new TimeSpan((stateLogDO.ResettingState.Value)));
            batchDO.StateDictionary.Add((int)MachineState.Completing, new TimeSpan((stateLogDO.CompletingState.Value)));
            batchDO.StateDictionary.Add((int)MachineState.Complete, new TimeSpan((stateLogDO.CompleteState.Value)));
            batchDO.StateDictionary.Add((int)MachineState.Deactivating, new TimeSpan((stateLogDO.DeactivatingState.Value)));
            batchDO.StateDictionary.Add((int)MachineState.Activating, new TimeSpan((stateLogDO.ActivatingState.Value)));
            return batchDO;
        }
    }

}
