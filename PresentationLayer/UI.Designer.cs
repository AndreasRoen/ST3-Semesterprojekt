using BeerProductionSystem.Aquaintence;
using System;
using System.Diagnostics;

namespace BeerProductionSystem.PresentationLayer
{
    partial class UI
    {
        private ILogicFacade logicFacade;

        public UI(ILogicFacade logicFacade) : this()
        {
            this.logicFacade = logicFacade;
            productionSpeedLabel.Text = productionSpeedTrackBar.Value.ToString();

            productTypeComboBox.DataSource = Enum.GetValues(typeof(ProductType));

        }

        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title2 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title3 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.tab1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.setOptimalSpeedBtn = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.eefLabel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.BatchProgressBar = new System.Windows.Forms.ProgressBar();
            this.verticalProgressBarMaintenance = new BeerProductionSystem.PresentationLayer.VerticalProgressBar();
            this.verticalProgressBarYeast = new BeerProductionSystem.PresentationLayer.VerticalProgressBar();
            this.verticalProgressBarWheat = new BeerProductionSystem.PresentationLayer.VerticalProgressBar();
            this.verticalProgressBarMalt = new BeerProductionSystem.PresentationLayer.VerticalProgressBar();
            this.verticalProgressBarHops = new BeerProductionSystem.PresentationLayer.VerticalProgressBar();
            this.verticalProgressBarBarley = new BeerProductionSystem.PresentationLayer.VerticalProgressBar();
            this.maxProductionSpeedLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.productionSpeedLabel = new System.Windows.Forms.Label();
            this.productionSpeedTrackBar = new System.Windows.Forms.TrackBar();
            this.currentStateLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.batchSizeNumericUpDownSize = new System.Windows.Forms.NumericUpDown();
            this.productTypeComboBox = new System.Windows.Forms.ComboBox();
            this.YeastLabel = new System.Windows.Forms.Label();
            this.abortBtn = new System.Windows.Forms.Button();
            this.label19 = new System.Windows.Forms.Label();
            this.wheatLabel = new System.Windows.Forms.Label();
            this.maltLabel = new System.Windows.Forms.Label();
            this.hopsLabel = new System.Windows.Forms.Label();
            this.BarleyLabel = new System.Windows.Forms.Label();
            this.setSpeed = new System.Windows.Forms.Label();
            this.setSize = new System.Windows.Forms.Label();
            this.setType = new System.Windows.Forms.Label();
            this.maintenanceLabel = new System.Windows.Forms.Label();
            this.defectLabel = new System.Windows.Forms.Label();
            this.acceptableLabel = new System.Windows.Forms.Label();
            this.producedLabel = new System.Windows.Forms.Label();
            this.productsPerMinuteLabel = new System.Windows.Forms.Label();
            this.batchSizeLabel = new System.Windows.Forms.Label();
            this.batchIDLabel = new System.Windows.Forms.Label();
            this.vibrationLabel = new System.Windows.Forms.Label();
            this.humidityLabel = new System.Windows.Forms.Label();
            this.temperatureLabel = new System.Windows.Forms.Label();
            this.pictureBoxHumidity = new System.Windows.Forms.PictureBox();
            this.pictureBoxVibration = new System.Windows.Forms.PictureBox();
            this.pictureBoxBatchID = new System.Windows.Forms.PictureBox();
            this.pictureBoxAmountToProduce = new System.Windows.Forms.PictureBox();
            this.pictureBoxProductsPerMiunte = new System.Windows.Forms.PictureBox();
            this.pictureBoxDefectProducts = new System.Windows.Forms.PictureBox();
            this.pictureBoxAcceptableProducts = new System.Windows.Forms.PictureBox();
            this.pictureBoxProduced = new System.Windows.Forms.PictureBox();
            this.pictureBoxTemperature = new System.Windows.Forms.PictureBox();
            this.clearBtn = new System.Windows.Forms.Button();
            this.resetBtn = new System.Windows.Forms.Button();
            this.stopBtn = new System.Windows.Forms.Button();
            this.startBrn = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.humidityChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.tempChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chartStates = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chosenReport = new System.Windows.Forms.RichTextBox();
            this.searchTextBox = new System.Windows.Forms.TextBox();
            this.getBatches = new System.Windows.Forms.Button();
            this.listBoxBatches = new System.Windows.Forms.ListBox();
            this.updateData = new System.Windows.Forms.Timer(this.components);
            this.tab1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.productionSpeedTrackBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.batchSizeNumericUpDownSize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxHumidity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxVibration)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBatchID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAmountToProduce)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxProductsPerMiunte)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDefectProducts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAcceptableProducts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxProduced)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxTemperature)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.humidityChart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tempChart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartStates)).BeginInit();
            this.SuspendLayout();
            // 
            // tab1
            // 
            this.tab1.Controls.Add(this.tabPage1);
            this.tab1.Controls.Add(this.tabPage2);
            this.tab1.Location = new System.Drawing.Point(-1, -2);
            this.tab1.Margin = new System.Windows.Forms.Padding(2);
            this.tab1.Name = "tab1";
            this.tab1.SelectedIndex = 0;
            this.tab1.Size = new System.Drawing.Size(710, 486);
            this.tab1.TabIndex = 33;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.setOptimalSpeedBtn);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.eefLabel);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.BatchProgressBar);
            this.tabPage1.Controls.Add(this.verticalProgressBarMaintenance);
            this.tabPage1.Controls.Add(this.verticalProgressBarYeast);
            this.tabPage1.Controls.Add(this.verticalProgressBarWheat);
            this.tabPage1.Controls.Add(this.verticalProgressBarMalt);
            this.tabPage1.Controls.Add(this.verticalProgressBarHops);
            this.tabPage1.Controls.Add(this.verticalProgressBarBarley);
            this.tabPage1.Controls.Add(this.maxProductionSpeedLabel);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.productionSpeedLabel);
            this.tabPage1.Controls.Add(this.productionSpeedTrackBar);
            this.tabPage1.Controls.Add(this.currentStateLabel);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.batchSizeNumericUpDownSize);
            this.tabPage1.Controls.Add(this.productTypeComboBox);
            this.tabPage1.Controls.Add(this.YeastLabel);
            this.tabPage1.Controls.Add(this.abortBtn);
            this.tabPage1.Controls.Add(this.label19);
            this.tabPage1.Controls.Add(this.wheatLabel);
            this.tabPage1.Controls.Add(this.maltLabel);
            this.tabPage1.Controls.Add(this.hopsLabel);
            this.tabPage1.Controls.Add(this.BarleyLabel);
            this.tabPage1.Controls.Add(this.setSpeed);
            this.tabPage1.Controls.Add(this.setSize);
            this.tabPage1.Controls.Add(this.setType);
            this.tabPage1.Controls.Add(this.maintenanceLabel);
            this.tabPage1.Controls.Add(this.defectLabel);
            this.tabPage1.Controls.Add(this.acceptableLabel);
            this.tabPage1.Controls.Add(this.producedLabel);
            this.tabPage1.Controls.Add(this.productsPerMinuteLabel);
            this.tabPage1.Controls.Add(this.batchSizeLabel);
            this.tabPage1.Controls.Add(this.batchIDLabel);
            this.tabPage1.Controls.Add(this.vibrationLabel);
            this.tabPage1.Controls.Add(this.humidityLabel);
            this.tabPage1.Controls.Add(this.temperatureLabel);
            this.tabPage1.Controls.Add(this.pictureBoxHumidity);
            this.tabPage1.Controls.Add(this.pictureBoxVibration);
            this.tabPage1.Controls.Add(this.pictureBoxBatchID);
            this.tabPage1.Controls.Add(this.pictureBoxAmountToProduce);
            this.tabPage1.Controls.Add(this.pictureBoxProductsPerMiunte);
            this.tabPage1.Controls.Add(this.pictureBoxDefectProducts);
            this.tabPage1.Controls.Add(this.pictureBoxAcceptableProducts);
            this.tabPage1.Controls.Add(this.pictureBoxProduced);
            this.tabPage1.Controls.Add(this.pictureBoxTemperature);
            this.tabPage1.Controls.Add(this.clearBtn);
            this.tabPage1.Controls.Add(this.resetBtn);
            this.tabPage1.Controls.Add(this.stopBtn);
            this.tabPage1.Controls.Add(this.startBrn);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(2);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(2);
            this.tabPage1.Size = new System.Drawing.Size(702, 460);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Visualization";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // setOptimalSpeedBtn
            // 
            this.setOptimalSpeedBtn.Location = new System.Drawing.Point(272, 92);
            this.setOptimalSpeedBtn.Name = "setOptimalSpeedBtn";
            this.setOptimalSpeedBtn.Size = new System.Drawing.Size(68, 45);
            this.setOptimalSpeedBtn.TabIndex = 93;
            this.setOptimalSpeedBtn.Text = "Set optimal speed";
            this.setOptimalSpeedBtn.UseVisualStyleBackColor = true;
            this.setOptimalSpeedBtn.Click += new System.EventHandler(this.setOptimalSpeedBtn_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(601, 11);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(51, 13);
            this.label6.TabIndex = 92;
            this.label6.Text = "oeeLabel";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(565, 11);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(29, 13);
            this.label5.TabIndex = 91;
            this.label5.Text = "OEE";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(130, 140);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 13);
            this.label4.TabIndex = 90;
            this.label4.Text = "Estimated Error:";
            // 
            // eefLabel
            // 
            this.eefLabel.AutoSize = true;
            this.eefLabel.Location = new System.Drawing.Point(245, 140);
            this.eefLabel.Name = "eefLabel";
            this.eefLabel.Size = new System.Drawing.Size(27, 13);
            this.eefLabel.TabIndex = 89;
            this.eefLabel.Text = "EEF";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(406, 78);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(148, 13);
            this.label3.TabIndex = 88;
            this.label3.Text = "Progress for Batch Production";
            // 
            // BatchProgressBar
            // 
            this.BatchProgressBar.Location = new System.Drawing.Point(381, 95);
            this.BatchProgressBar.Margin = new System.Windows.Forms.Padding(2);
            this.BatchProgressBar.Name = "BatchProgressBar";
            this.BatchProgressBar.Size = new System.Drawing.Size(188, 42);
            this.BatchProgressBar.TabIndex = 87;
            // 
            // verticalProgressBarMaintenance
            // 
            this.verticalProgressBarMaintenance.Location = new System.Drawing.Point(598, 80);
            this.verticalProgressBarMaintenance.Margin = new System.Windows.Forms.Padding(2);
            this.verticalProgressBarMaintenance.Maximum = 30000;
            this.verticalProgressBarMaintenance.Name = "verticalProgressBarMaintenance";
            this.verticalProgressBarMaintenance.Size = new System.Drawing.Size(75, 336);
            this.verticalProgressBarMaintenance.TabIndex = 86;
            // 
            // verticalProgressBarYeast
            // 
            this.verticalProgressBarYeast.Location = new System.Drawing.Point(494, 206);
            this.verticalProgressBarYeast.Margin = new System.Windows.Forms.Padding(2);
            this.verticalProgressBarYeast.Maximum = 35000;
            this.verticalProgressBarYeast.Name = "verticalProgressBarYeast";
            this.verticalProgressBarYeast.Size = new System.Drawing.Size(75, 61);
            this.verticalProgressBarYeast.TabIndex = 85;
            // 
            // verticalProgressBarWheat
            // 
            this.verticalProgressBarWheat.Location = new System.Drawing.Point(415, 206);
            this.verticalProgressBarWheat.Margin = new System.Windows.Forms.Padding(2);
            this.verticalProgressBarWheat.Maximum = 35000;
            this.verticalProgressBarWheat.Name = "verticalProgressBarWheat";
            this.verticalProgressBarWheat.Size = new System.Drawing.Size(75, 61);
            this.verticalProgressBarWheat.TabIndex = 84;
            // 
            // verticalProgressBarMalt
            // 
            this.verticalProgressBarMalt.Location = new System.Drawing.Point(334, 206);
            this.verticalProgressBarMalt.Margin = new System.Windows.Forms.Padding(2);
            this.verticalProgressBarMalt.Maximum = 35000;
            this.verticalProgressBarMalt.Name = "verticalProgressBarMalt";
            this.verticalProgressBarMalt.Size = new System.Drawing.Size(75, 61);
            this.verticalProgressBarMalt.TabIndex = 83;
            // 
            // verticalProgressBarHops
            // 
            this.verticalProgressBarHops.Location = new System.Drawing.Point(254, 206);
            this.verticalProgressBarHops.Margin = new System.Windows.Forms.Padding(2);
            this.verticalProgressBarHops.Maximum = 35000;
            this.verticalProgressBarHops.Name = "verticalProgressBarHops";
            this.verticalProgressBarHops.Size = new System.Drawing.Size(75, 61);
            this.verticalProgressBarHops.TabIndex = 82;
            // 
            // verticalProgressBarBarley
            // 
            this.verticalProgressBarBarley.Location = new System.Drawing.Point(175, 206);
            this.verticalProgressBarBarley.Margin = new System.Windows.Forms.Padding(2);
            this.verticalProgressBarBarley.Maximum = 35000;
            this.verticalProgressBarBarley.Name = "verticalProgressBarBarley";
            this.verticalProgressBarBarley.Size = new System.Drawing.Size(75, 61);
            this.verticalProgressBarBarley.TabIndex = 81;
            // 
            // maxProductionSpeedLabel
            // 
            this.maxProductionSpeedLabel.AutoSize = true;
            this.maxProductionSpeedLabel.BackColor = System.Drawing.SystemColors.Control;
            this.maxProductionSpeedLabel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.maxProductionSpeedLabel.Location = new System.Drawing.Point(241, 124);
            this.maxProductionSpeedLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.maxProductionSpeedLabel.Name = "maxProductionSpeedLabel";
            this.maxProductionSpeedLabel.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.maxProductionSpeedLabel.Size = new System.Drawing.Size(25, 13);
            this.maxProductionSpeedLabel.TabIndex = 80;
            this.maxProductionSpeedLabel.Text = "100";
            this.maxProductionSpeedLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(139, 124);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label2.Size = new System.Drawing.Size(13, 13);
            this.label2.TabIndex = 79;
            this.label2.Text = "0";
            // 
            // productionSpeedLabel
            // 
            this.productionSpeedLabel.AutoSize = true;
            this.productionSpeedLabel.Location = new System.Drawing.Point(245, 76);
            this.productionSpeedLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.productionSpeedLabel.Name = "productionSpeedLabel";
            this.productionSpeedLabel.Size = new System.Drawing.Size(25, 13);
            this.productionSpeedLabel.TabIndex = 78;
            this.productionSpeedLabel.Text = "100";
            this.productionSpeedLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // productionSpeedTrackBar
            // 
            this.productionSpeedTrackBar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.productionSpeedTrackBar.LargeChange = 50;
            this.productionSpeedTrackBar.Location = new System.Drawing.Point(132, 92);
            this.productionSpeedTrackBar.Maximum = 100;
            this.productionSpeedTrackBar.Name = "productionSpeedTrackBar";
            this.productionSpeedTrackBar.Size = new System.Drawing.Size(134, 45);
            this.productionSpeedTrackBar.SmallChange = 10;
            this.productionSpeedTrackBar.TabIndex = 77;
            this.productionSpeedTrackBar.TickFrequency = 10;
            this.productionSpeedTrackBar.Value = 100;
            this.productionSpeedTrackBar.ValueChanged += new System.EventHandler(this.productionSpeedTrackBar_ValueChanged);
            // 
            // currentStateLabel
            // 
            this.currentStateLabel.AutoSize = true;
            this.currentStateLabel.Location = new System.Drawing.Point(595, 31);
            this.currentStateLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.currentStateLabel.Name = "currentStateLabel";
            this.currentStateLabel.Size = new System.Drawing.Size(41, 13);
            this.currentStateLabel.TabIndex = 76;
            this.currentStateLabel.Text = "label30";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(528, 31);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label1.Size = new System.Drawing.Size(69, 13);
            this.label1.TabIndex = 75;
            this.label1.Text = "Current State";
            // 
            // batchSizeNumericUpDownSize
            // 
            this.batchSizeNumericUpDownSize.Location = new System.Drawing.Point(335, 29);
            this.batchSizeNumericUpDownSize.Margin = new System.Windows.Forms.Padding(2);
            this.batchSizeNumericUpDownSize.Maximum = new decimal(new int[] {
            65535,
            0,
            0,
            0});
            this.batchSizeNumericUpDownSize.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.batchSizeNumericUpDownSize.Name = "batchSizeNumericUpDownSize";
            this.batchSizeNumericUpDownSize.Size = new System.Drawing.Size(90, 20);
            this.batchSizeNumericUpDownSize.TabIndex = 74;
            this.batchSizeNumericUpDownSize.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // productTypeComboBox
            // 
            this.productTypeComboBox.FormattingEnabled = true;
            this.productTypeComboBox.Location = new System.Drawing.Point(132, 28);
            this.productTypeComboBox.Margin = new System.Windows.Forms.Padding(2);
            this.productTypeComboBox.Name = "productTypeComboBox";
            this.productTypeComboBox.Size = new System.Drawing.Size(90, 21);
            this.productTypeComboBox.TabIndex = 72;
            this.productTypeComboBox.Text = " -Select Beer -";
            this.productTypeComboBox.SelectedIndexChanged += new System.EventHandler(this.productTypeComboBox_SelectedIndexChanged);
            // 
            // YeastLabel
            // 
            this.YeastLabel.AutoSize = true;
            this.YeastLabel.Location = new System.Drawing.Point(512, 189);
            this.YeastLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.YeastLabel.Name = "YeastLabel";
            this.YeastLabel.Size = new System.Drawing.Size(34, 13);
            this.YeastLabel.TabIndex = 71;
            this.YeastLabel.Text = "Yeast";
            // 
            // abortBtn
            // 
            this.abortBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.abortBtn.Location = new System.Drawing.Point(9, 153);
            this.abortBtn.Margin = new System.Windows.Forms.Padding(2);
            this.abortBtn.Name = "abortBtn";
            this.abortBtn.Size = new System.Drawing.Size(74, 32);
            this.abortBtn.TabIndex = 64;
            this.abortBtn.Text = "Abort";
            this.abortBtn.UseVisualStyleBackColor = false;
            this.abortBtn.Click += new System.EventHandler(this.abortBtn_Click);
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(508, 24);
            this.label19.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(0, 13);
            this.label19.TabIndex = 63;
            // 
            // wheatLabel
            // 
            this.wheatLabel.AutoSize = true;
            this.wheatLabel.Location = new System.Drawing.Point(430, 189);
            this.wheatLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.wheatLabel.Name = "wheatLabel";
            this.wheatLabel.Size = new System.Drawing.Size(39, 13);
            this.wheatLabel.TabIndex = 62;
            this.wheatLabel.Text = "Wheat";
            // 
            // maltLabel
            // 
            this.maltLabel.AutoSize = true;
            this.maltLabel.Location = new System.Drawing.Point(360, 189);
            this.maltLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.maltLabel.Name = "maltLabel";
            this.maltLabel.Size = new System.Drawing.Size(27, 13);
            this.maltLabel.TabIndex = 61;
            this.maltLabel.Text = "Malt";
            // 
            // hopsLabel
            // 
            this.hopsLabel.AutoSize = true;
            this.hopsLabel.Location = new System.Drawing.Point(278, 189);
            this.hopsLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.hopsLabel.Name = "hopsLabel";
            this.hopsLabel.Size = new System.Drawing.Size(32, 13);
            this.hopsLabel.TabIndex = 60;
            this.hopsLabel.Text = "Hops";
            // 
            // BarleyLabel
            // 
            this.BarleyLabel.AutoSize = true;
            this.BarleyLabel.Location = new System.Drawing.Point(196, 189);
            this.BarleyLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.BarleyLabel.Name = "BarleyLabel";
            this.BarleyLabel.Size = new System.Drawing.Size(36, 13);
            this.BarleyLabel.TabIndex = 59;
            this.BarleyLabel.Text = "Barley";
            // 
            // setSpeed
            // 
            this.setSpeed.AutoSize = true;
            this.setSpeed.Location = new System.Drawing.Point(130, 75);
            this.setSpeed.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.setSpeed.Name = "setSpeed";
            this.setSpeed.Size = new System.Drawing.Size(111, 13);
            this.setSpeed.TabIndex = 58;
            this.setSpeed.Text = "Set production speed:";
            // 
            // setSize
            // 
            this.setSize.AutoSize = true;
            this.setSize.Location = new System.Drawing.Point(333, 11);
            this.setSize.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.setSize.Name = "setSize";
            this.setSize.Size = new System.Drawing.Size(77, 13);
            this.setSize.TabIndex = 57;
            this.setSize.Text = "Set batch size:";
            // 
            // setType
            // 
            this.setType.AutoSize = true;
            this.setType.Location = new System.Drawing.Point(130, 11);
            this.setType.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.setType.Name = "setType";
            this.setType.Size = new System.Drawing.Size(88, 13);
            this.setType.TabIndex = 56;
            this.setType.Text = "Set product type:";
            // 
            // maintenanceLabel
            // 
            this.maintenanceLabel.AutoSize = true;
            this.maintenanceLabel.Location = new System.Drawing.Point(607, 418);
            this.maintenanceLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.maintenanceLabel.Name = "maintenanceLabel";
            this.maintenanceLabel.Size = new System.Drawing.Size(69, 13);
            this.maintenanceLabel.TabIndex = 55;
            this.maintenanceLabel.Text = "Maintenance";
            // 
            // defectLabel
            // 
            this.defectLabel.AutoSize = true;
            this.defectLabel.Location = new System.Drawing.Point(370, 418);
            this.defectLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.defectLabel.Name = "defectLabel";
            this.defectLabel.Size = new System.Drawing.Size(41, 13);
            this.defectLabel.TabIndex = 54;
            this.defectLabel.Text = "label28";
            // 
            // acceptableLabel
            // 
            this.acceptableLabel.AutoSize = true;
            this.acceptableLabel.Location = new System.Drawing.Point(512, 418);
            this.acceptableLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.acceptableLabel.Name = "acceptableLabel";
            this.acceptableLabel.Size = new System.Drawing.Size(41, 13);
            this.acceptableLabel.TabIndex = 53;
            this.acceptableLabel.Text = "label29";
            // 
            // producedLabel
            // 
            this.producedLabel.AutoSize = true;
            this.producedLabel.Location = new System.Drawing.Point(512, 358);
            this.producedLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.producedLabel.Name = "producedLabel";
            this.producedLabel.Size = new System.Drawing.Size(41, 13);
            this.producedLabel.TabIndex = 52;
            this.producedLabel.Text = "label30";
            // 
            // productsPerMinuteLabel
            // 
            this.productsPerMinuteLabel.AutoSize = true;
            this.productsPerMinuteLabel.Location = new System.Drawing.Point(225, 427);
            this.productsPerMinuteLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.productsPerMinuteLabel.Name = "productsPerMinuteLabel";
            this.productsPerMinuteLabel.Size = new System.Drawing.Size(41, 13);
            this.productsPerMinuteLabel.TabIndex = 51;
            this.productsPerMinuteLabel.Text = "label31";
            // 
            // batchSizeLabel
            // 
            this.batchSizeLabel.AutoSize = true;
            this.batchSizeLabel.Location = new System.Drawing.Point(370, 358);
            this.batchSizeLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.batchSizeLabel.Name = "batchSizeLabel";
            this.batchSizeLabel.Size = new System.Drawing.Size(41, 13);
            this.batchSizeLabel.TabIndex = 50;
            this.batchSizeLabel.Text = "label32";
            // 
            // batchIDLabel
            // 
            this.batchIDLabel.AutoSize = true;
            this.batchIDLabel.Location = new System.Drawing.Point(225, 358);
            this.batchIDLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.batchIDLabel.Name = "batchIDLabel";
            this.batchIDLabel.Size = new System.Drawing.Size(41, 13);
            this.batchIDLabel.TabIndex = 49;
            this.batchIDLabel.Text = "label33";
            // 
            // vibrationLabel
            // 
            this.vibrationLabel.AutoSize = true;
            this.vibrationLabel.Location = new System.Drawing.Point(87, 427);
            this.vibrationLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.vibrationLabel.Name = "vibrationLabel";
            this.vibrationLabel.Size = new System.Drawing.Size(41, 13);
            this.vibrationLabel.TabIndex = 48;
            this.vibrationLabel.Text = "label34";
            // 
            // humidityLabel
            // 
            this.humidityLabel.AutoSize = true;
            this.humidityLabel.Location = new System.Drawing.Point(87, 358);
            this.humidityLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.humidityLabel.Name = "humidityLabel";
            this.humidityLabel.Size = new System.Drawing.Size(41, 13);
            this.humidityLabel.TabIndex = 47;
            this.humidityLabel.Text = "label35";
            // 
            // temperatureLabel
            // 
            this.temperatureLabel.AutoSize = true;
            this.temperatureLabel.Location = new System.Drawing.Point(87, 270);
            this.temperatureLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.temperatureLabel.Name = "temperatureLabel";
            this.temperatureLabel.Size = new System.Drawing.Size(41, 13);
            this.temperatureLabel.TabIndex = 46;
            this.temperatureLabel.Text = "label36";
            // 
            // pictureBoxHumidity
            // 
            this.pictureBoxHumidity.Image = global::BeerProductionSystem.Properties.Resources.Humidity;
            this.pictureBoxHumidity.Location = new System.Drawing.Point(18, 321);
            this.pictureBoxHumidity.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBoxHumidity.Name = "pictureBoxHumidity";
            this.pictureBoxHumidity.Size = new System.Drawing.Size(64, 62);
            this.pictureBoxHumidity.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxHumidity.TabIndex = 45;
            this.pictureBoxHumidity.TabStop = false;
            // 
            // pictureBoxVibration
            // 
            this.pictureBoxVibration.Image = global::BeerProductionSystem.Properties.Resources.Vibration;
            this.pictureBoxVibration.Location = new System.Drawing.Point(18, 396);
            this.pictureBoxVibration.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBoxVibration.Name = "pictureBoxVibration";
            this.pictureBoxVibration.Size = new System.Drawing.Size(64, 58);
            this.pictureBoxVibration.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxVibration.TabIndex = 44;
            this.pictureBoxVibration.TabStop = false;
            // 
            // pictureBoxBatchID
            // 
            this.pictureBoxBatchID.Image = global::BeerProductionSystem.Properties.Resources.BatchID;
            this.pictureBoxBatchID.Location = new System.Drawing.Point(158, 321);
            this.pictureBoxBatchID.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBoxBatchID.Name = "pictureBoxBatchID";
            this.pictureBoxBatchID.Size = new System.Drawing.Size(62, 65);
            this.pictureBoxBatchID.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxBatchID.TabIndex = 43;
            this.pictureBoxBatchID.TabStop = false;
            // 
            // pictureBoxAmountToProduce
            // 
            this.pictureBoxAmountToProduce.Image = global::BeerProductionSystem.Properties.Resources.AmountToProduce;
            this.pictureBoxAmountToProduce.Location = new System.Drawing.Point(291, 321);
            this.pictureBoxAmountToProduce.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBoxAmountToProduce.Name = "pictureBoxAmountToProduce";
            this.pictureBoxAmountToProduce.Size = new System.Drawing.Size(74, 62);
            this.pictureBoxAmountToProduce.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxAmountToProduce.TabIndex = 42;
            this.pictureBoxAmountToProduce.TabStop = false;
            // 
            // pictureBoxProductsPerMiunte
            // 
            this.pictureBoxProductsPerMiunte.Image = global::BeerProductionSystem.Properties.Resources.ProductsPerMinute;
            this.pictureBoxProductsPerMiunte.Location = new System.Drawing.Point(155, 396);
            this.pictureBoxProductsPerMiunte.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBoxProductsPerMiunte.Name = "pictureBoxProductsPerMiunte";
            this.pictureBoxProductsPerMiunte.Size = new System.Drawing.Size(65, 58);
            this.pictureBoxProductsPerMiunte.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxProductsPerMiunte.TabIndex = 41;
            this.pictureBoxProductsPerMiunte.TabStop = false;
            // 
            // pictureBoxDefectProducts
            // 
            this.pictureBoxDefectProducts.Image = global::BeerProductionSystem.Properties.Resources.DefectProducts;
            this.pictureBoxDefectProducts.Location = new System.Drawing.Point(291, 396);
            this.pictureBoxDefectProducts.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBoxDefectProducts.Name = "pictureBoxDefectProducts";
            this.pictureBoxDefectProducts.Size = new System.Drawing.Size(74, 58);
            this.pictureBoxDefectProducts.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxDefectProducts.TabIndex = 40;
            this.pictureBoxDefectProducts.TabStop = false;
            // 
            // pictureBoxAcceptableProducts
            // 
            this.pictureBoxAcceptableProducts.Image = global::BeerProductionSystem.Properties.Resources.AcceptableProducts;
            this.pictureBoxAcceptableProducts.Location = new System.Drawing.Point(432, 396);
            this.pictureBoxAcceptableProducts.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBoxAcceptableProducts.Name = "pictureBoxAcceptableProducts";
            this.pictureBoxAcceptableProducts.Size = new System.Drawing.Size(76, 58);
            this.pictureBoxAcceptableProducts.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxAcceptableProducts.TabIndex = 39;
            this.pictureBoxAcceptableProducts.TabStop = false;
            // 
            // pictureBoxProduced
            // 
            this.pictureBoxProduced.Image = global::BeerProductionSystem.Properties.Resources.Produced;
            this.pictureBoxProduced.Location = new System.Drawing.Point(452, 321);
            this.pictureBoxProduced.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBoxProduced.Name = "pictureBoxProduced";
            this.pictureBoxProduced.Size = new System.Drawing.Size(56, 71);
            this.pictureBoxProduced.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxProduced.TabIndex = 38;
            this.pictureBoxProduced.TabStop = false;
            // 
            // pictureBoxTemperature
            // 
            this.pictureBoxTemperature.Image = global::BeerProductionSystem.Properties.Resources.Temperature;
            this.pictureBoxTemperature.Location = new System.Drawing.Point(18, 240);
            this.pictureBoxTemperature.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBoxTemperature.Name = "pictureBoxTemperature";
            this.pictureBoxTemperature.Size = new System.Drawing.Size(64, 63);
            this.pictureBoxTemperature.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxTemperature.TabIndex = 37;
            this.pictureBoxTemperature.TabStop = false;
            // 
            // clearBtn
            // 
            this.clearBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.clearBtn.Location = new System.Drawing.Point(9, 116);
            this.clearBtn.Margin = new System.Windows.Forms.Padding(2);
            this.clearBtn.Name = "clearBtn";
            this.clearBtn.Size = new System.Drawing.Size(74, 32);
            this.clearBtn.TabIndex = 36;
            this.clearBtn.Text = "Clear";
            this.clearBtn.UseVisualStyleBackColor = false;
            this.clearBtn.Click += new System.EventHandler(this.clearBtn_Click);
            // 
            // resetBtn
            // 
            this.resetBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.resetBtn.Location = new System.Drawing.Point(9, 80);
            this.resetBtn.Margin = new System.Windows.Forms.Padding(2);
            this.resetBtn.Name = "resetBtn";
            this.resetBtn.Size = new System.Drawing.Size(74, 32);
            this.resetBtn.TabIndex = 35;
            this.resetBtn.Text = "Reset";
            this.resetBtn.UseVisualStyleBackColor = false;
            this.resetBtn.Click += new System.EventHandler(this.resetBtn_Click);
            // 
            // stopBtn
            // 
            this.stopBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.stopBtn.Location = new System.Drawing.Point(9, 43);
            this.stopBtn.Margin = new System.Windows.Forms.Padding(2);
            this.stopBtn.Name = "stopBtn";
            this.stopBtn.Size = new System.Drawing.Size(74, 32);
            this.stopBtn.TabIndex = 34;
            this.stopBtn.Text = "Stop";
            this.stopBtn.UseVisualStyleBackColor = false;
            this.stopBtn.Click += new System.EventHandler(this.stopBtn_Click);
            // 
            // startBrn
            // 
            this.startBrn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.startBrn.Location = new System.Drawing.Point(9, 6);
            this.startBrn.Margin = new System.Windows.Forms.Padding(2);
            this.startBrn.Name = "startBrn";
            this.startBrn.Size = new System.Drawing.Size(74, 32);
            this.startBrn.TabIndex = 33;
            this.startBrn.Text = "Start";
            this.startBrn.UseVisualStyleBackColor = false;
            this.startBrn.Click += new System.EventHandler(this.startBtn_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.humidityChart);
            this.tabPage2.Controls.Add(this.tempChart);
            this.tabPage2.Controls.Add(this.chartStates);
            this.tabPage2.Controls.Add(this.chosenReport);
            this.tabPage2.Controls.Add(this.searchTextBox);
            this.tabPage2.Controls.Add(this.getBatches);
            this.tabPage2.Controls.Add(this.listBoxBatches);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(2);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(2);
            this.tabPage2.Size = new System.Drawing.Size(702, 460);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Batches";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // humidityChart
            // 
            chartArea1.Name = "ChartArea1";
            this.humidityChart.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.humidityChart.Legends.Add(legend1);
            this.humidityChart.Location = new System.Drawing.Point(419, 290);
            this.humidityChart.Margin = new System.Windows.Forms.Padding(2);
            this.humidityChart.Name = "humidityChart";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series1.Legend = "Legend1";
            series1.Name = "Humidity";
            this.humidityChart.Series.Add(series1);
            this.humidityChart.Size = new System.Drawing.Size(259, 130);
            this.humidityChart.TabIndex = 6;
            this.humidityChart.Text = "humidityChart";
            title1.Name = "Title1";
            title1.Text = "Humidity";
            this.humidityChart.Titles.Add(title1);
            this.humidityChart.Visible = false;
            // 
            // tempChart
            // 
            this.tempChart.AccessibleName = "";
            chartArea2.Name = "ChartArea1";
            this.tempChart.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.tempChart.Legends.Add(legend2);
            this.tempChart.Location = new System.Drawing.Point(419, 155);
            this.tempChart.Margin = new System.Windows.Forms.Padding(2);
            this.tempChart.Name = "tempChart";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series2.Legend = "Legend1";
            series2.Name = "Temperature";
            this.tempChart.Series.Add(series2);
            this.tempChart.Size = new System.Drawing.Size(259, 130);
            this.tempChart.TabIndex = 5;
            this.tempChart.Text = "tempChart";
            title2.Name = "Title1";
            title2.Text = "Temperature chart";
            this.tempChart.Titles.Add(title2);
            this.tempChart.Visible = false;
            // 
            // chartStates
            // 
            chartArea3.Name = "ChartArea1";
            this.chartStates.ChartAreas.Add(chartArea3);
            legend3.Name = "Legend1";
            this.chartStates.Legends.Add(legend3);
            this.chartStates.Location = new System.Drawing.Point(419, 20);
            this.chartStates.Margin = new System.Windows.Forms.Padding(2);
            this.chartStates.Name = "chartStates";
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series3.Legend = "Legend1";
            series3.Name = "States";
            this.chartStates.Series.Add(series3);
            this.chartStates.Size = new System.Drawing.Size(259, 130);
            this.chartStates.TabIndex = 4;
            this.chartStates.Text = "chart1";
            title3.Name = "Title1";
            title3.Text = "Amount of time States";
            this.chartStates.Titles.Add(title3);
            this.chartStates.Visible = false;
            // 
            // chosenReport
            // 
            this.chosenReport.Location = new System.Drawing.Point(196, 56);
            this.chosenReport.Margin = new System.Windows.Forms.Padding(2);
            this.chosenReport.Name = "chosenReport";
            this.chosenReport.Size = new System.Drawing.Size(182, 290);
            this.chosenReport.TabIndex = 3;
            this.chosenReport.Text = "";
            // 
            // searchTextBox
            // 
            this.searchTextBox.Location = new System.Drawing.Point(8, 20);
            this.searchTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.searchTextBox.Name = "searchTextBox";
            this.searchTextBox.Size = new System.Drawing.Size(88, 20);
            this.searchTextBox.TabIndex = 2;
            // 
            // getBatches
            // 
            this.getBatches.Location = new System.Drawing.Point(99, 18);
            this.getBatches.Margin = new System.Windows.Forms.Padding(2);
            this.getBatches.Name = "getBatches";
            this.getBatches.Size = new System.Drawing.Size(73, 20);
            this.getBatches.TabIndex = 1;
            this.getBatches.Text = "Get batches";
            this.getBatches.UseVisualStyleBackColor = true;
            this.getBatches.Click += new System.EventHandler(this.getBatches_Click);
            // 
            // listBoxBatches
            // 
            this.listBoxBatches.FormattingEnabled = true;
            this.listBoxBatches.Location = new System.Drawing.Point(4, 56);
            this.listBoxBatches.Margin = new System.Windows.Forms.Padding(2);
            this.listBoxBatches.Name = "listBoxBatches";
            this.listBoxBatches.Size = new System.Drawing.Size(168, 290);
            this.listBoxBatches.TabIndex = 0;
            this.listBoxBatches.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.ShowBatchReport_MouseDoubleClick);
            // 
            // updateData
            // 
            this.updateData.Enabled = true;
            this.updateData.Interval = 400;
            this.updateData.Tick += new System.EventHandler(this.UpdateLiveRelevantData);
            // 
            // UI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(712, 483);
            this.Controls.Add(this.tab1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "UI";
            this.Text = "Beer Production System";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.UI_FormClosed);
            this.tab1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.productionSpeedTrackBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.batchSizeNumericUpDownSize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxHumidity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxVibration)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBatchID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAmountToProduce)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxProductsPerMiunte)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDefectProducts)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAcceptableProducts)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxProduced)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxTemperature)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.humidityChart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tempChart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartStates)).EndInit();
            this.ResumeLayout(false);

        }



        #endregion



        private System.Windows.Forms.TabControl tab1;

        private System.Windows.Forms.TabPage tabPage1;

        private System.Windows.Forms.Button abortBtn;

        private System.Windows.Forms.Label label19;

        private System.Windows.Forms.Label wheatLabel;

        private System.Windows.Forms.Label maltLabel;

        private System.Windows.Forms.Label hopsLabel;

        private System.Windows.Forms.Label BarleyLabel;

        private System.Windows.Forms.Label setSpeed;

        private System.Windows.Forms.Label setSize;

        private System.Windows.Forms.Label setType;

        private System.Windows.Forms.Label maintenanceLabel;

        private System.Windows.Forms.Label defectLabel;

        private System.Windows.Forms.Label acceptableLabel;

        private System.Windows.Forms.Label producedLabel;

        private System.Windows.Forms.Label productsPerMinuteLabel;

        private System.Windows.Forms.Label batchSizeLabel;

        private System.Windows.Forms.Label batchIDLabel;

        private System.Windows.Forms.Label vibrationLabel;

        private System.Windows.Forms.Label humidityLabel;

        private System.Windows.Forms.Label temperatureLabel;

        private System.Windows.Forms.PictureBox pictureBoxHumidity;

        private System.Windows.Forms.PictureBox pictureBoxVibration;

        private System.Windows.Forms.PictureBox pictureBoxBatchID;

        private System.Windows.Forms.PictureBox pictureBoxAmountToProduce;

        private System.Windows.Forms.PictureBox pictureBoxProductsPerMiunte;

        private System.Windows.Forms.PictureBox pictureBoxDefectProducts;

        private System.Windows.Forms.PictureBox pictureBoxAcceptableProducts;

        private System.Windows.Forms.PictureBox pictureBoxProduced;

        private System.Windows.Forms.PictureBox pictureBoxTemperature;

        private System.Windows.Forms.Button clearBtn;

        private System.Windows.Forms.Button resetBtn;

        private System.Windows.Forms.Button stopBtn;

        private System.Windows.Forms.Button startBrn;

        private System.Windows.Forms.TabPage tabPage2;

        private System.Windows.Forms.Label YeastLabel;

        private System.Windows.Forms.NumericUpDown batchSizeNumericUpDownSize;

        private System.Windows.Forms.ComboBox productTypeComboBox;

        private System.Windows.Forms.Label currentStateLabel;

        private System.Windows.Forms.Label label1;

        private System.Windows.Forms.Timer updateData;

        private System.Windows.Forms.TrackBar productionSpeedTrackBar;

        private System.Windows.Forms.Label productionSpeedLabel;

        private System.Windows.Forms.Label maxProductionSpeedLabel;

        private System.Windows.Forms.Label label2;

        private VerticalProgressBar verticalProgressBarYeast;

        private VerticalProgressBar verticalProgressBarWheat;

        private VerticalProgressBar verticalProgressBarMalt;

        private VerticalProgressBar verticalProgressBarHops;

        private VerticalProgressBar verticalProgressBarBarley;

        private VerticalProgressBar verticalProgressBarMaintenance;
        private System.Windows.Forms.ProgressBar BatchProgressBar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox listBoxBatches;
        private System.Windows.Forms.TextBox searchTextBox;
        private System.Windows.Forms.Button getBatches;
        private System.Windows.Forms.RichTextBox chosenReport;
        private System.Windows.Forms.DataVisualization.Charting.Chart humidityChart;
        private System.Windows.Forms.DataVisualization.Charting.Chart tempChart;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartStates;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label eefLabel;
        private System.Windows.Forms.Button setOptimalSpeedBtn;
    }
}