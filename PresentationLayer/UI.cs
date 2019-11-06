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
        public UI()
        {
            InitializeComponent();
        }

        private void startBtn_Click(object sender, EventArgs e)
        {
            var productType = productTypeComboBox.SelectedItem.ToString();
            //Debug.WriteLine(productType);
            ushort productionSpeed = (ushort)productionSpeedTrackBar.Value;
            ushort batchSize = (ushort)batchSizeNumericUpDownSize.Value;

            logicFacade.SendStartCommand(0, productionSpeed, batchSize);
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
            LiveRelevantDataDTO data = logicFacade.UpdateData();

            temperatureLabel.Text = data.Temperature.ToString();
            humidityLabel.Text = data.Humidity.ToString();
            vibrationLabel.Text = data.Vibration.ToString();
            batchIDLabel.Text = data.BatchID.ToString();
            productsPerMinuteLabel.Text = data.ActualMachineSpeed.ToString();
            batchSizeLabel.Text = data.BatchSize.ToString();
            producedLabel.Text = data.ProducedProducts.ToString();
            defectLabel.Text = data.DefectProducts.ToString();
            acceptableLabel.Text = data.AcceptableProducts.ToString();
            int currentState = data.CurrentState;
            var state = (MachineState)data.CurrentState;
            currentStateLabel.Text = state.ToString();
        }

        private void productionSpeedTrackBar_ValueChanged(object sender, EventArgs e)
        {
            productionSpeedLabel.Text = productionSpeedTrackBar.Value.ToString();
        }

        private void productTypeComboBox_SelectedIndexChanged(object sender, EventArgs e)   //TODO refactor
        {
            string selectedProductType = productTypeComboBox.SelectedItem.ToString();
            Enum.TryParse(selectedProductType, out ProductMaxSpeed maxSpeed);  //https://stackoverflow.com/questions/16100/convert-a-string-to-an-enum-in-c-sharp

            productionSpeedTrackBar.Maximum = (int)maxSpeed;
            maxProductionSpeedLabel.Text = ((int)maxSpeed).ToString();

            Int32.TryParse(productionSpeedLabel.Text, out int currentSpeed);
            if ((int)maxSpeed < currentSpeed)
            {
                productionSpeedLabel.Text = ((int)maxSpeed).ToString();
            }
        }
    }
}
