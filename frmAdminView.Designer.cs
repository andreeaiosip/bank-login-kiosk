namespace Cyanair_Booking_App
{
    partial class frmAdminView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAdminView));
            this.pnlAirports = new System.Windows.Forms.Panel();
            this.dgvAirports = new System.Windows.Forms.DataGridView();
            this.btnDelete = new System.Windows.Forms.Button();
            this.lblNewAirport = new System.Windows.Forms.Label();
            this.boxNewAirport = new System.Windows.Forms.TextBox();
            this.btnAddAirport = new System.Windows.Forms.Button();
            this.logo = new System.Windows.Forms.Label();
            this.pnlFlightType = new System.Windows.Forms.Panel();
            this.pnlBookingsHeader = new System.Windows.Forms.Panel();
            this.lblReturn = new System.Windows.Forms.Label();
            this.bntExit = new System.Windows.Forms.Button();
            this.dataGridViewBookings = new System.Windows.Forms.DataGridView();
            this.pnlAirports.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAirports)).BeginInit();
            this.pnlFlightType.SuspendLayout();
            this.pnlBookingsHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBookings)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlAirports
            // 
            this.pnlAirports.BackColor = System.Drawing.Color.DarkViolet;
            this.pnlAirports.Controls.Add(this.dgvAirports);
            this.pnlAirports.Controls.Add(this.btnDelete);
            this.pnlAirports.Controls.Add(this.lblNewAirport);
            this.pnlAirports.Controls.Add(this.boxNewAirport);
            this.pnlAirports.Controls.Add(this.btnAddAirport);
            this.pnlAirports.Font = new System.Drawing.Font("Arial Narrow", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnlAirports.Location = new System.Drawing.Point(154, 7);
            this.pnlAirports.Margin = new System.Windows.Forms.Padding(0);
            this.pnlAirports.Name = "pnlAirports";
            this.pnlAirports.Size = new System.Drawing.Size(595, 247);
            this.pnlAirports.TabIndex = 3;
            // 
            // dgvAirports
            // 
            this.dgvAirports.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAirports.Location = new System.Drawing.Point(39, 54);
            this.dgvAirports.Name = "dgvAirports";
            this.dgvAirports.RowHeadersWidth = 51;
            this.dgvAirports.RowTemplate.Height = 24;
            this.dgvAirports.Size = new System.Drawing.Size(556, 139);
            this.dgvAirports.TabIndex = 7;
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.White;
            this.btnDelete.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.Color.Purple;
            this.btnDelete.Location = new System.Drawing.Point(252, 199);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(106, 31);
            this.btnDelete.TabIndex = 3;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click_1);
            // 
            // lblNewAirport
            // 
            this.lblNewAirport.AutoSize = true;
            this.lblNewAirport.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNewAirport.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblNewAirport.Location = new System.Drawing.Point(40, 18);
            this.lblNewAirport.Name = "lblNewAirport";
            this.lblNewAirport.Size = new System.Drawing.Size(135, 19);
            this.lblNewAirport.TabIndex = 5;
            this.lblNewAirport.Text = "Add new airport";
            // 
            // boxNewAirport
            // 
            this.boxNewAirport.Location = new System.Drawing.Point(203, 15);
            this.boxNewAirport.Name = "boxNewAirport";
            this.boxNewAirport.Size = new System.Drawing.Size(223, 22);
            this.boxNewAirport.TabIndex = 4;
            // 
            // btnAddAirport
            // 
            this.btnAddAirport.BackColor = System.Drawing.Color.White;
            this.btnAddAirport.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddAirport.ForeColor = System.Drawing.Color.Purple;
            this.btnAddAirport.Location = new System.Drawing.Point(447, 10);
            this.btnAddAirport.Name = "btnAddAirport";
            this.btnAddAirport.Size = new System.Drawing.Size(75, 30);
            this.btnAddAirport.TabIndex = 2;
            this.btnAddAirport.Text = "Add";
            this.btnAddAirport.UseVisualStyleBackColor = false;
            this.btnAddAirport.Click += new System.EventHandler(this.btnAddAirport_Click);
            // 
            // logo
            // 
            this.logo.AutoSize = true;
            this.logo.BackColor = System.Drawing.Color.Transparent;
            this.logo.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logo.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.logo.Location = new System.Drawing.Point(13, 22);
            this.logo.Name = "logo";
            this.logo.Size = new System.Drawing.Size(122, 24);
            this.logo.TabIndex = 5;
            this.logo.Text = "Cyanair Airline";
            // 
            // pnlFlightType
            // 
            this.pnlFlightType.BackColor = System.Drawing.Color.DarkViolet;
            this.pnlFlightType.Controls.Add(this.logo);
            this.pnlFlightType.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnlFlightType.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.pnlFlightType.Location = new System.Drawing.Point(-1, 1);
            this.pnlFlightType.Name = "pnlFlightType";
            this.pnlFlightType.Size = new System.Drawing.Size(803, 66);
            this.pnlFlightType.TabIndex = 6;
            // 
            // pnlBookingsHeader
            // 
            this.pnlBookingsHeader.BackColor = System.Drawing.Color.DarkViolet;
            this.pnlBookingsHeader.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlBookingsHeader.Controls.Add(this.lblReturn);
            this.pnlBookingsHeader.Location = new System.Drawing.Point(-1, 258);
            this.pnlBookingsHeader.Name = "pnlBookingsHeader";
            this.pnlBookingsHeader.Size = new System.Drawing.Size(800, 50);
            this.pnlBookingsHeader.TabIndex = 173;
            // 
            // lblReturn
            // 
            this.lblReturn.AutoSize = true;
            this.lblReturn.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReturn.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblReturn.Location = new System.Drawing.Point(361, 14);
            this.lblReturn.Name = "lblReturn";
            this.lblReturn.Size = new System.Drawing.Size(99, 19);
            this.lblReturn.TabIndex = 171;
            this.lblReturn.Text = "BOOKINGS";
            // 
            // bntExit
            // 
            this.bntExit.BackColor = System.Drawing.Color.White;
            this.bntExit.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bntExit.ForeColor = System.Drawing.Color.Purple;
            this.bntExit.Location = new System.Drawing.Point(26, 69);
            this.bntExit.Name = "bntExit";
            this.bntExit.Size = new System.Drawing.Size(74, 31);
            this.bntExit.TabIndex = 174;
            this.bntExit.Text = "EXIT";
            this.bntExit.UseVisualStyleBackColor = false;
            this.bntExit.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridViewBookings
            // 
            this.dataGridViewBookings.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewBookings.Location = new System.Drawing.Point(12, 314);
            this.dataGridViewBookings.Name = "dataGridViewBookings";
            this.dataGridViewBookings.RowHeadersWidth = 51;
            this.dataGridViewBookings.RowTemplate.Height = 24;
            this.dataGridViewBookings.Size = new System.Drawing.Size(776, 133);
            this.dataGridViewBookings.TabIndex = 175;
            // 
            // frmAdminView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridViewBookings);
            this.Controls.Add(this.bntExit);
            this.Controls.Add(this.pnlBookingsHeader);
            this.Controls.Add(this.pnlAirports);
            this.Controls.Add(this.pnlFlightType);
            this.Name = "frmAdminView";
            this.Text = "Cyanair Bookings & Airports";
            this.Load += new System.EventHandler(this.frmAdminView_Load);
            this.pnlAirports.ResumeLayout(false);
            this.pnlAirports.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAirports)).EndInit();
            this.pnlFlightType.ResumeLayout(false);
            this.pnlFlightType.PerformLayout();
            this.pnlBookingsHeader.ResumeLayout(false);
            this.pnlBookingsHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBookings)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel pnlAirports;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnAddAirport;
        private System.Windows.Forms.Label lblNewAirport;
        private System.Windows.Forms.TextBox boxNewAirport;
        private System.Windows.Forms.Label logo;
        private System.Windows.Forms.Panel pnlFlightType;
        private System.Windows.Forms.Panel pnlBookingsHeader;
        private System.Windows.Forms.Label lblReturn;
        private System.Windows.Forms.Button bntExit;
        private System.Windows.Forms.DataGridView dataGridViewBookings;
        private System.Windows.Forms.DataGridView dgvAirports;
    }
}