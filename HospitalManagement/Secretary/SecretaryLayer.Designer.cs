namespace HospitalManagement.Secretary
{
    partial class SecretaryLayer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SecretaryLayer));
            this.exitControlBox = new Guna.UI2.WinForms.Guna2ControlBox();
            this.minimizeControlBox = new Guna.UI2.WinForms.Guna2ControlBox();
            this.topWindowPanel = new Guna.UI2.WinForms.Guna2Panel();
            this.windowName = new System.Windows.Forms.Label();
            this.topWindowPanelDragControl = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.leftPanel = new Guna.UI2.WinForms.Guna2Panel();
            this.doctorButtonSubMenu = new Guna.UI2.WinForms.Guna2Panel();
            this.deleteDoctorButton = new Guna.UI2.WinForms.Guna2Button();
            this.updateDoctorButton = new Guna.UI2.WinForms.Guna2Button();
            this.addNewDoctorButton = new Guna.UI2.WinForms.Guna2Button();
            this.doctorButton = new Guna.UI2.WinForms.Guna2Button();
            this.secretaryButtonSubMenu = new Guna.UI2.WinForms.Guna2Panel();
            this.deleteSecretaryButton = new Guna.UI2.WinForms.Guna2Button();
            this.updateSecretaryButton = new Guna.UI2.WinForms.Guna2Button();
            this.addNewSecretaryButton = new Guna.UI2.WinForms.Guna2Button();
            this.secretaryButton = new Guna.UI2.WinForms.Guna2Button();
            this.patientButtonSubMenu = new Guna.UI2.WinForms.Guna2Panel();
            this.patientGraphsButton = new Guna.UI2.WinForms.Guna2Button();
            this.patientFeaturesButton = new Guna.UI2.WinForms.Guna2Button();
            this.createAppointmentButton = new Guna.UI2.WinForms.Guna2Button();
            this.patientButton = new Guna.UI2.WinForms.Guna2Button();
            this.windowNameDragControl = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.containerPanel = new Guna.UI2.WinForms.Guna2Panel();
            this.topWindowPanel.SuspendLayout();
            this.leftPanel.SuspendLayout();
            this.doctorButtonSubMenu.SuspendLayout();
            this.secretaryButtonSubMenu.SuspendLayout();
            this.patientButtonSubMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // exitControlBox
            // 
            this.exitControlBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.exitControlBox.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(46)))), ((int)(((byte)(46)))));
            this.exitControlBox.IconColor = System.Drawing.Color.White;
            this.exitControlBox.Location = new System.Drawing.Point(791, 0);
            this.exitControlBox.Name = "exitControlBox";
            this.exitControlBox.Size = new System.Drawing.Size(45, 29);
            this.exitControlBox.TabIndex = 3;
            // 
            // minimizeControlBox
            // 
            this.minimizeControlBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.minimizeControlBox.ControlBoxType = Guna.UI2.WinForms.Enums.ControlBoxType.MinimizeBox;
            this.minimizeControlBox.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(46)))), ((int)(((byte)(46)))));
            this.minimizeControlBox.IconColor = System.Drawing.Color.White;
            this.minimizeControlBox.Location = new System.Drawing.Point(746, 0);
            this.minimizeControlBox.Name = "minimizeControlBox";
            this.minimizeControlBox.Size = new System.Drawing.Size(45, 29);
            this.minimizeControlBox.TabIndex = 5;
            // 
            // topWindowPanel
            // 
            this.topWindowPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(46)))), ((int)(((byte)(46)))));
            this.topWindowPanel.Controls.Add(this.windowName);
            this.topWindowPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.topWindowPanel.Location = new System.Drawing.Point(0, 0);
            this.topWindowPanel.Name = "topWindowPanel";
            this.topWindowPanel.Size = new System.Drawing.Size(836, 29);
            this.topWindowPanel.TabIndex = 6;
            // 
            // windowName
            // 
            this.windowName.AutoSize = true;
            this.windowName.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.windowName.ForeColor = System.Drawing.SystemColors.Control;
            this.windowName.Location = new System.Drawing.Point(1, 6);
            this.windowName.Name = "windowName";
            this.windowName.Size = new System.Drawing.Size(218, 16);
            this.windowName.TabIndex = 8;
            this.windowName.Text = "Hospital Management - Secretary";
            // 
            // topWindowPanelDragControl
            // 
            this.topWindowPanelDragControl.DockIndicatorTransparencyValue = 0.6D;
            this.topWindowPanelDragControl.DragStartTransparencyValue = 1D;
            this.topWindowPanelDragControl.TargetControl = this.topWindowPanel;
            this.topWindowPanelDragControl.UseTransparentDrag = true;
            // 
            // leftPanel
            // 
            this.leftPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(46)))), ((int)(((byte)(46)))));
            this.leftPanel.Controls.Add(this.doctorButtonSubMenu);
            this.leftPanel.Controls.Add(this.doctorButton);
            this.leftPanel.Controls.Add(this.secretaryButtonSubMenu);
            this.leftPanel.Controls.Add(this.secretaryButton);
            this.leftPanel.Controls.Add(this.patientButtonSubMenu);
            this.leftPanel.Controls.Add(this.patientButton);
            this.leftPanel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(46)))), ((int)(((byte)(46)))));
            this.leftPanel.Location = new System.Drawing.Point(0, 29);
            this.leftPanel.Name = "leftPanel";
            this.leftPanel.Size = new System.Drawing.Size(219, 480);
            this.leftPanel.TabIndex = 7;
            // 
            // doctorButtonSubMenu
            // 
            this.doctorButtonSubMenu.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.doctorButtonSubMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.doctorButtonSubMenu.Controls.Add(this.deleteDoctorButton);
            this.doctorButtonSubMenu.Controls.Add(this.updateDoctorButton);
            this.doctorButtonSubMenu.Controls.Add(this.addNewDoctorButton);
            this.doctorButtonSubMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.doctorButtonSubMenu.Location = new System.Drawing.Point(0, 522);
            this.doctorButtonSubMenu.Name = "doctorButtonSubMenu";
            this.doctorButtonSubMenu.Size = new System.Drawing.Size(219, 135);
            this.doctorButtonSubMenu.TabIndex = 13;
            // 
            // deleteDoctorButton
            // 
            this.deleteDoctorButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.deleteDoctorButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.deleteDoctorButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.deleteDoctorButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.deleteDoctorButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.deleteDoctorButton.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.deleteDoctorButton.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.deleteDoctorButton.ForeColor = System.Drawing.Color.White;
            this.deleteDoctorButton.Location = new System.Drawing.Point(0, 90);
            this.deleteDoctorButton.Name = "deleteDoctorButton";
            this.deleteDoctorButton.Size = new System.Drawing.Size(219, 45);
            this.deleteDoctorButton.TabIndex = 2;
            this.deleteDoctorButton.Text = "Doktor Sil";
            this.deleteDoctorButton.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.deleteDoctorButton.TextOffset = new System.Drawing.Point(10, 0);
            // 
            // updateDoctorButton
            // 
            this.updateDoctorButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.updateDoctorButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.updateDoctorButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.updateDoctorButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.updateDoctorButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.updateDoctorButton.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.updateDoctorButton.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.updateDoctorButton.ForeColor = System.Drawing.Color.White;
            this.updateDoctorButton.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.updateDoctorButton.Location = new System.Drawing.Point(0, 45);
            this.updateDoctorButton.Name = "updateDoctorButton";
            this.updateDoctorButton.Size = new System.Drawing.Size(219, 45);
            this.updateDoctorButton.TabIndex = 1;
            this.updateDoctorButton.Text = "Doktor Güncelle";
            this.updateDoctorButton.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.updateDoctorButton.TextOffset = new System.Drawing.Point(10, 0);
            // 
            // addNewDoctorButton
            // 
            this.addNewDoctorButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.addNewDoctorButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.addNewDoctorButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.addNewDoctorButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.addNewDoctorButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.addNewDoctorButton.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.addNewDoctorButton.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.addNewDoctorButton.ForeColor = System.Drawing.Color.White;
            this.addNewDoctorButton.Location = new System.Drawing.Point(0, 0);
            this.addNewDoctorButton.Name = "addNewDoctorButton";
            this.addNewDoctorButton.Size = new System.Drawing.Size(219, 45);
            this.addNewDoctorButton.TabIndex = 0;
            this.addNewDoctorButton.Text = "Doktor Kayıt";
            this.addNewDoctorButton.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.addNewDoctorButton.TextOffset = new System.Drawing.Point(10, 0);
            this.addNewDoctorButton.Click += new System.EventHandler(this.addNewDoctorButton_Click);
            // 
            // doctorButton
            // 
            this.doctorButton.Animated = true;
            this.doctorButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.doctorButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.doctorButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.doctorButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.doctorButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.doctorButton.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(46)))), ((int)(((byte)(46)))));
            this.doctorButton.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold);
            this.doctorButton.ForeColor = System.Drawing.Color.White;
            this.doctorButton.Image = ((System.Drawing.Image)(resources.GetObject("doctorButton.Image")));
            this.doctorButton.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.doctorButton.ImageSize = new System.Drawing.Size(30, 30);
            this.doctorButton.Location = new System.Drawing.Point(0, 438);
            this.doctorButton.Name = "doctorButton";
            this.doctorButton.Size = new System.Drawing.Size(219, 84);
            this.doctorButton.TabIndex = 12;
            this.doctorButton.Text = "Doktor İşlemleri";
            this.doctorButton.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.doctorButton.Click += new System.EventHandler(this.doctorButton_Click);
            // 
            // secretaryButtonSubMenu
            // 
            this.secretaryButtonSubMenu.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.secretaryButtonSubMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.secretaryButtonSubMenu.Controls.Add(this.deleteSecretaryButton);
            this.secretaryButtonSubMenu.Controls.Add(this.updateSecretaryButton);
            this.secretaryButtonSubMenu.Controls.Add(this.addNewSecretaryButton);
            this.secretaryButtonSubMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.secretaryButtonSubMenu.Location = new System.Drawing.Point(0, 303);
            this.secretaryButtonSubMenu.Name = "secretaryButtonSubMenu";
            this.secretaryButtonSubMenu.Size = new System.Drawing.Size(219, 135);
            this.secretaryButtonSubMenu.TabIndex = 11;
            // 
            // deleteSecretaryButton
            // 
            this.deleteSecretaryButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.deleteSecretaryButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.deleteSecretaryButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.deleteSecretaryButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.deleteSecretaryButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.deleteSecretaryButton.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.deleteSecretaryButton.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.deleteSecretaryButton.ForeColor = System.Drawing.Color.White;
            this.deleteSecretaryButton.Location = new System.Drawing.Point(0, 90);
            this.deleteSecretaryButton.Name = "deleteSecretaryButton";
            this.deleteSecretaryButton.Size = new System.Drawing.Size(219, 45);
            this.deleteSecretaryButton.TabIndex = 2;
            this.deleteSecretaryButton.Text = "Sekreter Sil";
            this.deleteSecretaryButton.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.deleteSecretaryButton.TextOffset = new System.Drawing.Point(10, 0);
            // 
            // updateSecretaryButton
            // 
            this.updateSecretaryButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.updateSecretaryButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.updateSecretaryButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.updateSecretaryButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.updateSecretaryButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.updateSecretaryButton.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.updateSecretaryButton.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.updateSecretaryButton.ForeColor = System.Drawing.Color.White;
            this.updateSecretaryButton.Location = new System.Drawing.Point(0, 45);
            this.updateSecretaryButton.Name = "updateSecretaryButton";
            this.updateSecretaryButton.Size = new System.Drawing.Size(219, 45);
            this.updateSecretaryButton.TabIndex = 1;
            this.updateSecretaryButton.Text = "Sekreter Güncelle";
            this.updateSecretaryButton.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.updateSecretaryButton.TextOffset = new System.Drawing.Point(10, 0);
            // 
            // addNewSecretaryButton
            // 
            this.addNewSecretaryButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.addNewSecretaryButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.addNewSecretaryButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.addNewSecretaryButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.addNewSecretaryButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.addNewSecretaryButton.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.addNewSecretaryButton.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.addNewSecretaryButton.ForeColor = System.Drawing.Color.White;
            this.addNewSecretaryButton.Location = new System.Drawing.Point(0, 0);
            this.addNewSecretaryButton.Name = "addNewSecretaryButton";
            this.addNewSecretaryButton.Size = new System.Drawing.Size(219, 45);
            this.addNewSecretaryButton.TabIndex = 0;
            this.addNewSecretaryButton.Text = "Sekreter Kayıt";
            this.addNewSecretaryButton.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.addNewSecretaryButton.TextOffset = new System.Drawing.Point(10, 0);
            this.addNewSecretaryButton.Click += new System.EventHandler(this.addNewSecretaryButton_Click);
            // 
            // secretaryButton
            // 
            this.secretaryButton.Animated = true;
            this.secretaryButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.secretaryButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.secretaryButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.secretaryButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.secretaryButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.secretaryButton.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(46)))), ((int)(((byte)(46)))));
            this.secretaryButton.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold);
            this.secretaryButton.ForeColor = System.Drawing.Color.White;
            this.secretaryButton.Image = ((System.Drawing.Image)(resources.GetObject("secretaryButton.Image")));
            this.secretaryButton.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.secretaryButton.ImageSize = new System.Drawing.Size(30, 30);
            this.secretaryButton.Location = new System.Drawing.Point(0, 219);
            this.secretaryButton.Name = "secretaryButton";
            this.secretaryButton.Size = new System.Drawing.Size(219, 84);
            this.secretaryButton.TabIndex = 10;
            this.secretaryButton.Text = "Sekreter İşlemleri";
            this.secretaryButton.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.secretaryButton.Click += new System.EventHandler(this.secretaryButton_Click);
            // 
            // patientButtonSubMenu
            // 
            this.patientButtonSubMenu.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.patientButtonSubMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.patientButtonSubMenu.Controls.Add(this.patientGraphsButton);
            this.patientButtonSubMenu.Controls.Add(this.patientFeaturesButton);
            this.patientButtonSubMenu.Controls.Add(this.createAppointmentButton);
            this.patientButtonSubMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.patientButtonSubMenu.Location = new System.Drawing.Point(0, 84);
            this.patientButtonSubMenu.Name = "patientButtonSubMenu";
            this.patientButtonSubMenu.Size = new System.Drawing.Size(219, 135);
            this.patientButtonSubMenu.TabIndex = 9;
            // 
            // patientGraphsButton
            // 
            this.patientGraphsButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.patientGraphsButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.patientGraphsButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.patientGraphsButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.patientGraphsButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.patientGraphsButton.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.patientGraphsButton.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.patientGraphsButton.ForeColor = System.Drawing.Color.White;
            this.patientGraphsButton.Location = new System.Drawing.Point(0, 90);
            this.patientGraphsButton.Name = "patientGraphsButton";
            this.patientGraphsButton.Size = new System.Drawing.Size(219, 45);
            this.patientGraphsButton.TabIndex = 2;
            this.patientGraphsButton.Text = "Hasta Grafikleri";
            this.patientGraphsButton.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.patientGraphsButton.TextOffset = new System.Drawing.Point(10, 0);
            this.patientGraphsButton.Click += new System.EventHandler(this.patientGraphsButton_Click);
            // 
            // patientFeaturesButton
            // 
            this.patientFeaturesButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.patientFeaturesButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.patientFeaturesButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.patientFeaturesButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.patientFeaturesButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.patientFeaturesButton.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.patientFeaturesButton.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.patientFeaturesButton.ForeColor = System.Drawing.Color.White;
            this.patientFeaturesButton.Location = new System.Drawing.Point(0, 45);
            this.patientFeaturesButton.Name = "patientFeaturesButton";
            this.patientFeaturesButton.Size = new System.Drawing.Size(219, 45);
            this.patientFeaturesButton.TabIndex = 1;
            this.patientFeaturesButton.Text = "Hasta (Ekle - Sil - Güncelle)";
            this.patientFeaturesButton.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.patientFeaturesButton.TextOffset = new System.Drawing.Point(10, 0);
            this.patientFeaturesButton.Click += new System.EventHandler(this.patientFeaturesButton_Click);
            // 
            // createAppointmentButton
            // 
            this.createAppointmentButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.createAppointmentButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.createAppointmentButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.createAppointmentButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.createAppointmentButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.createAppointmentButton.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.createAppointmentButton.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.createAppointmentButton.ForeColor = System.Drawing.Color.White;
            this.createAppointmentButton.Location = new System.Drawing.Point(0, 0);
            this.createAppointmentButton.Name = "createAppointmentButton";
            this.createAppointmentButton.Size = new System.Drawing.Size(219, 45);
            this.createAppointmentButton.TabIndex = 0;
            this.createAppointmentButton.Text = "Randevu Oluştur";
            this.createAppointmentButton.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.createAppointmentButton.TextOffset = new System.Drawing.Point(10, 0);
            this.createAppointmentButton.Click += new System.EventHandler(this.createAppointmentButton_Click);
            // 
            // patientButton
            // 
            this.patientButton.Animated = true;
            this.patientButton.BackColor = System.Drawing.Color.Yellow;
            this.patientButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.patientButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.patientButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.patientButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.patientButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.patientButton.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(46)))), ((int)(((byte)(46)))));
            this.patientButton.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.patientButton.ForeColor = System.Drawing.Color.White;
            this.patientButton.Image = ((System.Drawing.Image)(resources.GetObject("patientButton.Image")));
            this.patientButton.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.patientButton.ImageSize = new System.Drawing.Size(30, 30);
            this.patientButton.Location = new System.Drawing.Point(0, 0);
            this.patientButton.Name = "patientButton";
            this.patientButton.Size = new System.Drawing.Size(219, 84);
            this.patientButton.TabIndex = 8;
            this.patientButton.Text = "Hasta İşlemleri";
            this.patientButton.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.patientButton.Click += new System.EventHandler(this.patientButton_Click);
            // 
            // windowNameDragControl
            // 
            this.windowNameDragControl.DockIndicatorTransparencyValue = 0.6D;
            this.windowNameDragControl.DragStartTransparencyValue = 1D;
            this.windowNameDragControl.TargetControl = this.windowName;
            this.windowNameDragControl.UseTransparentDrag = true;
            // 
            // containerPanel
            // 
            this.containerPanel.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.containerPanel.Location = new System.Drawing.Point(219, 29);
            this.containerPanel.Name = "containerPanel";
            this.containerPanel.Size = new System.Drawing.Size(617, 387);
            this.containerPanel.TabIndex = 8;
            // 
            // SecretaryLayer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(836, 416);
            this.Controls.Add(this.containerPanel);
            this.Controls.Add(this.minimizeControlBox);
            this.Controls.Add(this.exitControlBox);
            this.Controls.Add(this.topWindowPanel);
            this.Controls.Add(this.leftPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "SecretaryLayer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "SecretaryLayer";
            this.Load += new System.EventHandler(this.SecretaryLayer_Load);
            this.topWindowPanel.ResumeLayout(false);
            this.topWindowPanel.PerformLayout();
            this.leftPanel.ResumeLayout(false);
            this.doctorButtonSubMenu.ResumeLayout(false);
            this.secretaryButtonSubMenu.ResumeLayout(false);
            this.patientButtonSubMenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private Guna.UI2.WinForms.Guna2ControlBox exitControlBox;
        private Guna.UI2.WinForms.Guna2ControlBox minimizeControlBox;
        private Guna.UI2.WinForms.Guna2Panel topWindowPanel;
        private Guna.UI2.WinForms.Guna2DragControl topWindowPanelDragControl;
        private Guna.UI2.WinForms.Guna2Panel leftPanel;
        private Guna.UI2.WinForms.Guna2Button patientButton;
        private Guna.UI2.WinForms.Guna2Panel patientButtonSubMenu;
        private Guna.UI2.WinForms.Guna2Button patientGraphsButton;
        private Guna.UI2.WinForms.Guna2Button patientFeaturesButton;
        private Guna.UI2.WinForms.Guna2Button createAppointmentButton;
        private Guna.UI2.WinForms.Guna2Panel doctorButtonSubMenu;
        private Guna.UI2.WinForms.Guna2Button deleteDoctorButton;
        private Guna.UI2.WinForms.Guna2Button updateDoctorButton;
        private Guna.UI2.WinForms.Guna2Button addNewDoctorButton;
        private Guna.UI2.WinForms.Guna2Button doctorButton;
        private Guna.UI2.WinForms.Guna2Panel secretaryButtonSubMenu;
        private Guna.UI2.WinForms.Guna2Button deleteSecretaryButton;
        private Guna.UI2.WinForms.Guna2Button updateSecretaryButton;
        private Guna.UI2.WinForms.Guna2Button addNewSecretaryButton;
        private Guna.UI2.WinForms.Guna2Button secretaryButton;
        private System.Windows.Forms.Label windowName;
        private Guna.UI2.WinForms.Guna2DragControl windowNameDragControl;
        private Guna.UI2.WinForms.Guna2Panel containerPanel;
    }
}