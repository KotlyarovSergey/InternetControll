namespace InternetControll
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblInterface = new System.Windows.Forms.Label();
            this.lblIP = new System.Windows.Forms.Label();
            this.lblMask = new System.Windows.Forms.Label();
            this.lblGatWay = new System.Windows.Forms.Label();
            this.lblDNS = new System.Windows.Forms.Label();
            this.btnGetStatus = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txbPingSite = new System.Windows.Forms.TextBox();
            this.txbFrequence = new System.Windows.Forms.TextBox();
            this.btnStart = new System.Windows.Forms.Button();
            this.checkBoxPingGateWay = new System.Windows.Forms.CheckBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.lblPingLabel = new System.Windows.Forms.Label();
            this.lblPing = new System.Windows.Forms.Label();
            this.timerOfPing = new System.Windows.Forms.Timer(this.components);
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblDNS);
            this.groupBox1.Controls.Add(this.lblGatWay);
            this.groupBox1.Controls.Add(this.lblMask);
            this.groupBox1.Controls.Add(this.lblIP);
            this.groupBox1.Controls.Add(this.lblInterface);
            this.groupBox1.Location = new System.Drawing.Point(28, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(270, 159);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Status";
            // 
            // lblInterface
            // 
            this.lblInterface.AutoSize = true;
            this.lblInterface.Location = new System.Drawing.Point(23, 35);
            this.lblInterface.Name = "lblInterface";
            this.lblInterface.Size = new System.Drawing.Size(52, 13);
            this.lblInterface.TabIndex = 0;
            this.lblInterface.Text = "Interface:";
            // 
            // lblIP
            // 
            this.lblIP.AutoSize = true;
            this.lblIP.Location = new System.Drawing.Point(23, 69);
            this.lblIP.Name = "lblIP";
            this.lblIP.Size = new System.Drawing.Size(20, 13);
            this.lblIP.TabIndex = 1;
            this.lblIP.Text = "IP:";
            // 
            // lblMask
            // 
            this.lblMask.AutoSize = true;
            this.lblMask.Location = new System.Drawing.Point(23, 91);
            this.lblMask.Name = "lblMask";
            this.lblMask.Size = new System.Drawing.Size(36, 13);
            this.lblMask.TabIndex = 2;
            this.lblMask.Text = "Mask:";
            // 
            // lblGatWay
            // 
            this.lblGatWay.AutoSize = true;
            this.lblGatWay.Location = new System.Drawing.Point(23, 114);
            this.lblGatWay.Name = "lblGatWay";
            this.lblGatWay.Size = new System.Drawing.Size(55, 13);
            this.lblGatWay.TabIndex = 3;
            this.lblGatWay.Text = "GeteWay:";
            // 
            // lblDNS
            // 
            this.lblDNS.AutoSize = true;
            this.lblDNS.Location = new System.Drawing.Point(23, 137);
            this.lblDNS.Name = "lblDNS";
            this.lblDNS.Size = new System.Drawing.Size(33, 13);
            this.lblDNS.TabIndex = 4;
            this.lblDNS.Text = "DNS:";
            // 
            // btnGetStatus
            // 
            this.btnGetStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnGetStatus.Location = new System.Drawing.Point(321, 36);
            this.btnGetStatus.Name = "btnGetStatus";
            this.btnGetStatus.Size = new System.Drawing.Size(128, 42);
            this.btnGetStatus.TabIndex = 1;
            this.btnGetStatus.Text = "<---  Get status";
            this.btnGetStatus.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.checkBoxPingGateWay);
            this.groupBox2.Controls.Add(this.txbFrequence);
            this.groupBox2.Controls.Add(this.txbPingSite);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(28, 179);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(270, 121);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Setting";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ping to:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Freq., sec:";
            // 
            // txbPingSite
            // 
            this.txbPingSite.Location = new System.Drawing.Point(87, 25);
            this.txbPingSite.Name = "txbPingSite";
            this.txbPingSite.Size = new System.Drawing.Size(120, 20);
            this.txbPingSite.TabIndex = 2;
            this.txbPingSite.Text = "ya.ru";
            // 
            // txbFrequence
            // 
            this.txbFrequence.Location = new System.Drawing.Point(87, 54);
            this.txbFrequence.Name = "txbFrequence";
            this.txbFrequence.Size = new System.Drawing.Size(36, 20);
            this.txbFrequence.TabIndex = 3;
            this.txbFrequence.Text = "1";
            // 
            // btnStart
            // 
            this.btnStart.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnStart.Location = new System.Drawing.Point(321, 186);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(128, 67);
            this.btnStart.TabIndex = 0;
            this.btnStart.Text = "START";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // checkBoxPingGateWay
            // 
            this.checkBoxPingGateWay.AutoSize = true;
            this.checkBoxPingGateWay.Checked = true;
            this.checkBoxPingGateWay.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxPingGateWay.Location = new System.Drawing.Point(23, 87);
            this.checkBoxPingGateWay.Name = "checkBoxPingGateWay";
            this.checkBoxPingGateWay.Size = new System.Drawing.Size(94, 17);
            this.checkBoxPingGateWay.TabIndex = 4;
            this.checkBoxPingGateWay.Text = "ping GateWay";
            this.toolTip1.SetToolTip(this.checkBoxPingGateWay, "Check Ping to GateWay wen lost ping to site");
            this.checkBoxPingGateWay.UseVisualStyleBackColor = true;
            // 
            // toolTip1
            // 
            this.toolTip1.AutoPopDelay = 7000;
            this.toolTip1.InitialDelay = 500;
            this.toolTip1.ReshowDelay = 100;
            // 
            // lblPingLabel
            // 
            this.lblPingLabel.AutoSize = true;
            this.lblPingLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblPingLabel.Location = new System.Drawing.Point(328, 268);
            this.lblPingLabel.Name = "lblPingLabel";
            this.lblPingLabel.Size = new System.Drawing.Size(76, 16);
            this.lblPingLabel.TabIndex = 4;
            this.lblPingLabel.Text = "Ping status:";
            this.lblPingLabel.Visible = false;
            // 
            // lblPing
            // 
            this.lblPing.AutoSize = true;
            this.lblPing.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblPing.Location = new System.Drawing.Point(399, 266);
            this.lblPing.Name = "lblPing";
            this.lblPing.Size = new System.Drawing.Size(33, 20);
            this.lblPing.TabIndex = 5;
            this.lblPing.Text = "OK";
            this.lblPing.Visible = false;
            // 
            // timerOfPing
            // 
            this.timerOfPing.Interval = 1000;
            this.timerOfPing.Tick += new System.EventHandler(this.timerOfPing_Tick);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 317);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(481, 22);
            this.statusStrip1.TabIndex = 6;
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(39, 17);
            this.toolStripStatusLabel1.Text = "Status";
            // 
            // Form1
            // 
            this.AcceptButton = this.btnStart;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnStart;
            this.ClientSize = new System.Drawing.Size(481, 339);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.lblPing);
            this.Controls.Add(this.lblPingLabel);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btnGetStatus);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblDNS;
        private System.Windows.Forms.Label lblGatWay;
        private System.Windows.Forms.Label lblMask;
        private System.Windows.Forms.Label lblIP;
        private System.Windows.Forms.Label lblInterface;
        private System.Windows.Forms.Button btnGetStatus;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txbPingSite;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox checkBoxPingGateWay;
        private System.Windows.Forms.TextBox txbFrequence;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Label lblPingLabel;
        private System.Windows.Forms.Label lblPing;
        private System.Windows.Forms.Timer timerOfPing;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
    }
}

