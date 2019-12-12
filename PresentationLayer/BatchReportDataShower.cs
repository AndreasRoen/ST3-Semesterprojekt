using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms.DataVisualization.Charting;
using BeerProductionSystem.DOClasses;
using BeerProductionSystem.BusinessLayer;

namespace BeerProductionSystem.PresentationLayer
{
    public class BatchReportDataShower
    {
        private List<Chart> charts;

        public BatchReportDataShower(List<Chart> charts)
        {
            this.charts = charts;
        }

        public string ShowBatchInfo(BatchDO chosenBatchReport)
        {
            return "Batch ID: " + chosenBatchReport.BatchReportID + "\n" +
                "Producttype: " + (ProductType)chosenBatchReport.ProductType + "\n" +
                "Created products: " + chosenBatchReport.BatchSize + "\n" +
                "Acceptable products: " + chosenBatchReport.ProducedProducts + "\n" +
                "Defective products: " + chosenBatchReport.DefectProducts + "\n" +
                GetTimeInStates(chosenBatchReport.StateDictionary) + "\n" +
                GetAllEnvironmentalInfo(chosenBatchReport.EnvironmentalLogs);
        }

        private string GetTimeInStates(Dictionary<int, TimeSpan> timeInStates)
        {
            charts[0].Visible = true;
            charts[0].Series["States"].Points.Clear();
            string statesTime = "Time in states: ";
            foreach (var state in timeInStates)
            {
                charts[0].Series["States"].Points.AddXY(((MachineState)state.Key).ToString(), state.Value.TotalSeconds);
                statesTime += "\n  " + (MachineState)state.Key + ": " + state.Value.TotalSeconds + " seconds";
            }

            return statesTime;
        }

        private string GetAllEnvironmentalInfo(ICollection<EnvironmentalLogDO> envLogs)
        {
            try
            {
                List<List<float>> logs = SeperateEnvironmentalLogInfo(envLogs);
                string humidityInfo = GetSpecificLoggingInfo("Humidity", logs[0], charts[1]);
                string tempInfo = GetSpecificLoggingInfo("Temperature", logs[1], charts[2]);
                return humidityInfo + "\n" + tempInfo;
            }
            catch (NullReferenceException)
            {

            }
            catch (InvalidOperationException)
            {

            }
            return "No environment information.";
        }

        private string GetSpecificLoggingInfo(string description, List<float> loggingList, System.Windows.Forms.DataVisualization.Charting.Chart chart)
        {
            chart.Visible = true;
            chart.Series[description].Points.Clear();
            double sec = 0;
            foreach (var info in loggingList)
            {
                chart.Series[description].Points.AddXY(sec, info);
                sec += 0.400;
            }
            string allInfo = description + ": \n  Minimum: " + loggingList.Min() + "\n  Maximum: "
                + loggingList.Max() + "\n  Average : " + loggingList.Average();
            return allInfo;
        }

        private List<List<float>> SeperateEnvironmentalLogInfo(ICollection<EnvironmentalLogDO> logs)
        {
            List<List<float>> envLogs = new List<List<float>>();
            List<float> humidity = new List<float>();
            List<float> temp = new List<float>();
            int i = 0;

            foreach (var log in logs)
            {
                if (i % 5 == 0)
                {
                    humidity.Add((float)log.Humidity);
                    temp.Add((float)log.Temperature);
                }
                i++;
            }
            envLogs.Add(humidity);
            envLogs.Add(temp);
            return envLogs;
        }
    }
}
