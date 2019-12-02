namespace BeerProductionSystem.PresentationLayer
{
    partial class StartupConnection
    {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StartupConnection));
            this.btnRun = new System.Windows.Forms.Button();
            this.rbSimulation = new System.Windows.Forms.RadioButton();
            this.rbPhysical = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.labelCurrentStatus = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnRun
            // 
            this.btnRun.Location = new System.Drawing.Point(392, 45);
            this.btnRun.Name = "btnRun";
            this.btnRun.Size = new System.Drawing.Size(75, 23);
            this.btnRun.TabIndex = 0;
            this.btnRun.Text = "Run";
            this.btnRun.UseVisualStyleBackColor = true;
            this.btnRun.Click += new System.EventHandler(this.btnRun_Click);
            // 
            // rbSimulation
            // 
            this.rbSimulation.AutoSize = true;
            this.rbSimulation.Checked = true;
            this.rbSimulation.Location = new System.Drawing.Point(15, 25);
            this.rbSimulation.Name = "rbSimulation";
            this.rbSimulation.Size = new System.Drawing.Size(73, 17);
            this.rbSimulation.TabIndex = 2;
            this.rbSimulation.TabStop = true;
            this.rbSimulation.Text = "Simulation";
            this.rbSimulation.UseVisualStyleBackColor = true;
            this.rbSimulation.MouseClick += new System.Windows.Forms.MouseEventHandler(this.RB_Click);
            // 
            // rbPhysical
            // 
            this.rbPhysical.AutoSize = true;
            this.rbPhysical.Location = new System.Drawing.Point(15, 48);
            this.rbPhysical.Name = "rbPhysical";
            this.rbPhysical.Size = new System.Drawing.Size(108, 17);
            this.rbPhysical.TabIndex = 4;
            this.rbPhysical.Text = "Physical Machine";
            this.rbPhysical.UseVisualStyleBackColor = true;
            this.rbPhysical.MouseClick += new System.Windows.Forms.MouseEventHandler(this.RB_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(164, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Choose a machine to connect to:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.25F);
            this.label2.Location = new System.Drawing.Point(189, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(287, 29);
            this.label2.TabIndex = 7;
            this.label2.Text = "Beer Production System";
            // 
            // labelCurrentStatus
            // 
            this.labelCurrentStatus.AutoSize = true;
            this.labelCurrentStatus.ForeColor = System.Drawing.Color.Maroon;
            this.labelCurrentStatus.Location = new System.Drawing.Point(294, 50);
            this.labelCurrentStatus.Name = "labelCurrentStatus";
            this.labelCurrentStatus.Size = new System.Drawing.Size(37, 13);
            this.labelCurrentStatus.TabIndex = 8;
            this.labelCurrentStatus.Text = "          ";
            // 
            // StartupConnection
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(488, 89);
            this.Controls.Add(this.labelCurrentStatus);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.rbPhysical);
            this.Controls.Add(this.rbSimulation);
            this.Controls.Add(this.btnRun);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "StartupConnection";
            this.Text = "StartupConnection";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnRun;
        private System.Windows.Forms.RadioButton rbSimulation;
        private System.Windows.Forms.RadioButton rbPhysical;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelCurrentStatus;
    }
}