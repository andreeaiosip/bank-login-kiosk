namespace Cyanair_Booking_App
{
    partial class frmConfirmation
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
            this.lblPassengerFName = new System.Windows.Forms.Label();
            this.lblPassengerLName = new System.Windows.Forms.Label();
            this.lblDepartConf1 = new System.Windows.Forms.Label();
            this.lblArrivalConf1 = new System.Windows.Forms.Label();
            this.lblDateFlight1 = new System.Windows.Forms.Label();
            this.lblDateFlight2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblArrivalConf2 = new System.Windows.Forms.Label();
            this.lblDepartConf2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnConfOK = new System.Windows.Forms.Button();
            this.lblRefNo = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblPassengerFName
            // 
            this.lblPassengerFName.AutoSize = true;
            this.lblPassengerFName.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPassengerFName.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblPassengerFName.Location = new System.Drawing.Point(26, 48);
            this.lblPassengerFName.Name = "lblPassengerFName";
            this.lblPassengerFName.Size = new System.Drawing.Size(94, 19);
            this.lblPassengerFName.TabIndex = 5;
            this.lblPassengerFName.Text = "First Name";
            // 
            // lblPassengerLName
            // 
            this.lblPassengerLName.AutoSize = true;
            this.lblPassengerLName.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPassengerLName.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblPassengerLName.Location = new System.Drawing.Point(26, 98);
            this.lblPassengerLName.Name = "lblPassengerLName";
            this.lblPassengerLName.Size = new System.Drawing.Size(92, 19);
            this.lblPassengerLName.TabIndex = 6;
            this.lblPassengerLName.Text = "Last Name";
            // 
            // lblDepartConf1
            // 
            this.lblDepartConf1.AutoSize = true;
            this.lblDepartConf1.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDepartConf1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblDepartConf1.Location = new System.Drawing.Point(32, 63);
            this.lblDepartConf1.Name = "lblDepartConf1";
            this.lblDepartConf1.Size = new System.Drawing.Size(88, 19);
            this.lblDepartConf1.TabIndex = 7;
            this.lblDepartConf1.Text = "Departure";
            // 
            // lblArrivalConf1
            // 
            this.lblArrivalConf1.AutoSize = true;
            this.lblArrivalConf1.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblArrivalConf1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblArrivalConf1.Location = new System.Drawing.Point(244, 63);
            this.lblArrivalConf1.Name = "lblArrivalConf1";
            this.lblArrivalConf1.Size = new System.Drawing.Size(60, 19);
            this.lblArrivalConf1.TabIndex = 8;
            this.lblArrivalConf1.Text = "Arrival";
            // 
            // lblDateFlight1
            // 
            this.lblDateFlight1.AutoSize = true;
            this.lblDateFlight1.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDateFlight1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblDateFlight1.Location = new System.Drawing.Point(445, 63);
            this.lblDateFlight1.Name = "lblDateFlight1";
            this.lblDateFlight1.Size = new System.Drawing.Size(45, 19);
            this.lblDateFlight1.TabIndex = 9;
            this.lblDateFlight1.Text = "Date";
            // 
            // lblDateFlight2
            // 
            this.lblDateFlight2.AutoSize = true;
            this.lblDateFlight2.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDateFlight2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblDateFlight2.Location = new System.Drawing.Point(445, 121);
            this.lblDateFlight2.Name = "lblDateFlight2";
            this.lblDateFlight2.Size = new System.Drawing.Size(45, 19);
            this.lblDateFlight2.TabIndex = 10;
            this.lblDateFlight2.Text = "Date";
            this.lblDateFlight2.Visible = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblRefNo);
            this.groupBox1.Controls.Add(this.lblDepartConf1);
            this.groupBox1.Controls.Add(this.lblArrivalConf2);
            this.groupBox1.Controls.Add(this.lblDepartConf2);
            this.groupBox1.Controls.Add(this.lblArrivalConf1);
            this.groupBox1.Controls.Add(this.lblDateFlight2);
            this.groupBox1.Controls.Add(this.lblDateFlight1);
            this.groupBox1.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.groupBox1.Location = new System.Drawing.Point(12, 16);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(595, 176);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "BOOKING  CONFIRMATION  NO                                ";
            // 
            // lblArrivalConf2
            // 
            this.lblArrivalConf2.AutoSize = true;
            this.lblArrivalConf2.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblArrivalConf2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblArrivalConf2.Location = new System.Drawing.Point(244, 121);
            this.lblArrivalConf2.Name = "lblArrivalConf2";
            this.lblArrivalConf2.Size = new System.Drawing.Size(60, 19);
            this.lblArrivalConf2.TabIndex = 12;
            this.lblArrivalConf2.Text = "Arrival";
            // 
            // lblDepartConf2
            // 
            this.lblDepartConf2.AutoSize = true;
            this.lblDepartConf2.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDepartConf2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblDepartConf2.Location = new System.Drawing.Point(29, 121);
            this.lblDepartConf2.Name = "lblDepartConf2";
            this.lblDepartConf2.Size = new System.Drawing.Size(88, 19);
            this.lblDepartConf2.TabIndex = 11;
            this.lblDepartConf2.Text = "Departure";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lblPassengerLName);
            this.groupBox2.Controls.Add(this.lblPassengerFName);
            this.groupBox2.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.groupBox2.Location = new System.Drawing.Point(12, 211);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(595, 136);
            this.groupBox2.TabIndex = 12;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "PASSENGER DETAILS";
            // 
            // btnConfOK
            // 
            this.btnConfOK.BackColor = System.Drawing.Color.White;
            this.btnConfOK.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnConfOK.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfOK.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.btnConfOK.Location = new System.Drawing.Point(281, 353);
            this.btnConfOK.Name = "btnConfOK";
            this.btnConfOK.Size = new System.Drawing.Size(71, 29);
            this.btnConfOK.TabIndex = 16;
            this.btnConfOK.Text = "OK";
            this.btnConfOK.UseVisualStyleBackColor = false;
            this.btnConfOK.Click += new System.EventHandler(this.btnConfOK_Click);
            // 
            // lblRefNo
            // 
            this.lblRefNo.AutoSize = true;
            this.lblRefNo.Location = new System.Drawing.Point(298, 0);
            this.lblRefNo.Name = "lblRefNo";
            this.lblRefNo.Size = new System.Drawing.Size(52, 19);
            this.lblRefNo.TabIndex = 13;
            this.lblRefNo.Text = "refNo";
            // 
            // frmConfirmation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkViolet;
            this.ClientSize = new System.Drawing.Size(631, 394);
            this.Controls.Add(this.btnConfOK);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Name = "frmConfirmation";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Confirmation of Booking";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label lblPassengerFName;
        private System.Windows.Forms.Label lblPassengerLName;
        private System.Windows.Forms.Label lblDepartConf1;
        private System.Windows.Forms.Label lblArrivalConf1;
        private System.Windows.Forms.Label lblDateFlight1;
        private System.Windows.Forms.Label lblDateFlight2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblArrivalConf2;
        private System.Windows.Forms.Label lblDepartConf2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnConfOK;
        private System.Windows.Forms.Label lblRefNo;
    }
}