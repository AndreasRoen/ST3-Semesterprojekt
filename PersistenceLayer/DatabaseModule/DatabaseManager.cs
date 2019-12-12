using BeerProductionSystem.DOClasses;
using System;
using System.Linq;
using System.Collections.Generic;
using System.Data.SqlClient;
using BeerProductionSystem.PresentationLayer;

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
            BatchDO data = new BatchDO();
            using (DataContext context = new DataContext())
            {
                data = context.BatchReports.Find(BatchID);
            }
            return data;
        }

        public List<BatchDO> GetAllBatchReports()
        {
            List<BatchDO> batchList = new List<BatchDO>();
            using (DataContext context = new DataContext())
            {
                batchList = context.BatchReports.ToList();
            }
            return batchList;
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
                br.StateDictionary.Add((int)MachineState.Deactivated, new TimeSpan((stateLog.DeactivatedState.Value)));
                br.StateDictionary.Add((int)MachineState.Clearing, new TimeSpan((stateLog.ClearingState.Value)));
                br.StateDictionary.Add((int)MachineState.Stopped, new TimeSpan((stateLog.StoppedState.Value)));
                br.StateDictionary.Add((int)MachineState.Starting, new TimeSpan((stateLog.StartingState.Value)));
                br.StateDictionary.Add((int)MachineState.Idle, new TimeSpan((stateLog.IdleState.Value)));
                br.StateDictionary.Add((int)MachineState.Suspended, new TimeSpan((stateLog.SuspendedState.Value)));
                br.StateDictionary.Add((int)MachineState.Execute, new TimeSpan((stateLog.ExecuteState.Value)));
                br.StateDictionary.Add((int)MachineState.Stopping, new TimeSpan((stateLog.StoppingState.Value)));
                br.StateDictionary.Add((int)MachineState.Aborting, new TimeSpan((stateLog.AbortingState.Value)));
                br.StateDictionary.Add((int)MachineState.Aborted, new TimeSpan((stateLog.AbortedState.Value)));
                br.StateDictionary.Add((int)MachineState.Holding, new TimeSpan((stateLog.HoldingState.Value)));
                br.StateDictionary.Add((int)MachineState.Held, new TimeSpan((stateLog.HeldState.Value)));
                br.StateDictionary.Add((int)MachineState.Resetting, new TimeSpan((stateLog.ResettingState.Value)));
                br.StateDictionary.Add((int)MachineState.Completing, new TimeSpan((stateLog.CompletingState.Value)));
                br.StateDictionary.Add((int)MachineState.Complete, new TimeSpan((stateLog.CompleteState.Value)));
                br.StateDictionary.Add((int)MachineState.Deactivating, new TimeSpan((stateLog.DeactivatingState.Value)));
                br.StateDictionary.Add((int)MachineState.Activating, new TimeSpan((stateLog.ActivatingState.Value)));
                batchList.Add(br);
            }

            return batchList;
        }
    }

}
