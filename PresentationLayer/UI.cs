using BeerProductionSystem.DTOClasses;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BeerProductionSystem.PresentationLayer
{
    public partial class UI : Form
    {
        private List<BatchReportDO> reports;
        public UI()
        {
            InitializeComponent();
            reports = new List<BatchReportDO>();
        }

        private void startBtn_Click(object sender, EventArgs e)
        {
            int productType = (int)productTypeComboBox.SelectedItem;
            ushort productionSpeed = (ushort)productionSpeedTrackBar.Value;
            ushort batchSize = (ushort)batchSizeNumericUpDownSize.Value;

            logicFacade.SendStartCommand((ushort)productType, productionSpeed, batchSize);
        }

        private void stopBtn_Click(object sender, EventArgs e)
        {
            logicFacade.SendStopCommand();
        }

        private void resetBtn_Click(object sender, EventArgs e)
        {
            logicFacade.SendResetCommand();
        }

        private void clearBtn_Click(object sender, EventArgs e)
        {
            logicFacade.SendClearCommand();
        }

        private void abortBtn_Click(object sender, EventArgs e)
        {
            logicFacade.SendAbortCommand();
        }

        private void UpdateLiveRelevantData(object sender, EventArgs e)
        {
            LiveRelevantDataDO data = logicFacade.UpdateData();

            temperatureLabel.Text = data.Temperature.ToString();
            humidityLabel.Text = data.Humidity.ToString();
            vibrationLabel.Text = data.Vibration.ToString();
            batchIDLabel.Text = data.BatchID.ToString();
            productsPerMinuteLabel.Text = data.ActualMachineSpeed.ToString();
            batchSizeLabel.Text = data.BatchSize.ToString();
            producedLabel.Text = data.ProducedProducts.ToString();
            defectLabel.Text = data.DefectProducts.ToString();
            acceptableLabel.Text = data.AcceptableProducts.ToString();
            var state = (MachineState)data.CurrentState;
            currentStateLabel.Text = state.ToString();
            verticalProgressBarBarley.Value = (int)data.Barley;
            verticalProgressBarHops.Value = (int)data.Hops;
            verticalProgressBarMalt.Value = (int)data.Malt;
            verticalProgressBarWheat.Value = (int)data.Wheat;
            verticalProgressBarYeast.Value = (int)data.Yeast;
            verticalProgressBarMaintenance.Value = (int)data.MaintainenceMeter;
        }

        private void productionSpeedTrackBar_ValueChanged(object sender, EventArgs e)
        {
            productionSpeedLabel.Text = productionSpeedTrackBar.Value.ToString();
        }

        private void productTypeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

            string selectedProductType = productTypeComboBox.SelectedItem.ToString();
            int maxSpeed = logicFacade.GetProductMaxSpeed(selectedProductType);
            // Enum.TryParse(selectedProductType, out ProductMaxSpeed maxSpeed);  //https://stackoverflow.com/questions/16100/convert-a-string-to-an-enum-in-c-sharp


            productionSpeedTrackBar.Maximum = maxSpeed;
            maxProductionSpeedLabel.Text = maxSpeed.ToString();

            Int32.TryParse(productionSpeedLabel.Text, out int currentSpeed);
            if (maxSpeed < currentSpeed)
            {
                productionSpeedLabel.Text = (maxSpeed).ToString();
            }
        }

        private void getBatches_Click(object sender, EventArgs e)
        {
            int batchId = -1;
            try
            {
                if (searchTextBox.Text != null)
                {
                    batchId = int.Parse(searchTextBox.Text);
                }
            }
            catch (FormatException ex)
            {

            }


            List<string> selectedReports = new List<string>();
            {
                for (int i = 0; i < reports.Count; i++)
                {
                    if(batchId < 0)
                    {
                        break;
                    }
                    if (!reports[i].BatchID.Equals(batchId))
                    {
                        reports.RemoveAt(i);
                    }
                }
                for (int i = 0; i < reports.Count; i++)
                {
                    selectedReports.Add("Batchreport ID: " + reports[i].BatchID);
                }
            }
            listBoxBatches.DataSource = selectedReports;
        }

        private void ShowBatchReport_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            int itemIndex = listBoxBatches.SelectedIndex;
            BatchReportDO chosenReport = reports[itemIndex];
            this.chosenReport.Text = "Batch ID: " + chosenReport.BatchID + "\n" +
                "Producttype: " + (ProductType)chosenReport.ProductType + "\n" +
                "Created products: " + chosenReport.AmountOfProductsTotal + "\n" +
                "Acceptable products: " + chosenReport.AmountOfProductsAcceptable + "\n" +
                "Defective products: " + chosenReport.AmountOfProductsDefect + "\n" +
                GetTimeInStates(chosenReport.AmountOfTimeInStates) + "\n" +
                GetLoggingInfo("Temperature", chosenReport.LoggingOfTemperature, tempChart) + "\n" +
                GetLoggingInfo("Humidity", chosenReport.LoggingOfHumidity, humidityChart);
        }

        private string GetTimeInStates(Dictionary<int, TimeSpan> timeInStates)
        {
            chartStates.Visible = true;
            chartStates.Series["States"].Points.Clear();
            string statesTime = "Time in states: ";
            foreach (var state in timeInStates)
            {
                chartStates.Series["States"].Points.AddXY(((MachineState)state.Key).ToString(), state.Value.TotalSeconds);
                statesTime += "\n  "+ (MachineState)state.Key + ": " + state.Value.TotalSeconds + " seconds";
            }

            return statesTime;
        }

        private string GetLoggingInfo(string description, List<float> loggingList, System.Windows.Forms.DataVisualization.Charting.Chart chart)
        {
            chart.Visible = true;
            float min = 100000;
            float max = 0;
            float total = 0;
            int sec = 0;
            foreach (var info in loggingList)
            {
                chart.Series[description].Points.AddXY(sec, info);
                sec++;
                if (info > max)
                {
                    max = info;
                }
                if (info < min)
                {
                    min = info;
                }
                total += info;
            }
            float avg = total / loggingList.Count;
            string allInfo = description + ": \n  Minimum: " + min + "\n  Maximum: " + max + "\n  Average : " + avg;
            return allInfo;
        }
    }
}