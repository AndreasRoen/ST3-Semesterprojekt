using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BeerProductionSystem.DTOClasses;
using System.IO;

namespace BeerProductionSystem.PersistenceLayer.DatabaseModule
{
    class FileWriter : IDatabaseController
    {

        public bool SaveBatchReport(BatchReportDTO BatchReport)
        {
            string path = Directory.GetCurrentDirectory() + "\\BatchReport_ID:" +  BatchReport.BatchID.ToString() + ".txt" ;
            string[] report = { BatchReport.BatchID.ToString(), BatchReport.ProductType.ToString(), BatchReport.AmountOfProductsTotal.ToString(),
            BatchReport.AmountOfProductsAcceptable.ToString(), BatchReport.AmountOfProductsDefect.ToString(), BatchReport.AmountOfTimeInStates.ToString(),
            BatchReport.LoggingOfTemperature.ToString(), BatchReport.LoggingOfHumidity.ToString()};
            File.WriteAllLines(path, report);
            return true;
        }
    }
}
