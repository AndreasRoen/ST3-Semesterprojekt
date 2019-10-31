using BeerProductionSystem.Aquaintence;
using System.Diagnostics;

namespace BeerProductionSystem.PresentationLayer
{
    partial class UI
    {
        private ILogicFacade logicFacade;

        public UI(ILogicFacade logicFacade)
        {
            this.logicFacade = logicFacade;
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
            this.tab1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.numericUpDownSize = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownSpeed = new System.Windows.Forms.NumericUpDown();
            this.comboBoxType = new System.Windows.Forms.ComboBox();
            this.YeastLabel = new System.Windows.Forms.Label();
            this.progressBarWheat = new System.Windows.Forms.ProgressBar();
            this.progressBarMalt = new System.Windows.Forms.ProgressBar();
            this.progressBarHops = new System.Windows.Forms.ProgressBar();
            this.progressBarBarley = new System.Windows.Forms.ProgressBar();
            this.progressBarYeast = new System.Windows.Forms.ProgressBar();
            this.progressBarMaintenance = new System.Windows.Forms.ProgressBar();
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
            this.ProductsPerMinuteLabel = new System.Windows.Forms.Label();
            this.AmountToProduceLabel = new System.Windows.Forms.Label();
            this.bacthIDLabel = new System.Windows.Forms.Label();
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
            this.tab1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSpeed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxHumidity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxVibration)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBatchID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAmountToProduce)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxProductsPerMiunte)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDefectProducts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAcceptableProducts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxProduced)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxTemperature)).BeginInit();
            this.SuspendLayout();
            // 
            // tab1
            // 
            this.tab1.Controls.Add(this.tabPage1);
            this.tab1.Controls.Add(this.tabPage2);
            this.tab1.Location = new System.Drawing.Point(-1, -3);
            this.tab1.Name = "tab1";
            this.tab1.SelectedIndex = 0;
            this.tab1.Size = new System.Drawing.Size(947, 598);
            this.tab1.TabIndex = 33;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.numericUpDownSize);
            this.tabPage1.Controls.Add(this.numericUpDownSpeed);
            this.tabPage1.Controls.Add(this.comboBoxType);
            this.tabPage1.Controls.Add(this.YeastLabel);
            this.tabPage1.Controls.Add(this.progressBarWheat);
            this.tabPage1.Controls.Add(this.progressBarMalt);
            this.tabPage1.Controls.Add(this.progressBarHops);
            this.tabPage1.Controls.Add(this.progressBarBarley);
            this.tabPage1.Controls.Add(this.progressBarYeast);
            this.tabPage1.Controls.Add(this.progressBarMaintenance);
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
            this.tabPage1.Controls.Add(this.ProductsPerMinuteLabel);
            this.tabPage1.Controls.Add(this.AmountToProduceLabel);
            this.tabPage1.Controls.Add(this.bacthIDLabel);
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
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(939, 569);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Visualization";
            this.tabPage1.UseVisualStyleBackColor = true;
            this.tabPage1.Click += new System.EventHandler(this.tabPage1_load);
            // 
            // numericUpDownSize
            // 
            this.numericUpDownSize.Location = new System.Drawing.Point(447, 36);
            this.numericUpDownSize.Name = "numericUpDownSize";
            this.numericUpDownSize.Size = new System.Drawing.Size(120, 22);
            this.numericUpDownSize.Minimum = 1;
            this.numericUpDownSize.Maximum = 65535;
            this.numericUpDownSize.TabIndex = 74;
            // 
            // numericUpDownSpeed
            // 
            this.numericUpDownSpeed.Location = new System.Drawing.Point(176, 171);
            this.numericUpDownSpeed.Name = "numericUpDownSpeed";
            this.numericUpDownSpeed.Size = new System.Drawing.Size(118, 22);
            this.numericUpDownSpeed.TabIndex = 73;
            // 
            // comboBoxType
            // 
            this.comboBoxType.FormattingEnabled = true;
            this.comboBoxType.Location = new System.Drawing.Point(176, 34);
            this.comboBoxType.Name = "comboBoxType";
            this.comboBoxType.Size = new System.Drawing.Size(118, 24);
            this.comboBoxType.TabIndex = 72;
            this.comboBoxType.Items.Add("Pilsner");
            this.comboBoxType.Items.Add("Wheat");
            this.comboBoxType.Items.Add("IPA");
            this.comboBoxType.Items.Add("Stout");
            this.comboBoxType.Items.Add("Ale");
            this.comboBoxType.Items.Add("Alcohol Free");
            this.comboBoxType.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // YeastLabel
            // 
            this.YeastLabel.AutoSize = true;
            this.YeastLabel.Location = new System.Drawing.Point(683, 233);
            this.YeastLabel.Name = "YeastLabel";
            this.YeastLabel.Size = new System.Drawing.Size(44, 17);
            this.YeastLabel.TabIndex = 71;
            this.YeastLabel.Text = "Yeast";
            // 
            // progressBarWheat
            // 
            this.progressBarWheat.Location = new System.Drawing.Point(553, 253);
            this.progressBarWheat.Name = "progressBarWheat";
            this.progressBarWheat.Size = new System.Drawing.Size(100, 82);
            this.progressBarWheat.TabIndex = 70;
            // 
            // progressBarMalt
            // 
            this.progressBarMalt.Location = new System.Drawing.Point(447, 253);
            this.progressBarMalt.Name = "progressBarMalt";
            this.progressBarMalt.Size = new System.Drawing.Size(100, 82);
            this.progressBarMalt.TabIndex = 69;
            // 
            // progressBarHops
            // 
            this.progressBarHops.Location = new System.Drawing.Point(339, 253);
            this.progressBarHops.Name = "progressBarHops";
            this.progressBarHops.Size = new System.Drawing.Size(100, 82);
            this.progressBarHops.TabIndex = 68;
            // 
            // progressBarBarley
            // 
            this.progressBarBarley.Location = new System.Drawing.Point(224, 253);
            this.progressBarBarley.Name = "progressBarBarley";
            this.progressBarBarley.Size = new System.Drawing.Size(100, 82);
            this.progressBarBarley.TabIndex = 67;
            // 
            // progressBarYeast
            // 
            this.progressBarYeast.Location = new System.Drawing.Point(659, 253);
            this.progressBarYeast.Name = "progressBarYeast";
            this.progressBarYeast.Size = new System.Drawing.Size(100, 82);
            this.progressBarYeast.TabIndex = 66;
            // 
            // progressBarMaintenance
            // 
            this.progressBarMaintenance.Location = new System.Drawing.Point(798, 171);
            this.progressBarMaintenance.Name = "progressBarMaintenance";
            this.progressBarMaintenance.Size = new System.Drawing.Size(100, 324);
            this.progressBarMaintenance.TabIndex = 65;
            // 
            // abortBtn
            // 
            this.abortBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.abortBtn.Location = new System.Drawing.Point(12, 188);
            this.abortBtn.Name = "abortBtn";
            this.abortBtn.Size = new System.Drawing.Size(98, 39);
            this.abortBtn.TabIndex = 64;
            this.abortBtn.Text = "Abort";
            this.abortBtn.UseVisualStyleBackColor = false;
            this.abortBtn.Click += new System.EventHandler(this.abortBtn_Click);
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(677, 30);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(0, 17);
            this.label19.TabIndex = 63;
            // 
            // wheatLabel
            // 
            this.wheatLabel.AutoSize = true;
            this.wheatLabel.Location = new System.Drawing.Point(573, 233);
            this.wheatLabel.Name = "wheatLabel";
            this.wheatLabel.Size = new System.Drawing.Size(49, 17);
            this.wheatLabel.TabIndex = 62;
            this.wheatLabel.Text = "Wheat";
            // 
            // maltLabel
            // 
            this.maltLabel.AutoSize = true;
            this.maltLabel.Location = new System.Drawing.Point(480, 233);
            this.maltLabel.Name = "maltLabel";
            this.maltLabel.Size = new System.Drawing.Size(34, 17);
            this.maltLabel.TabIndex = 61;
            this.maltLabel.Text = "Malt";
            // 
            // hopsLabel
            // 
            this.hopsLabel.AutoSize = true;
            this.hopsLabel.Location = new System.Drawing.Point(370, 233);
            this.hopsLabel.Name = "hopsLabel";
            this.hopsLabel.Size = new System.Drawing.Size(41, 17);
            this.hopsLabel.TabIndex = 60;
            this.hopsLabel.Text = "Hops";
            // 
            // BarleyLabel
            // 
            this.BarleyLabel.AutoSize = true;
            this.BarleyLabel.Location = new System.Drawing.Point(246, 233);
            this.BarleyLabel.Name = "BarleyLabel";
            this.BarleyLabel.Size = new System.Drawing.Size(48, 17);
            this.BarleyLabel.TabIndex = 59;
            this.BarleyLabel.Text = "Barley";
            // 
            // setSpeed
            // 
            this.setSpeed.AutoSize = true;
            this.setSpeed.Location = new System.Drawing.Point(173, 143);
            this.setSpeed.Name = "setSpeed";
            this.setSpeed.Size = new System.Drawing.Size(147, 17);
            this.setSpeed.TabIndex = 58;
            this.setSpeed.Text = "Set production speed:";
            // 
            // setSize
            // 
            this.setSize.AutoSize = true;
            this.setSize.Location = new System.Drawing.Point(444, 14);
            this.setSize.Name = "setSize";
            this.setSize.Size = new System.Drawing.Size(133, 17);
            this.setSize.TabIndex = 57;
            this.setSize.Text = "Set production size:";
            // 
            // setType
            // 
            this.setType.AutoSize = true;
            this.setType.Location = new System.Drawing.Point(173, 14);
            this.setType.Name = "setType";
            this.setType.Size = new System.Drawing.Size(135, 17);
            this.setType.TabIndex = 56;
            this.setType.Text = "Set production type:";
            // 
            // maintenanceLabel
            // 
            this.maintenanceLabel.AutoSize = true;
            this.maintenanceLabel.Location = new System.Drawing.Point(809, 515);
            this.maintenanceLabel.Name = "maintenanceLabel";
            this.maintenanceLabel.Size = new System.Drawing.Size(89, 17);
            this.maintenanceLabel.TabIndex = 55;
            this.maintenanceLabel.Text = "Maintenance";
            // 
            // defectLabel
            // 
            this.defectLabel.AutoSize = true;
            this.defectLabel.Location = new System.Drawing.Point(493, 515);
            this.defectLabel.Name = "defectLabel";
            this.defectLabel.Size = new System.Drawing.Size(54, 17);
            this.defectLabel.TabIndex = 54;
            this.defectLabel.Text = "label28";
            // 
            // acceptableLabel
            // 
            this.acceptableLabel.AutoSize = true;
            this.acceptableLabel.Location = new System.Drawing.Point(683, 515);
            this.acceptableLabel.Name = "acceptableLabel";
            this.acceptableLabel.Size = new System.Drawing.Size(54, 17);
            this.acceptableLabel.TabIndex = 53;
            this.acceptableLabel.Text = "label29";
            // 
            // producedLabel
            // 
            this.producedLabel.AutoSize = true;
            this.producedLabel.Location = new System.Drawing.Point(683, 441);
            this.producedLabel.Name = "producedLabel";
            this.producedLabel.Size = new System.Drawing.Size(54, 17);
            this.producedLabel.TabIndex = 52;
            this.producedLabel.Text = "label30";
            // 
            // ProductsPerMinuteLabel
            // 
            this.ProductsPerMinuteLabel.AutoSize = true;
            this.ProductsPerMinuteLabel.Location = new System.Drawing.Point(300, 525);
            this.ProductsPerMinuteLabel.Name = "ProductsPerMinuteLabel";
            this.ProductsPerMinuteLabel.Size = new System.Drawing.Size(54, 17);
            this.ProductsPerMinuteLabel.TabIndex = 51;
            this.ProductsPerMinuteLabel.Text = "label31";
            // 
            // AmountToProduceLabel
            // 
            this.AmountToProduceLabel.AutoSize = true;
            this.AmountToProduceLabel.Location = new System.Drawing.Point(493, 441);
            this.AmountToProduceLabel.Name = "AmountToProduceLabel";
            this.AmountToProduceLabel.Size = new System.Drawing.Size(54, 17);
            this.AmountToProduceLabel.TabIndex = 50;
            this.AmountToProduceLabel.Text = "label32";
            this.AmountToProduceLabel.Click += new System.EventHandler(this.label32_Click);
            // 
            // bacthIDLabel
            // 
            this.bacthIDLabel.AutoSize = true;
            this.bacthIDLabel.Location = new System.Drawing.Point(300, 441);
            this.bacthIDLabel.Name = "bacthIDLabel";
            this.bacthIDLabel.Size = new System.Drawing.Size(54, 17);
            this.bacthIDLabel.TabIndex = 49;
            this.bacthIDLabel.Text = "label33";
            // 
            // vibrationLabel
            // 
            this.vibrationLabel.AutoSize = true;
            this.vibrationLabel.Location = new System.Drawing.Point(116, 525);
            this.vibrationLabel.Name = "vibrationLabel";
            this.vibrationLabel.Size = new System.Drawing.Size(54, 17);
            this.vibrationLabel.TabIndex = 48;
            this.vibrationLabel.Text = "label34";
            // 
            // humidityLabel
            // 
            this.humidityLabel.AutoSize = true;
            this.humidityLabel.Location = new System.Drawing.Point(116, 441);
            this.humidityLabel.Name = "humidityLabel";
            this.humidityLabel.Size = new System.Drawing.Size(54, 17);
            this.humidityLabel.TabIndex = 47;
            this.humidityLabel.Text = "label35";
            // 
            // temperatureLabel
            // 
            this.temperatureLabel.AutoSize = true;
            this.temperatureLabel.Location = new System.Drawing.Point(116, 332);
            this.temperatureLabel.Name = "temperatureLabel";
            this.temperatureLabel.Size = new System.Drawing.Size(54, 17);
            this.temperatureLabel.TabIndex = 46;
            this.temperatureLabel.Text = "label36";
            this.temperatureLabel.Click += new System.EventHandler(this.temperatureLabel_Click);
            // 
            // pictureBoxHumidity
            // 
            this.pictureBoxHumidity.Image = global::BeerProductionSystem.Properties.Resources.Humidity;
            this.pictureBoxHumidity.Location = new System.Drawing.Point(24, 395);
            this.pictureBoxHumidity.Name = "pictureBoxHumidity";
            this.pictureBoxHumidity.Size = new System.Drawing.Size(86, 76);
            this.pictureBoxHumidity.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxHumidity.TabIndex = 45;
            this.pictureBoxHumidity.TabStop = false;
            // 
            // pictureBoxVibration
            // 
            this.pictureBoxVibration.Image = global::BeerProductionSystem.Properties.Resources.Vibration;
            this.pictureBoxVibration.Location = new System.Drawing.Point(24, 488);
            this.pictureBoxVibration.Name = "pictureBoxVibration";
            this.pictureBoxVibration.Size = new System.Drawing.Size(86, 72);
            this.pictureBoxVibration.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxVibration.TabIndex = 44;
            this.pictureBoxVibration.TabStop = false;
            // 
            // pictureBoxBatchID
            // 
            this.pictureBoxBatchID.Image = global::BeerProductionSystem.Properties.Resources.BatchID;
            this.pictureBoxBatchID.Location = new System.Drawing.Point(211, 395);
            this.pictureBoxBatchID.Name = "pictureBoxBatchID";
            this.pictureBoxBatchID.Size = new System.Drawing.Size(83, 80);
            this.pictureBoxBatchID.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxBatchID.TabIndex = 43;
            this.pictureBoxBatchID.TabStop = false;
            // 
            // pictureBoxAmountToProduce
            // 
            this.pictureBoxAmountToProduce.Image = global::BeerProductionSystem.Properties.Resources.AmountToProduce;
            this.pictureBoxAmountToProduce.Location = new System.Drawing.Point(388, 395);
            this.pictureBoxAmountToProduce.Name = "pictureBoxAmountToProduce";
            this.pictureBoxAmountToProduce.Size = new System.Drawing.Size(99, 76);
            this.pictureBoxAmountToProduce.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxAmountToProduce.TabIndex = 42;
            this.pictureBoxAmountToProduce.TabStop = false;
            // 
            // pictureBoxProductsPerMiunte
            // 
            this.pictureBoxProductsPerMiunte.Image = global::BeerProductionSystem.Properties.Resources.ProductsPerMinute;
            this.pictureBoxProductsPerMiunte.Location = new System.Drawing.Point(207, 488);
            this.pictureBoxProductsPerMiunte.Name = "pictureBoxProductsPerMiunte";
            this.pictureBoxProductsPerMiunte.Size = new System.Drawing.Size(87, 72);
            this.pictureBoxProductsPerMiunte.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxProductsPerMiunte.TabIndex = 41;
            this.pictureBoxProductsPerMiunte.TabStop = false;
            this.pictureBoxProductsPerMiunte.Click += new System.EventHandler(this.pictureBox14_Click);
            // 
            // pictureBoxDefectProducts
            // 
            this.pictureBoxDefectProducts.Image = global::BeerProductionSystem.Properties.Resources.DefectProducts;
            this.pictureBoxDefectProducts.Location = new System.Drawing.Point(388, 488);
            this.pictureBoxDefectProducts.Name = "pictureBoxDefectProducts";
            this.pictureBoxDefectProducts.Size = new System.Drawing.Size(99, 72);
            this.pictureBoxDefectProducts.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxDefectProducts.TabIndex = 40;
            this.pictureBoxDefectProducts.TabStop = false;
            // 
            // pictureBoxAcceptableProducts
            // 
            this.pictureBoxAcceptableProducts.Image = global::BeerProductionSystem.Properties.Resources.AcceptableProducts;
            this.pictureBoxAcceptableProducts.Location = new System.Drawing.Point(576, 488);
            this.pictureBoxAcceptableProducts.Name = "pictureBoxAcceptableProducts";
            this.pictureBoxAcceptableProducts.Size = new System.Drawing.Size(101, 72);
            this.pictureBoxAcceptableProducts.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxAcceptableProducts.TabIndex = 39;
            this.pictureBoxAcceptableProducts.TabStop = false;
            // 
            // pictureBoxProduced
            // 
            this.pictureBoxProduced.Image = global::BeerProductionSystem.Properties.Resources.Produced;
            this.pictureBoxProduced.Location = new System.Drawing.Point(602, 395);
            this.pictureBoxProduced.Name = "pictureBoxProduced";
            this.pictureBoxProduced.Size = new System.Drawing.Size(75, 87);
            this.pictureBoxProduced.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxProduced.TabIndex = 38;
            this.pictureBoxProduced.TabStop = false;
            // 
            // pictureBoxTemperature
            // 
            this.pictureBoxTemperature.Image = global::BeerProductionSystem.Properties.Resources.Temperature;
            this.pictureBoxTemperature.Location = new System.Drawing.Point(24, 296);
            this.pictureBoxTemperature.Name = "pictureBoxTemperature";
            this.pictureBoxTemperature.Size = new System.Drawing.Size(86, 77);
            this.pictureBoxTemperature.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxTemperature.TabIndex = 37;
            this.pictureBoxTemperature.TabStop = false;
            // 
            // clearBtn
            // 
            this.clearBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.clearBtn.Location = new System.Drawing.Point(12, 143);
            this.clearBtn.Name = "clearBtn";
            this.clearBtn.Size = new System.Drawing.Size(98, 39);
            this.clearBtn.TabIndex = 36;
            this.clearBtn.Text = "Clear";
            this.clearBtn.UseVisualStyleBackColor = false;
            this.clearBtn.Click += new System.EventHandler(this.clearBtn_Click);
            // 
            // resetBtn
            // 
            this.resetBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.resetBtn.Location = new System.Drawing.Point(12, 98);
            this.resetBtn.Name = "resetBtn";
            this.resetBtn.Size = new System.Drawing.Size(98, 39);
            this.resetBtn.TabIndex = 35;
            this.resetBtn.Text = "Reset";
            this.resetBtn.UseVisualStyleBackColor = false;
            this.resetBtn.Click += new System.EventHandler(this.resetBtn_Click);
            // 
            // stopBtn
            // 
            this.stopBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.stopBtn.Location = new System.Drawing.Point(12, 53);
            this.stopBtn.Name = "stopBtn";
            this.stopBtn.Size = new System.Drawing.Size(98, 39);
            this.stopBtn.TabIndex = 34;
            this.stopBtn.Text = "Stop";
            this.stopBtn.UseVisualStyleBackColor = false;
            this.stopBtn.Click += new System.EventHandler(this.stopBtn_Click);
            // 
            // startBrn
            // 
            this.startBrn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.startBrn.Location = new System.Drawing.Point(12, 8);
            this.startBrn.Name = "startBtn";
            this.startBrn.Size = new System.Drawing.Size(98, 39);
            this.startBrn.TabIndex = 33;
            this.startBrn.Text = "Start";
            this.startBrn.UseVisualStyleBackColor = false;
            this.startBrn.Click += new System.EventHandler(this.startBrn_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(939, 569);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // UI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(949, 594);
            this.Controls.Add(this.tab1);
            this.Name = "UI";
            this.Text = "Beer Production System";
            this.tab1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSpeed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxHumidity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxVibration)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBatchID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAmountToProduce)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxProductsPerMiunte)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDefectProducts)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAcceptableProducts)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxProduced)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxTemperature)).EndInit();
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
        private System.Windows.Forms.Label ProductsPerMinuteLabel;
        private System.Windows.Forms.Label AmountToProduceLabel;
        private System.Windows.Forms.Label bacthIDLabel;
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
        private System.Windows.Forms.ProgressBar progressBarWheat;
        private System.Windows.Forms.ProgressBar progressBarMalt;
        private System.Windows.Forms.ProgressBar progressBarHops;
        private System.Windows.Forms.ProgressBar progressBarBarley;
        private System.Windows.Forms.ProgressBar progressBarYeast;
        private System.Windows.Forms.ProgressBar progressBarMaintenance;
        private System.Windows.Forms.NumericUpDown numericUpDownSize;
        private System.Windows.Forms.NumericUpDown numericUpDownSpeed;
        private System.Windows.Forms.ComboBox comboBoxType;
    }
}