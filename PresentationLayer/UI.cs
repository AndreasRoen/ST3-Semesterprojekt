using BeerProductionSystem.BusinessLayer;
using BeerProductionSystem.DOClasses;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace BeerProductionSystem.PresentationLayer
{
    public partial class UI : Form
    {
        private List<BatchDO> reports;
        private BatchReportDataShower batchReportShower;
        public UI()
        {
            InitializeComponent();
            reports = new List<BatchDO>();
            List<Chart> charts = new List<Chart>();
            charts.Add(chartStates);
            charts.Add(humidityChart);
            charts.Add(tempChart);
            batchReportShower = new BatchReportDataShower(charts);
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
            BatchProgressBar.Value = 0;
            UpdateOEELabel();
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
            try
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

                if (currentStateLabel.Text.Equals("Execute"))
                {
                    BatchProgressBar.Value = ((Int32)data.ProducedProducts * 100) / (Int32)data.BatchSize;
                }
                else if (currentStateLabel.Text.Equals("Complete"))
                {
                    BatchProgressBar.Value = 100;
                }
            }
            catch (Exception ex)
            {
                if (ex is InvalidOperationException || ex is Opc.UaFx.OpcException)
                {
                    if (!logicFacade.CheckMachineConnection())
                    {
                        disconnectedLabel.Visible = true;
                        disconnectedLabel2.Visible = true;
                        tabPage.Enabled = false;

                        if (logicFacade.ConnectToMachine(""))
                        {
                            disconnectedLabel.Visible = false;
                            disconnectedLabel2.Visible = false;
                            tabPage.Enabled = true;
                        }
                    }
                    else { Debug.WriteLine(ex.StackTrace); }
                }
                else
                {
                    throw;
                }
            }
        }

        private void productionSpeedTrackBar_ValueChanged(object sender, EventArgs e)
        {
            productionSpeedLabel.Text = productionSpeedTrackBar.Value.ToString();
            SetEstimatedError();
        }

        private void setOptimalSpeedBtn_Click(object sender, EventArgs e)
        {
            int productType = (int)productTypeComboBox.SelectedItem;
            productionSpeedTrackBar.Value = logicFacade.GetOptimalProductionSpeed((ushort)productType);
            productionSpeedTrackBar_ValueChanged(sender, e);
        }

        private void SetEstimatedError()
        {
            int productType = (int)productTypeComboBox.SelectedItem;
            ushort productionSpeed = (ushort)productionSpeedTrackBar.Value;
            eefLabel.Text = logicFacade.GetEstimatedError((ushort)productType, productionSpeed).ToString() + " %";
        }

        private void productTypeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedProductType = productTypeComboBox.SelectedItem.ToString();
            int maxSpeed = logicFacade.GetProductMaxSpeed(selectedProductType);
            // Enum.TryParse(selectedProductType, out ProductMaxSpeed maxSpeed);  //https://stackoverflow.com/questions/16100/convert-a-string-to-an-enum-in-c-sharp

            UpdateOEELabel();
            productionSpeedTrackBar.Maximum = maxSpeed;
            maxProductionSpeedLabel.Text = maxSpeed.ToString();

            Int32.TryParse(productionSpeedLabel.Text, out int currentSpeed);
            if (maxSpeed < currentSpeed)
            {
                productionSpeedLabel.Text = (maxSpeed).ToString();
            }

            SetEstimatedError();
        }

        private void UpdateOEELabel()
        {
            string selectedProductType = productTypeComboBox.SelectedItem.ToString();
            int productType = logicFacade.GetProductTypeNumber(selectedProductType);
            List<BatchDO> batchList = logicFacade.GetAllBatchReports();
            OEELabel.Text = logicFacade.GetTotalOptimalEquipmentEffectiveness(batchList, productType).ToString();
        }

        // Making sure all forms close when the user closes the main form
        private void UI_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void getBatches_Click(object sender, EventArgs e)
        {
            reports.Clear();
            int batchId = -1;
            BatchDO specificReport = null;

            if (searchTextBox.Text != null && int.TryParse(searchTextBox.Text, out batchId))
            {
                specificReport = logicFacade.GetSpecificReport(batchId);
            }

            if (specificReport != null)
            {
                reports.Add(specificReport);
                chosenReport.Text = batchReportShower.ShowBatchInfo(specificReport);
            }
            else
            {
                reports = logicFacade.GetAllBatchReports();
            }


            List<string> selectedReports = new List<string>();
            for (int i = 0; i < reports.Count; i++)
            {
                selectedReports.Add("Batchreport ID: " + reports[i].BatchReportID);
            }

            listBoxBatches.DataSource = selectedReports;
        }

        private void ShowBatchReport_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            int itemIndex = listBoxBatches.SelectedIndex;
            BatchDO chosenBatchReport = reports[itemIndex];
            chosenReport.Text = batchReportShower.ShowBatchInfo(chosenBatchReport);
        }

        private string GetTimeInStates(Dictionary<int, TimeSpan> timeInStates)
        {
            chartStates.Visible = true;
            chartStates.Series["States"].Points.Clear();
            string statesTime = "Time in states: ";
            foreach (var state in timeInStates)
            {
                chartStates.Series["States"].Points.AddXY(((MachineState)state.Key).ToString(), state.Value.TotalSeconds);
                statesTime += "\n  " + (MachineState)state.Key + ": " + state.Value.TotalSeconds + " seconds";
            }

            return statesTime;
        }

        private string GetAllEnvironmentalInfo(ICollection<EnvironmentalLogDO> envLogs)
        {
            try
            {
                List<List<float>> logs = SeperateEnvironmentalLogInfo(envLogs);
                string humidityInfo = GetSpecificLoggingInfo("Humidity", logs[0], humidityChart);
                string tempInfo = GetSpecificLoggingInfo("Temperature", logs[1], tempChart);
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

        private string GetSpecificLoggingInfo(string description, List<float> loggingList, Chart chart)
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