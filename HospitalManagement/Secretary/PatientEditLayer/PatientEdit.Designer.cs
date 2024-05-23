namespace HospitalManagement.Secretary.PatientEditLayer
{
    partial class PatientEdit
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
            this.cancelButton = new Guna.UI2.WinForms.Guna2Button();
            this.addressTextBox = new Guna.UI2.WinForms.Guna2TextBox();
            this.phoneTextBox = new Guna.UI2.WinForms.Guna2TextBox();
            this.nameTextBox = new Guna.UI2.WinForms.Guna2TextBox();
            this.tcnoTextBox = new Guna.UI2.WinForms.Guna2TextBox();
            this.mailTextBox = new Guna.UI2.WinForms.Guna2TextBox();
            this.surnameTextBox = new Guna.UI2.WinForms.Guna2TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.confirmButton = new Guna.UI2.WinForms.Guna2Button();
            this.guna2AnimateWindow1 = new Guna.UI2.WinForms.Guna2AnimateWindow(this.components);
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // cancelButton
            // 
            this.cancelButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.cancelButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.cancelButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.cancelButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.cancelButton.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(46)))), ((int)(((byte)(46)))));
            this.cancelButton.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.cancelButton.ForeColor = System.Drawing.Color.White;
            this.cancelButton.Location = new System.Drawing.Point(167, 317);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(143, 45);
            this.cancelButton.TabIndex = 0;
            this.cancelButton.Text = "iptal";
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // addressTextBox
            // 
            this.addressTextBox.Animated = true;
            this.addressTextBox.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(46)))), ((int)(((byte)(46)))));
            this.addressTextBox.BorderRadius = 2;
            this.addressTextBox.BorderThickness = 2;
            this.addressTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.addressTextBox.DefaultText = "";
            this.addressTextBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.addressTextBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.addressTextBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.addressTextBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.addressTextBox.FillColor = System.Drawing.SystemColors.AppWorkspace;
            this.addressTextBox.FocusedState.BorderColor = System.Drawing.Color.Red;
            this.addressTextBox.Font = new System.Drawing.Font("Segoe UI", 14.25F);
            this.addressTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(1)))), ((int)(((byte)(1)))));
            this.addressTextBox.HoverState.BorderColor = System.Drawing.Color.Red;
            this.addressTextBox.Location = new System.Drawing.Point(4, 235);
            this.addressTextBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.addressTextBox.Multiline = true;
            this.addressTextBox.Name = "addressTextBox";
            this.addressTextBox.PasswordChar = '\0';
            this.addressTextBox.PlaceholderText = "Adres";
            this.addressTextBox.SelectedText = "";
            this.addressTextBox.Size = new System.Drawing.Size(306, 76);
            this.addressTextBox.TabIndex = 94;
            // 
            // phoneTextBox
            // 
            this.phoneTextBox.Animated = true;
            this.phoneTextBox.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(46)))), ((int)(((byte)(46)))));
            this.phoneTextBox.BorderRadius = 2;
            this.phoneTextBox.BorderThickness = 2;
            this.phoneTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.phoneTextBox.DefaultText = "";
            this.phoneTextBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.phoneTextBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.phoneTextBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.phoneTextBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.phoneTextBox.FillColor = System.Drawing.SystemColors.AppWorkspace;
            this.phoneTextBox.FocusedState.BorderColor = System.Drawing.Color.Red;
            this.phoneTextBox.Font = new System.Drawing.Font("Segoe UI", 14.25F);
            this.phoneTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(1)))), ((int)(((byte)(1)))));
            this.phoneTextBox.HoverState.BorderColor = System.Drawing.Color.Red;
            this.phoneTextBox.Location = new System.Drawing.Point(4, 188);
            this.phoneTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.phoneTextBox.Name = "phoneTextBox";
            this.phoneTextBox.PasswordChar = '\0';
            this.phoneTextBox.PlaceholderText = "Telefon";
            this.phoneTextBox.SelectedText = "";
            this.phoneTextBox.Size = new System.Drawing.Size(306, 40);
            this.phoneTextBox.TabIndex = 86;
            // 
            // nameTextBox
            // 
            this.nameTextBox.Animated = true;
            this.nameTextBox.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(46)))), ((int)(((byte)(46)))));
            this.nameTextBox.BorderRadius = 2;
            this.nameTextBox.BorderThickness = 2;
            this.nameTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.nameTextBox.DefaultText = "";
            this.nameTextBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.nameTextBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.nameTextBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.nameTextBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.nameTextBox.FillColor = System.Drawing.SystemColors.AppWorkspace;
            this.nameTextBox.FocusedState.BorderColor = System.Drawing.Color.Red;
            this.nameTextBox.Font = new System.Drawing.Font("Segoe UI", 14.25F);
            this.nameTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(1)))), ((int)(((byte)(1)))));
            this.nameTextBox.HoverState.BorderColor = System.Drawing.Color.Red;
            this.nameTextBox.Location = new System.Drawing.Point(4, 53);
            this.nameTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.PasswordChar = '\0';
            this.nameTextBox.PlaceholderText = "Ad";
            this.nameTextBox.SelectedText = "";
            this.nameTextBox.Size = new System.Drawing.Size(306, 40);
            this.nameTextBox.TabIndex = 82;
            // 
            // tcnoTextBox
            // 
            this.tcnoTextBox.Animated = true;
            this.tcnoTextBox.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(46)))), ((int)(((byte)(46)))));
            this.tcnoTextBox.BorderRadius = 2;
            this.tcnoTextBox.BorderThickness = 2;
            this.tcnoTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tcnoTextBox.DefaultText = "";
            this.tcnoTextBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tcnoTextBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tcnoTextBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tcnoTextBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tcnoTextBox.FillColor = System.Drawing.SystemColors.AppWorkspace;
            this.tcnoTextBox.FocusedState.BorderColor = System.Drawing.Color.Red;
            this.tcnoTextBox.Font = new System.Drawing.Font("Segoe UI", 14.25F);
            this.tcnoTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(1)))), ((int)(((byte)(1)))));
            this.tcnoTextBox.HoverState.BorderColor = System.Drawing.Color.Red;
            this.tcnoTextBox.Location = new System.Drawing.Point(4, 8);
            this.tcnoTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.tcnoTextBox.Name = "tcnoTextBox";
            this.tcnoTextBox.PasswordChar = '\0';
            this.tcnoTextBox.PlaceholderText = "TCNO";
            this.tcnoTextBox.SelectedText = "";
            this.tcnoTextBox.Size = new System.Drawing.Size(306, 40);
            this.tcnoTextBox.TabIndex = 84;
            // 
            // mailTextBox
            // 
            this.mailTextBox.Animated = true;
            this.mailTextBox.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(46)))), ((int)(((byte)(46)))));
            this.mailTextBox.BorderRadius = 2;
            this.mailTextBox.BorderThickness = 2;
            this.mailTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.mailTextBox.DefaultText = "";
            this.mailTextBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.mailTextBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.mailTextBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.mailTextBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.mailTextBox.FillColor = System.Drawing.SystemColors.AppWorkspace;
            this.mailTextBox.FocusedState.BorderColor = System.Drawing.Color.Red;
            this.mailTextBox.Font = new System.Drawing.Font("Segoe UI", 14.25F);
            this.mailTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(1)))), ((int)(((byte)(1)))));
            this.mailTextBox.HoverState.BorderColor = System.Drawing.Color.Red;
            this.mailTextBox.Location = new System.Drawing.Point(4, 143);
            this.mailTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.mailTextBox.Name = "mailTextBox";
            this.mailTextBox.PasswordChar = '\0';
            this.mailTextBox.PlaceholderText = "Mail";
            this.mailTextBox.SelectedText = "";
            this.mailTextBox.Size = new System.Drawing.Size(306, 40);
            this.mailTextBox.TabIndex = 85;
            // 
            // surnameTextBox
            // 
            this.surnameTextBox.Animated = true;
            this.surnameTextBox.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(46)))), ((int)(((byte)(46)))));
            this.surnameTextBox.BorderRadius = 2;
            this.surnameTextBox.BorderThickness = 2;
            this.surnameTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.surnameTextBox.DefaultText = "";
            this.surnameTextBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.surnameTextBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.surnameTextBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.surnameTextBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.surnameTextBox.FillColor = System.Drawing.SystemColors.AppWorkspace;
            this.surnameTextBox.FocusedState.BorderColor = System.Drawing.Color.Red;
            this.surnameTextBox.Font = new System.Drawing.Font("Segoe UI", 14.25F);
            this.surnameTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(1)))), ((int)(((byte)(1)))));
            this.surnameTextBox.HoverState.BorderColor = System.Drawing.Color.Red;
            this.surnameTextBox.Location = new System.Drawing.Point(4, 98);
            this.surnameTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.surnameTextBox.Name = "surnameTextBox";
            this.surnameTextBox.PasswordChar = '\0';
            this.surnameTextBox.PlaceholderText = "Soyad";
            this.surnameTextBox.SelectedText = "";
            this.surnameTextBox.Size = new System.Drawing.Size(306, 40);
            this.surnameTextBox.TabIndex = 83;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.panel1.Controls.Add(this.confirmButton);
            this.panel1.Controls.Add(this.cancelButton);
            this.panel1.Controls.Add(this.nameTextBox);
            this.panel1.Controls.Add(this.surnameTextBox);
            this.panel1.Controls.Add(this.mailTextBox);
            this.panel1.Controls.Add(this.addressTextBox);
            this.panel1.Controls.Add(this.tcnoTextBox);
            this.panel1.Controls.Add(this.phoneTextBox);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(1, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(315, 370);
            this.panel1.TabIndex = 95;
            // 
            // confirmButton
            // 
            this.confirmButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.confirmButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.confirmButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.confirmButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.confirmButton.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(46)))), ((int)(((byte)(46)))));
            this.confirmButton.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.confirmButton.ForeColor = System.Drawing.Color.White;
            this.confirmButton.Location = new System.Drawing.Point(7, 317);
            this.confirmButton.Name = "confirmButton";
            this.confirmButton.Size = new System.Drawing.Size(145, 45);
            this.confirmButton.TabIndex = 95;
            this.confirmButton.Text = "Onayla";
            this.confirmButton.Click += new System.EventHandler(this.confirmButton_Click);
            // 
            // guna2AnimateWindow1
            // 
            this.guna2AnimateWindow1.AnimationType = Guna.UI2.WinForms.Guna2AnimateWindow.AnimateWindowType.AW_BLEND;
            this.guna2AnimateWindow1.Interval = 150;
            this.guna2AnimateWindow1.TargetForm = this;
            // 
            // PatientEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Orange;
            this.ClientSize = new System.Drawing.Size(317, 372);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "PatientEdit";
            this.Padding = new System.Windows.Forms.Padding(1);
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "PatientEdit";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Button cancelButton;
        private Guna.UI2.WinForms.Guna2TextBox addressTextBox;
        private Guna.UI2.WinForms.Guna2TextBox phoneTextBox;
        private Guna.UI2.WinForms.Guna2TextBox nameTextBox;
        private Guna.UI2.WinForms.Guna2TextBox tcnoTextBox;
        private Guna.UI2.WinForms.Guna2TextBox mailTextBox;
        private Guna.UI2.WinForms.Guna2TextBox surnameTextBox;
        private System.Windows.Forms.Panel panel1;
        private Guna.UI2.WinForms.Guna2Button confirmButton;
        private Guna.UI2.WinForms.Guna2AnimateWindow guna2AnimateWindow1;
    }
}