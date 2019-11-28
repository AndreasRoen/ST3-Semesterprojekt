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

            logicFacade.SendStartCommand((ushort) productType, productionSpeed, batchSize);
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
            ushort id = 0;
            try
            {
                if(searchTextBox.Text != null)
                id = ushort.Parse(searchTextBox.Text);
            } catch (FormatException ex)
            {

            }

            //List<BatchReportDO> reports = logicFacade.getBatchReports();
            reports.Add(new BatchReportDO(1, 2, 3, 4, 5, new Dictionary<int, TimeSpan>(), new List<float>(), new List<float>()));
            List<string> selectedReports = new List<string>();
            {
                for(int i = 0; i < reports.Count; i++)
                {
                    if (!reports[i].BatchID.Equals(id) && id!=0)
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
            BatchReportDO chosen = reports[itemIndex];
            chosenReport.Text = "Batch ID: " + chosen.BatchID + "\n Producttype: " + chosen.ProductType + "\n " +
                "Created products: " + chosen.AmountOfProductsTotal + "\n Acceptable products: " + chosen.AmountOfProductsAcceptable + "\n" +
                " Defective products: " + chosen.AmountOfProductsDefect + "\n" +
                GetTimeInStates(chosen.AmountOfTimeInStates) + "\n" +
                GetLoggingInfo("Temperature: ", chosen.LoggingOfTemperature) + "\n" +
                GetLoggingInfo("Humidity: ",chosen.LoggingOfHumidity);
        }

        private string GetTimeInStates(Dictionary<int, TimeSpan> timeInStates)
        {
            string statesTime = "";
            foreach(var state in timeInStates)
            {
                statesTime += state.Key + ": " + state.Value.TotalSeconds + "\n";
            }

            return statesTime;
        }

        private string GetLoggingInfo(string description, List<float> loggingList)
        {
            float min = 0;
            float max = 0;
            float total = 0;
            foreach(var info in loggingList)
            {
                if(info > max)
                {
                    max = info;
                }else if(info < min)
                {
                    min = info;
                }
                total += info;
            }
            float avg = total / loggingList.Count;
            string allInfo = description + "\nMinimum: " + min + "\n Maximum: " + max + "\n Average : " + avg;
            return allInfo;
        }
    }
}