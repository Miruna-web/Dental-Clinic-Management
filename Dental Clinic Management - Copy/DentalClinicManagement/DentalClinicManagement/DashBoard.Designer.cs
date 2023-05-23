
namespace DentalClinicManagement
{
    partial class DashBoard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DashBoard));
            this.panel2 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.UsersProgress = new Guna.UI2.WinForms.Guna2CircleProgressBar();
            this.Patientlbl = new System.Windows.Forms.Label();
            this.Patients = new Guna.UI2.WinForms.Guna2CircleProgressBar();
            this.Userlbl = new System.Windows.Forms.Label();
            this.PendingAppProgres = new Guna.UI2.WinForms.Guna2CircleProgressBar();
            this.Pendinglbl = new System.Windows.Forms.Label();
            this.NextApp = new Guna.UI2.WinForms.Guna2CircleProgressBar();
            this.NextAppLbl = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            this.panel1.SuspendLayout();
            this.UsersProgress.SuspendLayout();
            this.Patients.SuspendLayout();
            this.PendingAppProgres.SuspendLayout();
            this.NextApp.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label13);
            this.panel2.Controls.Add(this.pictureBox7);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1236, 82);
            this.panel2.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label5.Font = new System.Drawing.Font("Microsoft JhengHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label5.Location = new System.Drawing.Point(1209, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(27, 27);
            this.label5.TabIndex = 9;
            this.label5.Text = "X";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Georgia", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label13.Location = new System.Drawing.Point(108, 20);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(398, 38);
            this.label13.TabIndex = 20;
            this.label13.Text = "Dental Clinic - Dashboard";
            // 
            // pictureBox7
            // 
            this.pictureBox7.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox7.Image")));
            this.pictureBox7.Location = new System.Drawing.Point(0, 0);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(93, 82);
            this.pictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox7.TabIndex = 19;
            this.pictureBox7.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 679);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1236, 83);
            this.panel1.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Georgia", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label1.Location = new System.Drawing.Point(586, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 35);
            this.label1.TabIndex = 26;
            this.label1.Text = "Back";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // UsersProgress
            // 
            this.UsersProgress.Controls.Add(this.Patientlbl);
            this.UsersProgress.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(213)))), ((int)(((byte)(218)))), ((int)(((byte)(223)))));
            this.UsersProgress.FillThickness = 18;
            this.UsersProgress.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.UsersProgress.ForeColor = System.Drawing.Color.White;
            this.UsersProgress.Location = new System.Drawing.Point(592, 104);
            this.UsersProgress.Minimum = 0;
            this.UsersProgress.Name = "UsersProgress";
            this.UsersProgress.ProgressColor = System.Drawing.Color.DeepSkyBlue;
            this.UsersProgress.ProgressColor2 = System.Drawing.Color.DeepSkyBlue;
            this.UsersProgress.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.UsersProgress.Size = new System.Drawing.Size(268, 268);
            this.UsersProgress.TabIndex = 5;
            this.UsersProgress.Text = "Patients";
            // 
            // Patientlbl
            // 
            this.Patientlbl.AutoSize = true;
            this.Patientlbl.Font = new System.Drawing.Font("Georgia", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Patientlbl.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Patientlbl.Location = new System.Drawing.Point(94, 113);
            this.Patientlbl.Name = "Patientlbl";
            this.Patientlbl.Size = new System.Drawing.Size(118, 49);
            this.Patientlbl.TabIndex = 26;
            this.Patientlbl.Text = "Num";
            // 
            // Patients
            // 
            this.Patients.Controls.Add(this.Userlbl);
            this.Patients.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(213)))), ((int)(((byte)(218)))), ((int)(((byte)(223)))));
            this.Patients.FillThickness = 18;
            this.Patients.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.Patients.ForeColor = System.Drawing.Color.White;
            this.Patients.Location = new System.Drawing.Point(307, 405);
            this.Patients.Minimum = 0;
            this.Patients.Name = "Patients";
            this.Patients.ProgressColor = System.Drawing.Color.DeepSkyBlue;
            this.Patients.ProgressColor2 = System.Drawing.Color.DeepSkyBlue;
            this.Patients.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.Patients.Size = new System.Drawing.Size(268, 268);
            this.Patients.TabIndex = 8;
            this.Patients.Text = "UsersProgress";
            // 
            // Userlbl
            // 
            this.Userlbl.AutoSize = true;
            this.Userlbl.Font = new System.Drawing.Font("Georgia", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Userlbl.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Userlbl.Location = new System.Drawing.Point(93, 117);
            this.Userlbl.Name = "Userlbl";
            this.Userlbl.Size = new System.Drawing.Size(118, 49);
            this.Userlbl.TabIndex = 26;
            this.Userlbl.Text = "Num";
            // 
            // PendingAppProgres
            // 
            this.PendingAppProgres.Controls.Add(this.Pendinglbl);
            this.PendingAppProgres.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(213)))), ((int)(((byte)(218)))), ((int)(((byte)(223)))));
            this.PendingAppProgres.FillThickness = 18;
            this.PendingAppProgres.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.PendingAppProgres.ForeColor = System.Drawing.Color.White;
            this.PendingAppProgres.Location = new System.Drawing.Point(65, 104);
            this.PendingAppProgres.Minimum = 0;
            this.PendingAppProgres.Name = "PendingAppProgres";
            this.PendingAppProgres.ProgressColor = System.Drawing.Color.DeepSkyBlue;
            this.PendingAppProgres.ProgressColor2 = System.Drawing.Color.DeepSkyBlue;
            this.PendingAppProgres.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.PendingAppProgres.Size = new System.Drawing.Size(268, 268);
            this.PendingAppProgres.TabIndex = 9;
            this.PendingAppProgres.Text = "guna2CircleProgressBar1";
            // 
            // Pendinglbl
            // 
            this.Pendinglbl.AutoSize = true;
            this.Pendinglbl.Font = new System.Drawing.Font("Georgia", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Pendinglbl.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Pendinglbl.Location = new System.Drawing.Point(80, 101);
            this.Pendinglbl.Name = "Pendinglbl";
            this.Pendinglbl.Size = new System.Drawing.Size(118, 49);
            this.Pendinglbl.TabIndex = 25;
            this.Pendinglbl.Text = "Num";
           
            // 
            // NextApp
            // 
            this.NextApp.Controls.Add(this.NextAppLbl);
            this.NextApp.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(213)))), ((int)(((byte)(218)))), ((int)(((byte)(223)))));
            this.NextApp.FillThickness = 18;
            this.NextApp.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.NextApp.ForeColor = System.Drawing.Color.White;
            this.NextApp.Location = new System.Drawing.Point(903, 405);
            this.NextApp.Minimum = 0;
            this.NextApp.Name = "NextApp";
            this.NextApp.ProgressColor = System.Drawing.Color.DeepSkyBlue;
            this.NextApp.ProgressColor2 = System.Drawing.Color.DeepSkyBlue;
            this.NextApp.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.NextApp.Size = new System.Drawing.Size(268, 268);
            this.NextApp.TabIndex = 10;
            this.NextApp.Text = "guna2CircleProgressBar4";
            // 
            // NextAppLbl
            // 
            this.NextAppLbl.AutoSize = true;
            this.NextAppLbl.Font = new System.Drawing.Font("Georgia", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NextAppLbl.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.NextAppLbl.Location = new System.Drawing.Point(93, 117);
            this.NextAppLbl.Name = "NextAppLbl";
            this.NextAppLbl.Size = new System.Drawing.Size(118, 49);
            this.NextAppLbl.TabIndex = 26;
            this.NextAppLbl.Text = "Num";
            // 
            // DashBoard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1236, 762);
            this.Controls.Add(this.NextApp);
            this.Controls.Add(this.PendingAppProgres);
            this.Controls.Add(this.Patients);
            this.Controls.Add(this.UsersProgress);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "DashBoard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DashBoard";
            this.Load += new System.EventHandler(this.DashBoard_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.UsersProgress.ResumeLayout(false);
            this.UsersProgress.PerformLayout();
            this.Patients.ResumeLayout(false);
            this.Patients.PerformLayout();
            this.PendingAppProgres.ResumeLayout(false);
            this.PendingAppProgres.PerformLayout();
            this.NextApp.ResumeLayout(false);
            this.NextApp.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.PictureBox pictureBox7;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label5;
        private Guna.UI2.WinForms.Guna2CircleProgressBar UsersProgress;
        private Guna.UI2.WinForms.Guna2CircleProgressBar Patients;
        private Guna.UI2.WinForms.Guna2CircleProgressBar PendingAppProgres;
        private Guna.UI2.WinForms.Guna2CircleProgressBar NextApp;
        private System.Windows.Forms.Label Patientlbl;
        private System.Windows.Forms.Label Userlbl;
        private System.Windows.Forms.Label Pendinglbl;
        private System.Windows.Forms.Label NextAppLbl;
        private System.Windows.Forms.Label label1;
    }
}