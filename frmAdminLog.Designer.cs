namespace Cyanair_Booking_App
{
    partial class frmAdminLog
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAdminLog));
            this.pnlFlightType = new System.Windows.Forms.Panel();
            this.logo = new System.Windows.Forms.Label();
            this.pnlLogin = new System.Windows.Forms.Panel();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnOk = new System.Windows.Forms.Button();
            this.lblAdminLogin = new System.Windows.Forms.Label();
            this.lblPassword = new System.Windows.Forms.Label();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.pnlFlightType.SuspendLayout();
            this.pnlLogin.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlFlightType
            // 
            this.pnlFlightType.BackColor = System.Drawing.Color.DarkViolet;
            this.pnlFlightType.Controls.Add(this.logo);
            this.pnlFlightType.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnlFlightType.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.pnlFlightType.Location = new System.Drawing.Point(0, 1);
            this.pnlFlightType.Name = "pnlFlightType";
            this.pnlFlightType.Size = new System.Drawing.Size(803, 66);
            this.pnlFlightType.TabIndex = 1;
            // 
            // logo
            // 
            this.logo.AutoSize = true;
            this.logo.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logo.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.logo.Location = new System.Drawing.Point(11, 23);
            this.logo.Name = "logo";
            this.logo.Size = new System.Drawing.Size(122, 24);
            this.logo.TabIndex = 4;
            this.logo.Text = "Cyanair Airline";
            // 
            // pnlLogin
            // 
            this.pnlLogin.BackColor = System.Drawing.Color.DarkOrchid;
            this.pnlLogin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pnlLogin.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlLogin.Controls.Add(this.btnCancel);
            this.pnlLogin.Controls.Add(this.btnOk);
            this.pnlLogin.Controls.Add(this.lblAdminLogin);
            this.pnlLogin.Controls.Add(this.lblPassword);
            this.pnlLogin.Controls.Add(this.textBoxPassword);
            this.pnlLogin.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnlLogin.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.pnlLogin.Location = new System.Drawing.Point(80, 108);
            this.pnlLogin.Name = "pnlLogin";
            this.pnlLogin.Size = new System.Drawing.Size(648, 279);
            this.pnlLogin.TabIndex = 2;
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.BlueViolet;
            this.btnCancel.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Location = new System.Drawing.Point(248, 197);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(111, 38);
            this.btnCancel.TabIndex = 4;
            this.btnCancel.Text = "CANCEL";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnOk
            // 
            this.btnOk.BackColor = System.Drawing.Color.BlueViolet;
            this.btnOk.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOk.Location = new System.Drawing.Point(404, 197);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(87, 38);
            this.btnOk.TabIndex = 3;
            this.btnOk.Text = "OK";
            this.btnOk.UseVisualStyleBackColor = false;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // lblAdminLogin
            // 
            this.lblAdminLogin.AutoSize = true;
            this.lblAdminLogin.BackColor = System.Drawing.Color.DarkOrchid;
            this.lblAdminLogin.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAdminLogin.Location = new System.Drawing.Point(278, 50);
            this.lblAdminLogin.Name = "lblAdminLogin";
            this.lblAdminLogin.Size = new System.Drawing.Size(175, 29);
            this.lblAdminLogin.TabIndex = 2;
            this.lblAdminLogin.Text = "ADMIN LOGIN";
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Location = new System.Drawing.Point(130, 124);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(103, 22);
            this.lblPassword.TabIndex = 1;
            this.lblPassword.Text = "Password";
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.Location = new System.Drawing.Point(261, 121);
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.PasswordChar = '*';
            this.textBoxPassword.Size = new System.Drawing.Size(213, 28);
            this.textBoxPassword.TabIndex = 0;
            this.textBoxPassword.Text = "123";
             // 
            // frmAdminLog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pnlLogin);
            this.Controls.Add(this.pnlFlightType);
            this.Name = "frmAdminLog";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Admin User";
            this.TopMost = true;
            this.pnlFlightType.ResumeLayout(false);
            this.pnlFlightType.PerformLayout();
            this.pnlLogin.ResumeLayout(false);
            this.pnlLogin.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlFlightType;
        private System.Windows.Forms.Panel pnlLogin;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.TextBox textBoxPassword;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Label logo;
        private System.Windows.Forms.Label lblAdminLogin;
    }
}