using BeerProductionSystem.DOClasses;
using BeerProductionSystem.PersistenceLayer.DatabaseModule;
using System;
using System.Linq;
using System.IO;
using System.Reflection;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace BeerProductionSystem.PersistenceLayer.DatabaseModule {
    class DatabaseManager : IDatabaseManager {

        public DatabaseManager() {

        }

        public bool SaveBatchReport(BatchReport batchReport)
        {
            bool success = false;
            using (DataContext context = new DataContext())
            {
                
                context.BatchReports.Add(batchReport);
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
                BatchReport batchReport = context.BatchReports.OrderByDescending(
                    b => b.BatchReportID).FirstOrDefault();

                //Create a new entry of environmental log
                EnvironmentalLog environmentalLog = new EnvironmentalLog
                {
                    Temperature = liveRelevantData.Temperature,
                    Vibration = liveRelevantData.Vibration,
                    Humidity = liveRelevantData.Humidity,
                    Time = System.DateTime.Now
                };

                //Save data
                batchReport.AcceptableAmount += liveRelevantData.ProducedProducts - liveRelevantData.DefectProducts;
                batchReport.DefectAmount += liveRelevantData.DefectProducts;
                batchReport.EnvironmentalLogs.Add(environmentalLog);
                context.SaveChanges();

                success = true;

            }
            return success;
        }

        public BatchReport LoadBatchReport(int BatchID)
        {
            BatchReport data = new BatchReport();
            using(DataContext context = new DataContext())
            {
                data = context.BatchReports.Find(BatchID);
            }
            return data;
        }

        public List<BatchReport> GetAllBatchReports()
        {
            List<BatchReport> batchList = new List<BatchReport>();
            using (DataContext context = new DataContext())
            {
                batchList = context.BatchReports.ToList();
            }
            return batchList;
        }

        //Returns all info of all Batch Reports in Database as a List sorted by BatchID
        public List<BatchReport> GetBatchReports()
        {
            List<BatchReport> batchList = new List<BatchReport>();
            using (DataContext context = new DataContext())
            {
                List<BatchReport> batches = (context.BatchReports.SqlQuery("SELECT * FROM dbo.BatchReport")).ToList();
                foreach (BatchReport br in batches)
                {
                    br.EnvironmentalLogs = (context.EnvironmentalLogs.SqlQuery("SELECT * FROM dbo.EnvironmentalLog WHERE BatchReportID = @id",new SqlParameter("@id", br.BatchReportID))).ToList();
                    br.StateLogs = (ICollection<StateLog>)context.StateLogs.Find(br.BatchReportID);
                    //TODO implement
                    foreach(StateLog sl in br.StateLogs)
                    {
                        br.StateDictionary.Add((int)sl.AbortedState, new TimeSpan((long)(sl.AbortedState.Value) * 10000));
                        br.StateDictionary.Add((int)sl.AbortingState, new TimeSpan((long)(sl.AbortingState.Value) * 10000));
                        br.StateDictionary.Add((int)sl.ActivatingState, new TimeSpan((long)(sl.ActivatingState.Value) * 10000));
                        br.StateDictionary.Add((int)sl.ClearingState, new TimeSpan((long)(sl.ClearingState.Value) * 10000));
                        br.StateDictionary.Add((int)sl.CompleteState, new TimeSpan((long)(sl.CompleteState.Value) * 10000));
                        br.StateDictionary.Add((int)sl.CompletingState, new TimeSpan((long)(sl.CompletingState.Value) * 10000));
                        br.StateDictionary.Add((int)sl.DeactivatedState, new TimeSpan((long)(sl.DeactivatedState.Value) * 10000));
                        br.StateDictionary.Add((int)sl.DeactivatingState, new TimeSpan((long)(sl.DeactivatingState.Value) * 10000));
                        br.StateDictionary.Add((int)sl.ExecuteState, new TimeSpan((long)(sl.ExecuteState.Value) * 10000));
                        br.StateDictionary.Add((int)sl.HeldState, new TimeSpan((long)(sl.HeldState.Value) * 10000));
                        br.StateDictionary.Add((int)sl.HoldingState, new TimeSpan((long)(sl.HoldingState.Value) * 10000));
                        br.StateDictionary.Add((int)sl.IdleState, new TimeSpan((long)(sl.IdleState.Value) * 10000));
                        br.StateDictionary.Add((int)sl.ResettingState, new TimeSpan((long)(sl.ResettingState.Value) * 10000));
                        br.StateDictionary.Add((int)sl.StartingState, new TimeSpan((long)(sl.StartingState.Value) * 10000));
                        br.StateDictionary.Add((int)sl.StoppedState, new TimeSpan((long)(sl.StoppedState.Value) * 10000));
                        br.StateDictionary.Add((int)sl.StoppingState, new TimeSpan((long)(sl.StoppingState.Value) * 10000));
                        br.StateDictionary.Add((int)sl.SuspendedState, new TimeSpan((long)(sl.SuspendedState.Value) * 10000));
                    }

                    br.StateDictionary = (context.StateLogs.SqlQuery("SELECT * FROM dbo.StateLog WHERE BatchReportID = @id", new SqlParameter("@id", br.BatchReportID))).ToDictionary();
                    batchList.Add(br);
                }
            }
            
            return batchList;
        }
    }

}
