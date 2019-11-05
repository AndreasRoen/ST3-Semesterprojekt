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
            string path = AppDomain.CurrentDomain.BaseDirectory + "BatchReport_ID_" +  BatchReport.BatchID.ToString() + ".txt" ;
            string batchid = "Batch ID: " + BatchReport.BatchID.ToString();
            string productType = "Product ID: " + BatchReport.ProductType.ToString();
            string amountTotal = "Total amount of products: " + BatchReport.AmountOfProductsTotal.ToString();
            string amountAcc = "Acceptable amount of products: " + BatchReport.AmountOfProductsAcceptable.ToString();
            string amountDef = "Defect amount of products: " + BatchReport.AmountOfProductsDefect.ToString();
            string amountState = GetTimeinStates(BatchReport.AmountOfTimeInStates);
            string logTemp = LoggingOfInfo("Logging of overall temperature:", BatchReport.LoggingOfTemperature);
            string logHum = LoggingOfInfo("Logging of overall humidity:", BatchReport.LoggingOfHumidity);
            string[] report = {batchid, productType, amountTotal, amountAcc, amountDef, amountState, logTemp, logHum};
            File.WriteAllLines(path, report);
            return true;
        }

        private string GetTimeinStates(Dictionary<int, int> states)
        {
            string stateLines = "";
            foreach (KeyValuePair<int, int> state in states)
            {
                stateLines = states + "Time in state " + state.Key.ToString() + ": " + state.Value.ToString() + ", \t";
            }
            return stateLines;
        }

        private string LoggingOfInfo(string infoAbout, List<float> list)
        {
            string logging = infoAbout + "\n";
            float min = 0;
            float max = 0;
            float avg = 0;
            for (int i = 0; i < list.Count; i++)
            {
                if(list[i] > max)
                {
                    max = list[i];
                }
                if(list[i] < min)
                {
                    min = list[i];
                }
                avg += list[i];
            }
            avg = avg / list.Count;

            logging = logging + "Minimum: " + min.ToString() + "\t Maximum: " + max.ToString() + "\t Average: " + avg.ToString();
            return logging;
        }


    }
}
