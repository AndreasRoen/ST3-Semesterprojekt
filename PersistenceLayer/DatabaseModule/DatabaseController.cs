using BeerProductionSystem.DTOClasses;
using BeerProductionSystem.PersistenceLayer.DatabaseModule.DTOClasses;
using System;
using System.Linq;
using System.IO;
using System.Reflection;
using System.Windows.Forms;
using System.Collections.Generic;

namespace BeerProductionSystem.PersistenceLayer.DatabaseModule {
    class DatabaseController : IDatabaseController {

        public DatabaseController() {

        }

        public bool SaveBatchReport(BatchReportDO batchReport)
        {
            bool success = false;
            using (DataContext context = new DataContext())
            {
                
                BatchReportDTO data = new BatchReportDTO
                {
                    MachineSpeed = batchReport.MachineSpeed,
                    ProductType = batchReport.ProductType,
                    TotalAmount = batchReport.AmountOfProductsTotal,
                    AcceptableAmount = 0,
                    DefectAmount = 0,
                    ProductionStartTime = System.DateTime.Now
                };

                context.BatchReports.Add(data);
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
                BatchReportDTO batchReport = context.BatchReports.OrderByDescending(
                    b => b.BatchReportID).FirstOrDefault();

                //Create a new entry of environmental log
                EnvironmentalLogDTO environmentalLog = new EnvironmentalLogDTO
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

        public BatchReportDTO LoadBatchReport(int BatchID)
        {
            BatchReportDTO data = new BatchReportDTO();
            using(DataContext context = new DataContext())
            {
                data = context.BatchReports.Find(BatchID);
            }
            return data;
        }

        public List<string[]> BatchOverview()
        {
            throw new NotImplementedException();
        }
    }

}
