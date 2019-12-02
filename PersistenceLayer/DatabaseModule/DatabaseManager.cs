using BeerProductionSystem.DOClasses;
using BeerProductionSystem.PersistenceLayer.DatabaseModule;
using System;
using System.Linq;
using System.IO;
using System.Reflection;
using System.Windows.Forms;
using System.Collections.Generic;

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
                List<BatchReport> batches = context.BatchReports.ToList();
                foreach (BatchReport br in batches)
                {
                    //Implement TODO
                    //br.EnvironmentalLogs = context.EnvironmentalLogs.
                    //br.StateLogs = context.StateLogs.
                }
            }
            
            return batchList;
        }
    }

}
