namespace Cyanair_Booking_App
{
    partial class frmMakeBooking
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMakeBooking));
            this.pnlFlightType = new System.Windows.Forms.Panel();
            this.btnLogin = new System.Windows.Forms.Button();
            this.logo = new System.Windows.Forms.Label();
            this.checkboxLeg2 = new System.Windows.Forms.CheckBox();
            this.checkboxLeg1 = new System.Windows.Forms.CheckBox();
            this.pnlFirstFlight = new System.Windows.Forms.Panel();
            this.dateLeg1 = new System.Windows.Forms.DateTimePicker();
            this.lblDestFirstFlight = new System.Windows.Forms.Label();
            this.cboDepartureLeg1 = new System.Windows.Forms.ComboBox();
            this.lblDepartFirstFlight = new System.Windows.Forms.Label();
            this.cboDestinationLeg1 = new System.Windows.Forms.ComboBox();
            this.btnBook = new System.Windows.Forms.Button();
            this.pnlFlightClass = new System.Windows.Forms.Panel();
            this.radioFirstClass = new System.Windows.Forms.RadioButton();
            this.radioEconomy = new System.Windows.Forms.RadioButton();
            this.radioBusiness = new System.Windows.Forms.RadioButton();
            this.txtBoxFName = new System.Windows.Forms.TextBox();
            this.lblPassenger = new System.Windows.Forms.Label();
            this.cboDestinationLeg2 = new System.Windows.Forms.ComboBox();
            this.cboDepartureLeg2 = new System.Windows.Forms.ComboBox();
            this.lblDepartReturn = new System.Windows.Forms.Label();
            this.lblDestReturn = new System.Windows.Forms.Label();
            this.pnlReturnFlight = new System.Windows.Forms.Panel();
            this.lblReturn = new System.Windows.Forms.Label();
            this.dateLeg2 = new System.Windows.Forms.DateTimePicker();
            this.pnlSecondFlight = new System.Windows.Forms.Panel();
            this.txtBoxLName = new System.Windows.Forms.TextBox();
            this.lblFName = new System.Windows.Forms.Label();
            this.lblLName = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.pnlFlightType.SuspendLayout();
            this.pnlFirstFlight.SuspendLayout();
            this.pnlFlightClass.SuspendLayout();
            this.pnlReturnFlight.SuspendLayout();
            this.pnlSecondFlight.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlFlightType
            // 
            this.pnlFlightType.BackColor = System.Drawing.Color.DarkViolet;
            this.pnlFlightType.Controls.Add(this.btnLogin);
            this.pnlFlightType.Controls.Add(this.logo);
            this.pnlFlightType.Controls.Add(this.checkboxLeg2);
            this.pnlFlightType.Controls.Add(this.checkboxLeg1);
            this.pnlFlightType.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnlFlightType.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.pnlFlightType.Location = new System.Drawing.Point(1, 1);
            this.pnlFlightType.Name = "pnlFlightType";
            this.pnlFlightType.Size = new System.Drawing.Size(803, 66);
            this.pnlFlightType.TabIndex = 0;
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.Color.White;
            this.btnLogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLogin.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogin.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.btnLogin.Location = new System.Drawing.Point(150, 19);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(97, 33);
            this.btnLogin.TabIndex = 16;
            this.btnLogin.Text = "LOGIN";
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // logo
            // 
            this.logo.AutoSize = true;
            this.logo.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logo.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.logo.Location = new System.Drawing.Point(11, 23);
            this.logo.Name = "logo";
            this.logo.Size = new System.Drawing.Size(122, 24);
            this.logo.TabIndex = 2;
            this.logo.Text = "Cyanair Airline";
            // 
            // checkboxLeg2
            // 
            this.checkboxLeg2.AutoSize = true;
            this.checkboxLeg2.Cursor = System.Windows.Forms.Cursors.Default;
            this.checkboxLeg2.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkboxLeg2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.checkboxLeg2.Location = new System.Drawing.Point(553, 23);
            this.checkboxLeg2.Name = "checkboxLeg2";
            this.checkboxLeg2.Size = new System.Drawing.Size(215, 23);
            this.checkboxLeg2.TabIndex = 1;
            this.checkboxLeg2.Text = "ADD ANOTHER FLIGHT";
            this.toolTip1.SetToolTip(this.checkboxLeg2, "Return flight");
            this.checkboxLeg2.UseVisualStyleBackColor = true;
            this.checkboxLeg2.CheckedChanged += new System.EventHandler(this.boxReturn_CheckedChanged);
            // 
            // checkboxLeg1
            // 
            this.checkboxLeg1.AutoSize = true;
            this.checkboxLeg1.Checked = true;
            this.checkboxLeg1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkboxLeg1.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkboxLeg1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.checkboxLeg1.Location = new System.Drawing.Point(360, 23);
            this.checkboxLeg1.Name = "checkboxLeg1";
            this.checkboxLeg1.Size = new System.Drawing.Size(107, 23);
            this.checkboxLeg1.TabIndex = 0;
            this.checkboxLeg1.Text = "ONE WAY";
            this.toolTip1.SetToolTip(this.checkboxLeg1, "Flight only one way.");
            this.checkboxLeg1.UseVisualStyleBackColor = true;
            this.checkboxLeg1.CheckedChanged += new System.EventHandler(this.boxReturn_CheckedChanged);
            // 
            // pnlFirstFlight
            // 
            this.pnlFirstFlight.BackColor = System.Drawing.Color.Transparent;
            this.pnlFirstFlight.Controls.Add(this.dateLeg1);
            this.pnlFirstFlight.Controls.Add(this.lblDestFirstFlight);
            this.pnlFirstFlight.Controls.Add(this.cboDepartureLeg1);
            this.pnlFirstFlight.Controls.Add(this.lblDepartFirstFlight);
            this.pnlFirstFlight.Controls.Add(this.cboDestinationLeg1);
            this.pnlFirstFlight.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnlFirstFlight.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.pnlFirstFlight.Location = new System.Drawing.Point(1, 73);
            this.pnlFirstFlight.Name = "pnlFirstFlight";
            this.pnlFirstFlight.Size = new System.Drawing.Size(803, 81);
            this.pnlFirstFlight.TabIndex = 6;
            // 
            // dateLeg1
            // 
            this.dateLeg1.Checked = false;
            this.dateLeg1.Location = new System.Drawing.Point(500, 46);
            this.dateLeg1.Name = "dateLeg1";
            this.dateLeg1.Size = new System.Drawing.Size(271, 25);
            this.dateLeg1.TabIndex = 172;
            this.toolTip1.SetToolTip(this.dateLeg1, "Leg 1 Date");
           
            // 
            // lblDestFirstFlight
            // 
            this.lblDestFirstFlight.AutoSize = true;
            this.lblDestFirstFlight.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDestFirstFlight.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblDestFirstFlight.Location = new System.Drawing.Point(256, 15);
            this.lblDestFirstFlight.Name = "lblDestFirstFlight";
            this.lblDestFirstFlight.Size = new System.Drawing.Size(98, 19);
            this.lblDestFirstFlight.TabIndex = 140;
            this.lblDestFirstFlight.Text = "Destination";
            // 
            // cboDepartureLeg1
            // 
            this.cboDepartureLeg1.FormattingEnabled = true;
            this.cboDepartureLeg1.Location = new System.Drawing.Point(34, 47);
            this.cboDepartureLeg1.Name = "cboDepartureLeg1";
            this.cboDepartureLeg1.Size = new System.Drawing.Size(179, 26);
            this.cboDepartureLeg1.TabIndex = 3;
            this.toolTip1.SetToolTip(this.cboDepartureLeg1, "Departure Airport");
            this.cboDepartureLeg1.Leave += new System.EventHandler(this.cboDepartureLeg1_Leave);
            // 
            // lblDepartFirstFlight
            // 
            this.lblDepartFirstFlight.AutoSize = true;
            this.lblDepartFirstFlight.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDepartFirstFlight.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblDepartFirstFlight.Location = new System.Drawing.Point(30, 15);
            this.lblDepartFirstFlight.Name = "lblDepartFirstFlight";
            this.lblDepartFirstFlight.Size = new System.Drawing.Size(88, 19);
            this.lblDepartFirstFlight.TabIndex = 130;
            this.lblDepartFirstFlight.Text = "Departure";
            // 
            // cboDestinationLeg1
            // 
            this.cboDestinationLeg1.FormattingEnabled = true;
            this.cboDestinationLeg1.Location = new System.Drawing.Point(260, 46);
            this.cboDestinationLeg1.Name = "cboDestinationLeg1";
            this.cboDestinationLeg1.Size = new System.Drawing.Size(197, 26);
            this.cboDestinationLeg1.TabIndex = 4;
            this.toolTip1.SetToolTip(this.cboDestinationLeg1, "Destination Airport");
            this.cboDestinationLeg1.Leave += new System.EventHandler(this.cboDestinationLeg1_Leave);
            // 
            // btnBook
            // 
            this.btnBook.BackColor = System.Drawing.Color.White;
            this.btnBook.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBook.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBook.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.btnBook.Location = new System.Drawing.Point(660, 395);
            this.btnBook.Name = "btnBook";
            this.btnBook.Size = new System.Drawing.Size(112, 43);
            this.btnBook.TabIndex = 15;
            this.btnBook.Text = "BOOK";
            this.btnBook.UseVisualStyleBackColor = false;
            this.btnBook.Click += new System.EventHandler(this.btnBook_Click);
            // 
            // pnlFlightClass
            // 
            this.pnlFlightClass.BackColor = System.Drawing.Color.Transparent;
            this.pnlFlightClass.Controls.Add(this.radioFirstClass);
            this.pnlFlightClass.Controls.Add(this.radioEconomy);
            this.pnlFlightClass.Controls.Add(this.radioBusiness);
            this.pnlFlightClass.Location = new System.Drawing.Point(96, 317);
            this.pnlFlightClass.Name = "pnlFlightClass";
            this.pnlFlightClass.Size = new System.Drawing.Size(574, 39);
            this.pnlFlightClass.TabIndex = 9;
            // 
            // radioFirstClass
            // 
            this.radioFirstClass.AutoSize = true;
            this.radioFirstClass.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioFirstClass.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.radioFirstClass.Location = new System.Drawing.Point(239, 12);
            this.radioFirstClass.Name = "radioFirstClass";
            this.radioFirstClass.Size = new System.Drawing.Size(114, 23);
            this.radioFirstClass.TabIndex = 13;
            this.radioFirstClass.Text = "First Class";
            this.radioFirstClass.UseVisualStyleBackColor = true;
            // 
            // radioEconomy
            // 
            this.radioEconomy.AutoSize = true;
            this.radioEconomy.Checked = true;
            this.radioEconomy.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioEconomy.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.radioEconomy.Location = new System.Drawing.Point(50, 12);
            this.radioEconomy.Name = "radioEconomy";
            this.radioEconomy.Size = new System.Drawing.Size(103, 23);
            this.radioEconomy.TabIndex = 12;
            this.radioEconomy.TabStop = true;
            this.radioEconomy.Text = "Economy";
            this.radioEconomy.UseVisualStyleBackColor = true;
            // 
            // radioBusiness
            // 
            this.radioBusiness.AutoSize = true;
            this.radioBusiness.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioBusiness.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.radioBusiness.Location = new System.Drawing.Point(429, 12);
            this.radioBusiness.Name = "radioBusiness";
            this.radioBusiness.Size = new System.Drawing.Size(102, 23);
            this.radioBusiness.TabIndex = 14;
            this.radioBusiness.Text = "Business";
            this.radioBusiness.UseVisualStyleBackColor = true;
            // 
            // txtBoxFName
            // 
            this.txtBoxFName.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxFName.Location = new System.Drawing.Point(203, 411);
            this.txtBoxFName.Name = "txtBoxFName";
            this.txtBoxFName.Size = new System.Drawing.Size(168, 27);
            this.txtBoxFName.TabIndex = 16;
            this.toolTip1.SetToolTip(this.txtBoxFName, "Passenger First Name");
            this.txtBoxFName.Leave += new System.EventHandler(this.txtBoxFName_Leave);
            // 
            // lblPassenger
            // 
            this.lblPassenger.AutoSize = true;
            this.lblPassenger.BackColor = System.Drawing.Color.Transparent;
            this.lblPassenger.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPassenger.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblPassenger.Location = new System.Drawing.Point(52, 411);
            this.lblPassenger.Name = "lblPassenger";
            this.lblPassenger.Size = new System.Drawing.Size(92, 19);
            this.lblPassenger.TabIndex = 173;
            this.lblPassenger.Text = "Passenger";
            // 
            // cboDestinationLeg2
            // 
            this.cboDestinationLeg2.FormattingEnabled = true;
            this.cboDestinationLeg2.Location = new System.Drawing.Point(260, 110);
            this.cboDestinationLeg2.Name = "cboDestinationLeg2";
            this.cboDestinationLeg2.Size = new System.Drawing.Size(197, 26);
            this.cboDestinationLeg2.TabIndex = 7;
            this.toolTip1.SetToolTip(this.cboDestinationLeg2, "Destination Airport");
            this.cboDestinationLeg2.SelectedIndexChanged += new System.EventHandler(this.cboDestinationLeg2_SelectedIndexChanged);
            // 
            // cboDepartureLeg2
            // 
            this.cboDepartureLeg2.FormattingEnabled = true;
            this.cboDepartureLeg2.Location = new System.Drawing.Point(34, 110);
            this.cboDepartureLeg2.Name = "cboDepartureLeg2";
            this.cboDepartureLeg2.Size = new System.Drawing.Size(179, 26);
            this.cboDepartureLeg2.TabIndex = 6;
            this.toolTip1.SetToolTip(this.cboDepartureLeg2, "Return Departure Airport");
            this.cboDepartureLeg2.SelectedIndexChanged += new System.EventHandler(this.cboDepartureLeg2_SelectedIndexChanged);
            // 
            // lblDepartReturn
            // 
            this.lblDepartReturn.AutoSize = true;
            this.lblDepartReturn.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDepartReturn.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblDepartReturn.Location = new System.Drawing.Point(30, 71);
            this.lblDepartReturn.Name = "lblDepartReturn";
            this.lblDepartReturn.Size = new System.Drawing.Size(88, 19);
            this.lblDepartReturn.TabIndex = 160;
            this.lblDepartReturn.Text = "Departure";
            // 
            // lblDestReturn
            // 
            this.lblDestReturn.AutoSize = true;
            this.lblDestReturn.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDestReturn.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblDestReturn.Location = new System.Drawing.Point(259, 75);
            this.lblDestReturn.Name = "lblDestReturn";
            this.lblDestReturn.Size = new System.Drawing.Size(98, 19);
            this.lblDestReturn.TabIndex = 170;
            this.lblDestReturn.Text = "Destination";
            // 
            // pnlReturnFlight
            // 
            this.pnlReturnFlight.BackColor = System.Drawing.Color.DarkViolet;
            this.pnlReturnFlight.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlReturnFlight.Controls.Add(this.lblReturn);
            this.pnlReturnFlight.Location = new System.Drawing.Point(-1, 3);
            this.pnlReturnFlight.Name = "pnlReturnFlight";
            this.pnlReturnFlight.Size = new System.Drawing.Size(800, 51);
            this.pnlReturnFlight.TabIndex = 172;
            // 
            // lblReturn
            // 
            this.lblReturn.AutoSize = true;
            this.lblReturn.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReturn.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblReturn.Location = new System.Drawing.Point(330, 14);
            this.lblReturn.Name = "lblReturn";
            this.lblReturn.Size = new System.Drawing.Size(144, 19);
            this.lblReturn.TabIndex = 171;
            this.lblReturn.Text = "SECOND FLIGHT";
            // 
            // dateLeg2
            // 
            this.dateLeg2.Checked = false;
            this.dateLeg2.Location = new System.Drawing.Point(500, 108);
            this.dateLeg2.Name = "dateLeg2";
            this.dateLeg2.Size = new System.Drawing.Size(271, 25);
            this.dateLeg2.TabIndex = 171;
            this.toolTip1.SetToolTip(this.dateLeg2, "Leg 2 Date");
            this.dateLeg2.ValueChanged += new System.EventHandler(this.dateLeg2_ValueChanged);
            // 
            // pnlSecondFlight
            // 
            this.pnlSecondFlight.BackColor = System.Drawing.Color.Transparent;
            this.pnlSecondFlight.Controls.Add(this.dateLeg2);
            this.pnlSecondFlight.Controls.Add(this.pnlReturnFlight);
            this.pnlSecondFlight.Controls.Add(this.lblDestReturn);
            this.pnlSecondFlight.Controls.Add(this.lblDepartReturn);
            this.pnlSecondFlight.Controls.Add(this.cboDepartureLeg2);
            this.pnlSecondFlight.Controls.Add(this.cboDestinationLeg2);
            this.pnlSecondFlight.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnlSecondFlight.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.pnlSecondFlight.Location = new System.Drawing.Point(1, 179);
            this.pnlSecondFlight.Name = "pnlSecondFlight";
            this.pnlSecondFlight.Size = new System.Drawing.Size(803, 144);
            this.pnlSecondFlight.TabIndex = 10;
            // 
            // txtBoxLName
            // 
            this.txtBoxLName.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxLName.Location = new System.Drawing.Point(399, 411);
            this.txtBoxLName.Name = "txtBoxLName";
            this.txtBoxLName.Size = new System.Drawing.Size(168, 27);
            this.txtBoxLName.TabIndex = 174;
            this.toolTip1.SetToolTip(this.txtBoxLName, "Passenger Last Name");
            this.txtBoxLName.Leave += new System.EventHandler(this.txtBoxLName_Leave);
            // 
            // lblFName
            // 
            this.lblFName.AutoSize = true;
            this.lblFName.BackColor = System.Drawing.Color.Transparent;
            this.lblFName.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFName.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblFName.Location = new System.Drawing.Point(199, 379);
            this.lblFName.Name = "lblFName";
            this.lblFName.Size = new System.Drawing.Size(94, 19);
            this.lblFName.TabIndex = 175;
            this.lblFName.Text = "First Name";
            // 
            // lblLName
            // 
            this.lblLName.AutoSize = true;
            this.lblLName.BackColor = System.Drawing.Color.Transparent;
            this.lblLName.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLName.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblLName.Location = new System.Drawing.Point(395, 379);
            this.lblLName.Name = "lblLName";
            this.lblLName.Size = new System.Drawing.Size(92, 19);
            this.lblLName.TabIndex = 176;
            this.lblLName.Text = "Last Name";
            // 
            // frmMakeBooking
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightCyan;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblLName);
            this.Controls.Add(this.lblFName);
            this.Controls.Add(this.txtBoxLName);
            this.Controls.Add(this.pnlSecondFlight);
            this.Controls.Add(this.pnlFlightClass);
            this.Controls.Add(this.lblPassenger);
            this.Controls.Add(this.txtBoxFName);
            this.Controls.Add(this.btnBook);
            this.Controls.Add(this.pnlFlightType);
            this.Controls.Add(this.pnlFirstFlight);
            this.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.Name = "frmMakeBooking";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cyanair Booking System";
            this.Load += new System.EventHandler(this.frmMakeBooking_Load);
            this.pnlFlightType.ResumeLayout(false);
            this.pnlFlightType.PerformLayout();
            this.pnlFirstFlight.ResumeLayout(false);
            this.pnlFirstFlight.PerformLayout();
            this.pnlFlightClass.ResumeLayout(false);
            this.pnlFlightClass.PerformLayout();
            this.pnlReturnFlight.ResumeLayout(false);
            this.pnlReturnFlight.PerformLayout();
            this.pnlSecondFlight.ResumeLayout(false);
            this.pnlSecondFlight.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlFlightType;
        private System.Windows.Forms.CheckBox checkboxLeg1;
        private System.Windows.Forms.CheckBox checkboxLeg2;
        private System.Windows.Forms.Panel pnlFirstFlight;
        private System.Windows.Forms.Button btnBook;
        private System.Windows.Forms.Label lblDestFirstFlight;
        private System.Windows.Forms.ComboBox cboDepartureLeg1;
        private System.Windows.Forms.Label lblDepartFirstFlight;
        private System.Windows.Forms.ComboBox cboDestinationLeg1;
        private System.Windows.Forms.Panel pnlFlightClass;
        private System.Windows.Forms.RadioButton radioFirstClass;
        private System.Windows.Forms.RadioButton radioEconomy;
        private System.Windows.Forms.RadioButton radioBusiness;
        private System.Windows.Forms.TextBox txtBoxFName;
        private System.Windows.Forms.Label lblPassenger;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Label logo;
        private System.Windows.Forms.ComboBox cboDestinationLeg2;
        private System.Windows.Forms.ComboBox cboDepartureLeg2;
        private System.Windows.Forms.Label lblDepartReturn;
        private System.Windows.Forms.Label lblDestReturn;
        private System.Windows.Forms.Panel pnlReturnFlight;
        private System.Windows.Forms.Label lblReturn;
        private System.Windows.Forms.DateTimePicker dateLeg2;
        private System.Windows.Forms.Panel pnlSecondFlight;
        private System.Windows.Forms.TextBox txtBoxLName;
        private System.Windows.Forms.Label lblFName;
        private System.Windows.Forms.Label lblLName;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.DateTimePicker dateLeg1;
    }
}

