namespace HospitalManagement.Doctor.PrescriptionLayer
{
    partial class Prescription
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
            this.bodyTextBox = new Guna.UI2.WinForms.Guna2TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            this.cancelButton = new Guna.UI2.WinForms.Guna2Button();
            this.patientNameTextBox = new Guna.UI2.WinForms.Guna2TextBox();
            this.doctorNameTextBox = new Guna.UI2.WinForms.Guna2TextBox();
            this.mailAddressTextBox = new Guna.UI2.WinForms.Guna2TextBox();
            this.sectionTextBox = new Guna.UI2.WinForms.Guna2TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.guna2AnimateWindow1 = new Guna.UI2.WinForms.Guna2AnimateWindow(this.components);
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // bodyTextBox
            // 
            this.bodyTextBox.BorderColor = System.Drawing.SystemColors.AppWorkspace;
            this.bodyTextBox.BorderRadius = 3;
            this.bodyTextBox.BorderThickness = 3;
            this.bodyTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.bodyTextBox.DefaultText = "";
            this.bodyTextBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.bodyTextBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.bodyTextBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.bodyTextBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.bodyTextBox.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(46)))), ((int)(((byte)(46)))));
            this.bodyTextBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.bodyTextBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bodyTextBox.ForeColor = System.Drawing.Color.White;
            this.bodyTextBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.bodyTextBox.Location = new System.Drawing.Point(6, 122);
            this.bodyTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.bodyTextBox.Multiline = true;
            this.bodyTextBox.Name = "bodyTextBox";
            this.bodyTextBox.PasswordChar = '\0';
            this.bodyTextBox.PlaceholderText = "";
            this.bodyTextBox.SelectedText = "";
            this.bodyTextBox.Size = new System.Drawing.Size(400, 150);
            this.bodyTextBox.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(5, 99);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 21);
            this.label1.TabIndex = 1;
            this.label1.Text = "Mail İçeriği";
            // 
            // guna2Button1
            // 
            this.guna2Button1.BorderColor = System.Drawing.SystemColors.AppWorkspace;
            this.guna2Button1.BorderRadius = 3;
            this.guna2Button1.BorderThickness = 2;
            this.guna2Button1.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(46)))), ((int)(((byte)(46)))));
            this.guna2Button1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2Button1.ForeColor = System.Drawing.Color.White;
            this.guna2Button1.Location = new System.Drawing.Point(413, 182);
            this.guna2Button1.Name = "guna2Button1";
            this.guna2Button1.Size = new System.Drawing.Size(134, 90);
            this.guna2Button1.TabIndex = 2;
            this.guna2Button1.Text = "Mail Gönder";
            this.guna2Button1.Click += new System.EventHandler(this.guna2Button1_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.BorderColor = System.Drawing.SystemColors.AppWorkspace;
            this.cancelButton.BorderRadius = 3;
            this.cancelButton.BorderThickness = 2;
            this.cancelButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.cancelButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.cancelButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.cancelButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.cancelButton.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(46)))), ((int)(((byte)(46)))));
            this.cancelButton.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.cancelButton.ForeColor = System.Drawing.Color.White;
            this.cancelButton.Location = new System.Drawing.Point(413, 122);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(134, 54);
            this.cancelButton.TabIndex = 4;
            this.cancelButton.Text = "İPTAL";
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // patientNameTextBox
            // 
            this.patientNameTextBox.Animated = true;
            this.patientNameTextBox.BorderColor = System.Drawing.SystemColors.AppWorkspace;
            this.patientNameTextBox.BorderRadius = 2;
            this.patientNameTextBox.BorderThickness = 2;
            this.patientNameTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.patientNameTextBox.DefaultText = "";
            this.patientNameTextBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(46)))), ((int)(((byte)(46)))));
            this.patientNameTextBox.DisabledState.FillColor = System.Drawing.SystemColors.AppWorkspace;
            this.patientNameTextBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(1)))), ((int)(((byte)(1)))));
            this.patientNameTextBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.patientNameTextBox.Enabled = false;
            this.patientNameTextBox.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(46)))), ((int)(((byte)(46)))));
            this.patientNameTextBox.FocusedState.BorderColor = System.Drawing.Color.Red;
            this.patientNameTextBox.Font = new System.Drawing.Font("Segoe UI", 14.25F);
            this.patientNameTextBox.ForeColor = System.Drawing.Color.White;
            this.patientNameTextBox.HoverState.BorderColor = System.Drawing.Color.Red;
            this.patientNameTextBox.Location = new System.Drawing.Point(6, 4);
            this.patientNameTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.patientNameTextBox.Name = "patientNameTextBox";
            this.patientNameTextBox.PasswordChar = '\0';
            this.patientNameTextBox.PlaceholderText = "";
            this.patientNameTextBox.SelectedText = "";
            this.patientNameTextBox.Size = new System.Drawing.Size(221, 40);
            this.patientNameTextBox.TabIndex = 97;
            // 
            // doctorNameTextBox
            // 
            this.doctorNameTextBox.Animated = true;
            this.doctorNameTextBox.BorderColor = System.Drawing.SystemColors.AppWorkspace;
            this.doctorNameTextBox.BorderRadius = 2;
            this.doctorNameTextBox.BorderThickness = 2;
            this.doctorNameTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.doctorNameTextBox.DefaultText = "";
            this.doctorNameTextBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(46)))), ((int)(((byte)(46)))));
            this.doctorNameTextBox.DisabledState.FillColor = System.Drawing.SystemColors.AppWorkspace;
            this.doctorNameTextBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(1)))), ((int)(((byte)(1)))));
            this.doctorNameTextBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.doctorNameTextBox.Enabled = false;
            this.doctorNameTextBox.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(46)))), ((int)(((byte)(46)))));
            this.doctorNameTextBox.FocusedState.BorderColor = System.Drawing.Color.Red;
            this.doctorNameTextBox.Font = new System.Drawing.Font("Segoe UI", 14.25F);
            this.doctorNameTextBox.ForeColor = System.Drawing.Color.White;
            this.doctorNameTextBox.HoverState.BorderColor = System.Drawing.Color.Red;
            this.doctorNameTextBox.Location = new System.Drawing.Point(6, 52);
            this.doctorNameTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.doctorNameTextBox.Name = "doctorNameTextBox";
            this.doctorNameTextBox.PasswordChar = '\0';
            this.doctorNameTextBox.PlaceholderText = "";
            this.doctorNameTextBox.SelectedText = "";
            this.doctorNameTextBox.Size = new System.Drawing.Size(221, 40);
            this.doctorNameTextBox.TabIndex = 98;
            // 
            // mailAddressTextBox
            // 
            this.mailAddressTextBox.Animated = true;
            this.mailAddressTextBox.BorderColor = System.Drawing.SystemColors.AppWorkspace;
            this.mailAddressTextBox.BorderRadius = 2;
            this.mailAddressTextBox.BorderThickness = 2;
            this.mailAddressTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.mailAddressTextBox.DefaultText = "";
            this.mailAddressTextBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(46)))), ((int)(((byte)(46)))));
            this.mailAddressTextBox.DisabledState.FillColor = System.Drawing.SystemColors.AppWorkspace;
            this.mailAddressTextBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(1)))), ((int)(((byte)(1)))));
            this.mailAddressTextBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.mailAddressTextBox.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(46)))), ((int)(((byte)(46)))));
            this.mailAddressTextBox.FocusedState.BorderColor = System.Drawing.Color.Red;
            this.mailAddressTextBox.Font = new System.Drawing.Font("Segoe UI", 14.25F);
            this.mailAddressTextBox.ForeColor = System.Drawing.Color.White;
            this.mailAddressTextBox.HoverState.BorderColor = System.Drawing.Color.Red;
            this.mailAddressTextBox.Location = new System.Drawing.Point(235, 4);
            this.mailAddressTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.mailAddressTextBox.Name = "mailAddressTextBox";
            this.mailAddressTextBox.PasswordChar = '\0';
            this.mailAddressTextBox.PlaceholderText = "Mail Adresi";
            this.mailAddressTextBox.SelectedText = "";
            this.mailAddressTextBox.Size = new System.Drawing.Size(312, 40);
            this.mailAddressTextBox.TabIndex = 99;
            // 
            // sectionTextBox
            // 
            this.sectionTextBox.Animated = true;
            this.sectionTextBox.BorderColor = System.Drawing.SystemColors.AppWorkspace;
            this.sectionTextBox.BorderRadius = 2;
            this.sectionTextBox.BorderThickness = 2;
            this.sectionTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.sectionTextBox.DefaultText = "";
            this.sectionTextBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(46)))), ((int)(((byte)(46)))));
            this.sectionTextBox.DisabledState.FillColor = System.Drawing.SystemColors.AppWorkspace;
            this.sectionTextBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(1)))), ((int)(((byte)(1)))));
            this.sectionTextBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.sectionTextBox.Enabled = false;
            this.sectionTextBox.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(46)))), ((int)(((byte)(46)))));
            this.sectionTextBox.FocusedState.BorderColor = System.Drawing.Color.Red;
            this.sectionTextBox.Font = new System.Drawing.Font("Segoe UI", 14.25F);
            this.sectionTextBox.ForeColor = System.Drawing.Color.White;
            this.sectionTextBox.HoverState.BorderColor = System.Drawing.Color.Red;
            this.sectionTextBox.Location = new System.Drawing.Point(235, 52);
            this.sectionTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.sectionTextBox.Name = "sectionTextBox";
            this.sectionTextBox.PasswordChar = '\0';
            this.sectionTextBox.PlaceholderText = "";
            this.sectionTextBox.SelectedText = "";
            this.sectionTextBox.Size = new System.Drawing.Size(312, 40);
            this.sectionTextBox.TabIndex = 100;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(46)))), ((int)(((byte)(46)))));
            this.panel1.Controls.Add(this.cancelButton);
            this.panel1.Controls.Add(this.sectionTextBox);
            this.panel1.Controls.Add(this.guna2Button1);
            this.panel1.Controls.Add(this.mailAddressTextBox);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.doctorNameTextBox);
            this.panel1.Controls.Add(this.bodyTextBox);
            this.panel1.Controls.Add(this.patientNameTextBox);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(1, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(552, 279);
            this.panel1.TabIndex = 101;
            // 
            // guna2AnimateWindow1
            // 
            this.guna2AnimateWindow1.AnimationType = Guna.UI2.WinForms.Guna2AnimateWindow.AnimateWindowType.AW_BLEND;
            this.guna2AnimateWindow1.Interval = 150;
            this.guna2AnimateWindow1.TargetForm = this;
            // 
            // Prescription
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Orange;
            this.ClientSize = new System.Drawing.Size(554, 281);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Prescription";
            this.Padding = new System.Windows.Forms.Padding(1);
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Prescription";
            this.Load += new System.EventHandler(this.Prescription_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2TextBox bodyTextBox;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
        private Guna.UI2.WinForms.Guna2Button cancelButton;
        private Guna.UI2.WinForms.Guna2TextBox patientNameTextBox;
        private Guna.UI2.WinForms.Guna2TextBox doctorNameTextBox;
        private Guna.UI2.WinForms.Guna2TextBox mailAddressTextBox;
        private Guna.UI2.WinForms.Guna2TextBox sectionTextBox;
        private System.Windows.Forms.Panel panel1;
        private Guna.UI2.WinForms.Guna2AnimateWindow guna2AnimateWindow1;
    }
}