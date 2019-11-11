﻿using BeerProductionSystem.DTOClasses;
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
            int productType = (int)productTypeComboBox.SelectedItem;
            ushort productionSpeed = (ushort)productionSpeedTrackBar.Value;
            ushort batchSize = (ushort)batchSizeNumericUpDownSize.Value;

            logicFacade.SendStartCommand(productType, productionSpeed, batchSize);
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
            string selectedProduct = ((ProductType)productTypeComboBox.SelectedItem).ToString();

            // Convert enum ProductType to ProductMaxSpeed by name
            ProductMaxSpeed productMaxSpeed = (ProductMaxSpeed)Enum.Parse(typeof(ProductMaxSpeed), selectedProduct);
            int maxSpeed = (int)productMaxSpeed;

            productionSpeedTrackBar.Maximum = maxSpeed;
            maxProductionSpeedLabel.Text = maxSpeed.ToString();

            Int32.TryParse(productionSpeedLabel.Text, out int currentSpeed);
            if (maxSpeed < currentSpeed)
            {
                productionSpeedLabel.Text = (maxSpeed).ToString();
            }
        }
    }
    public class VerticalProgressBar : ProgressBar
    {
        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                cp.Style |= 0x04;
                return cp;
            }
        }
    }
}