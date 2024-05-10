namespace HospitalManagement.Doctor
{
    partial class DoctorLayer
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.minimizeControlBox = new Guna.UI2.WinForms.Guna2ControlBox();
            this.exitControlBox = new Guna.UI2.WinForms.Guna2ControlBox();
            this.topWindowPanel = new Guna.UI2.WinForms.Guna2Panel();
            this.profilePicture = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.accountButton = new Guna.UI2.WinForms.Guna2GradientButton();
            this.windowName = new System.Windows.Forms.Label();
            this.topWindowPanelDragControl = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.windowNameDragControl = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.sendAppointmentDetailsToPatientViaMail = new Guna.UI2.WinForms.Guna2Button();
            this.exportPdfButton = new Guna.UI2.WinForms.Guna2Button();
            this.label2 = new System.Windows.Forms.Label();
            this.guna2TextBox2 = new Guna.UI2.WinForms.Guna2TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.addressTextBox = new System.Windows.Forms.RichTextBox();
            this.guna2TextBox1 = new Guna.UI2.WinForms.Guna2TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.nameLabel = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.phoneTextBox = new Guna.UI2.WinForms.Guna2TextBox();
            this.nameTextBox = new Guna.UI2.WinForms.Guna2TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tcnoTextBox = new Guna.UI2.WinForms.Guna2TextBox();
            this.mailTextBox = new Guna.UI2.WinForms.Guna2TextBox();
            this.surnameTextBox = new Guna.UI2.WinForms.Guna2TextBox();
            this.refreshDgvButton = new Guna.UI2.WinForms.Guna2Button();
            this.noAppointmentLabel = new System.Windows.Forms.Label();
            this.dgvAwaitingAppointments = new System.Windows.Forms.DataGridView();
            this.topWindowPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.profilePicture)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAwaitingAppointments)).BeginInit();
            this.SuspendLayout();
            // 
            // minimizeControlBox
            // 
            this.minimizeControlBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.minimizeControlBox.ControlBoxType = Guna.UI2.WinForms.Enums.ControlBoxType.MinimizeBox;
            this.minimizeControlBox.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(46)))), ((int)(((byte)(46)))));
            this.minimizeControlBox.IconColor = System.Drawing.Color.White;
            this.minimizeControlBox.Location = new System.Drawing.Point(753, 1);
            this.minimizeControlBox.Name = "minimizeControlBox";
            this.minimizeControlBox.Size = new System.Drawing.Size(40, 27);
            this.minimizeControlBox.TabIndex = 8;
            // 
            // exitControlBox
            // 
            this.exitControlBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.exitControlBox.Animated = true;
            this.exitControlBox.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(46)))), ((int)(((byte)(46)))));
            this.exitControlBox.HoverState.FillColor = System.Drawing.Color.Red;
            this.exitControlBox.HoverState.IconColor = System.Drawing.Color.White;
            this.exitControlBox.IconColor = System.Drawing.Color.White;
            this.exitControlBox.Location = new System.Drawing.Point(793, 1);
            this.exitControlBox.Name = "exitControlBox";
            this.exitControlBox.Size = new System.Drawing.Size(40, 27);
            this.exitControlBox.TabIndex = 7;
            // 
            // topWindowPanel
            // 
            this.topWindowPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(46)))), ((int)(((byte)(46)))));
            this.topWindowPanel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.topWindowPanel.Controls.Add(this.minimizeControlBox);
            this.topWindowPanel.Controls.Add(this.profilePicture);
            this.topWindowPanel.Controls.Add(this.exitControlBox);
            this.topWindowPanel.Controls.Add(this.accountButton);
            this.topWindowPanel.Controls.Add(this.windowName);
            this.topWindowPanel.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.topWindowPanel.CustomBorderThickness = new System.Windows.Forms.Padding(0, 0, 0, 1);
            this.topWindowPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.topWindowPanel.Location = new System.Drawing.Point(1, 1);
            this.topWindowPanel.Name = "topWindowPanel";
            this.topWindowPanel.ShadowDecoration.BorderRadius = 30;
            this.topWindowPanel.Size = new System.Drawing.Size(834, 29);
            this.topWindowPanel.TabIndex = 9;
            // 
            // profilePicture
            // 
            this.profilePicture.Cursor = System.Windows.Forms.Cursors.Hand;
            this.profilePicture.ImageRotate = 0F;
            this.profilePicture.InitialImage = global::HospitalManagement.Properties.Resources.ppholder;
            this.profilePicture.Location = new System.Drawing.Point(710, 2);
            this.profilePicture.Name = "profilePicture";
            this.profilePicture.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.profilePicture.Size = new System.Drawing.Size(25, 25);
            this.profilePicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.profilePicture.TabIndex = 0;
            this.profilePicture.TabStop = false;
            this.profilePicture.WaitOnLoad = true;
            // 
            // accountButton
            // 
            this.accountButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.accountButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.accountButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.accountButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.accountButton.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.accountButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.accountButton.FillColor = System.Drawing.Color.Orange;
            this.accountButton.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(46)))), ((int)(((byte)(46)))));
            this.accountButton.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.accountButton.ForeColor = System.Drawing.Color.White;
            this.accountButton.HoverState.FillColor = System.Drawing.Color.Red;
            this.accountButton.HoverState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(46)))), ((int)(((byte)(46)))));
            this.accountButton.Location = new System.Drawing.Point(615, 4);
            this.accountButton.Name = "accountButton";
            this.accountButton.Size = new System.Drawing.Size(112, 20);
            this.accountButton.TabIndex = 9;
            this.accountButton.Text = "Hesap İşlemleri";
            this.accountButton.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.accountButton.Click += new System.EventHandler(this.accountButton_Click);
            // 
            // windowName
            // 
            this.windowName.AutoSize = true;
            this.windowName.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.windowName.ForeColor = System.Drawing.SystemColors.Control;
            this.windowName.Location = new System.Drawing.Point(1, 6);
            this.windowName.Name = "windowName";
            this.windowName.Size = new System.Drawing.Size(190, 17);
            this.windowName.TabIndex = 8;
            this.windowName.Text = "Hospital Management - Doctor";
            // 
            // topWindowPanelDragControl
            // 
            this.topWindowPanelDragControl.DockIndicatorTransparencyValue = 0.6D;
            this.topWindowPanelDragControl.DragStartTransparencyValue = 1D;
            this.topWindowPanelDragControl.TargetControl = this.topWindowPanel;
            this.topWindowPanelDragControl.UseTransparentDrag = true;
            // 
            // windowNameDragControl
            // 
            this.windowNameDragControl.DockIndicatorTransparencyValue = 0.6D;
            this.windowNameDragControl.DragStartTransparencyValue = 1D;
            this.windowNameDragControl.TargetControl = this.windowName;
            this.windowNameDragControl.UseTransparentDrag = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.panel1.Controls.Add(this.sendAppointmentDetailsToPatientViaMail);
            this.panel1.Controls.Add(this.exportPdfButton);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.guna2TextBox2);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.addressTextBox);
            this.panel1.Controls.Add(this.guna2TextBox1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.nameLabel);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.phoneTextBox);
            this.panel1.Controls.Add(this.nameTextBox);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.tcnoTextBox);
            this.panel1.Controls.Add(this.mailTextBox);
            this.panel1.Controls.Add(this.surnameTextBox);
            this.panel1.Controls.Add(this.refreshDgvButton);
            this.panel1.Controls.Add(this.noAppointmentLabel);
            this.panel1.Controls.Add(this.dgvAwaitingAppointments);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(1, 30);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(834, 385);
            this.panel1.TabIndex = 10;
            // 
            // sendAppointmentDetailsToPatientViaMail
            // 
            this.sendAppointmentDetailsToPatientViaMail.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.sendAppointmentDetailsToPatientViaMail.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.sendAppointmentDetailsToPatientViaMail.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.sendAppointmentDetailsToPatientViaMail.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.sendAppointmentDetailsToPatientViaMail.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(46)))), ((int)(((byte)(46)))));
            this.sendAppointmentDetailsToPatientViaMail.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.sendAppointmentDetailsToPatientViaMail.ForeColor = System.Drawing.Color.White;
            this.sendAppointmentDetailsToPatientViaMail.Location = new System.Drawing.Point(474, 160);
            this.sendAppointmentDetailsToPatientViaMail.Name = "sendAppointmentDetailsToPatientViaMail";
            this.sendAppointmentDetailsToPatientViaMail.Size = new System.Drawing.Size(150, 45);
            this.sendAppointmentDetailsToPatientViaMail.TabIndex = 112;
            this.sendAppointmentDetailsToPatientViaMail.Text = "Görüşmeyi Hastaya Gönder";
            this.sendAppointmentDetailsToPatientViaMail.Click += new System.EventHandler(this.sendAppointmentDetailsToPatientViaMail_Click);
            // 
            // exportPdfButton
            // 
            this.exportPdfButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.exportPdfButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.exportPdfButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.exportPdfButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.exportPdfButton.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(46)))), ((int)(((byte)(46)))));
            this.exportPdfButton.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.exportPdfButton.ForeColor = System.Drawing.Color.White;
            this.exportPdfButton.Location = new System.Drawing.Point(318, 160);
            this.exportPdfButton.Name = "exportPdfButton";
            this.exportPdfButton.Size = new System.Drawing.Size(150, 45);
            this.exportPdfButton.TabIndex = 111;
            this.exportPdfButton.Text = "Görüşmeyi PDF\'e Aktar";
            this.exportPdfButton.Click += new System.EventHandler(this.exportPdfButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(641, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 16);
            this.label2.TabIndex = 110;
            this.label2.Text = "Tahlil Sonuçları";
            // 
            // guna2TextBox2
            // 
            this.guna2TextBox2.Animated = true;
            this.guna2TextBox2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(46)))), ((int)(((byte)(46)))));
            this.guna2TextBox2.BorderRadius = 2;
            this.guna2TextBox2.BorderThickness = 2;
            this.guna2TextBox2.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.guna2TextBox2.DefaultText = "";
            this.guna2TextBox2.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.guna2TextBox2.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.guna2TextBox2.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2TextBox2.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2TextBox2.FillColor = System.Drawing.SystemColors.AppWorkspace;
            this.guna2TextBox2.FocusedState.BorderColor = System.Drawing.Color.Red;
            this.guna2TextBox2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2TextBox2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(1)))), ((int)(((byte)(1)))));
            this.guna2TextBox2.HoverState.BorderColor = System.Drawing.Color.Red;
            this.guna2TextBox2.Location = new System.Drawing.Point(631, 17);
            this.guna2TextBox2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.guna2TextBox2.Multiline = true;
            this.guna2TextBox2.Name = "guna2TextBox2";
            this.guna2TextBox2.PasswordChar = '\0';
            this.guna2TextBox2.PlaceholderText = "";
            this.guna2TextBox2.ReadOnly = true;
            this.guna2TextBox2.SelectedText = "";
            this.guna2TextBox2.Size = new System.Drawing.Size(199, 188);
            this.guna2TextBox2.TabIndex = 109;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(326, 61);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(41, 16);
            this.label10.TabIndex = 106;
            this.label10.Text = "Adres";
            // 
            // addressTextBox
            // 
            this.addressTextBox.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.addressTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.addressTextBox.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addressTextBox.Location = new System.Drawing.Point(321, 77);
            this.addressTextBox.Name = "addressTextBox";
            this.addressTextBox.ReadOnly = true;
            this.addressTextBox.Size = new System.Drawing.Size(300, 75);
            this.addressTextBox.TabIndex = 107;
            this.addressTextBox.Text = "";
            // 
            // guna2TextBox1
            // 
            this.guna2TextBox1.Animated = true;
            this.guna2TextBox1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(46)))), ((int)(((byte)(46)))));
            this.guna2TextBox1.BorderRadius = 2;
            this.guna2TextBox1.BorderThickness = 2;
            this.guna2TextBox1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.guna2TextBox1.DefaultText = "";
            this.guna2TextBox1.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.guna2TextBox1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.guna2TextBox1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2TextBox1.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2TextBox1.FillColor = System.Drawing.SystemColors.AppWorkspace;
            this.guna2TextBox1.FocusedState.BorderColor = System.Drawing.Color.Red;
            this.guna2TextBox1.Font = new System.Drawing.Font("Cambria", 14.25F);
            this.guna2TextBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(1)))), ((int)(((byte)(1)))));
            this.guna2TextBox1.HoverState.BorderColor = System.Drawing.Color.Red;
            this.guna2TextBox1.Location = new System.Drawing.Point(318, 69);
            this.guna2TextBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.guna2TextBox1.Name = "guna2TextBox1";
            this.guna2TextBox1.PasswordChar = '\0';
            this.guna2TextBox1.PlaceholderText = "";
            this.guna2TextBox1.SelectedText = "";
            this.guna2TextBox1.Size = new System.Drawing.Size(306, 87);
            this.guna2TextBox1.TabIndex = 108;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 109);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 16);
            this.label1.TabIndex = 105;
            this.label1.Text = "T.C No";
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameLabel.Location = new System.Drawing.Point(12, 8);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(23, 16);
            this.nameLabel.TabIndex = 101;
            this.nameLabel.Text = "Ad";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(326, 9);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(47, 16);
            this.label9.TabIndex = 104;
            this.label9.Text = "Telefon";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(12, 158);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(31, 16);
            this.label8.TabIndex = 103;
            this.label8.Text = "Mail";
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
            this.phoneTextBox.Location = new System.Drawing.Point(318, 17);
            this.phoneTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.phoneTextBox.Name = "phoneTextBox";
            this.phoneTextBox.PasswordChar = '\0';
            this.phoneTextBox.PlaceholderText = "";
            this.phoneTextBox.ReadOnly = true;
            this.phoneTextBox.SelectedText = "";
            this.phoneTextBox.Size = new System.Drawing.Size(306, 40);
            this.phoneTextBox.TabIndex = 100;
            // 
            // nameTextBox
            // 
            this.nameTextBox.Animated = true;
            this.nameTextBox.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(46)))), ((int)(((byte)(46)))));
            this.nameTextBox.BorderRadius = 2;
            this.nameTextBox.BorderThickness = 2;
            this.nameTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.nameTextBox.DefaultText = "";
            this.nameTextBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(46)))), ((int)(((byte)(46)))));
            this.nameTextBox.DisabledState.FillColor = System.Drawing.SystemColors.AppWorkspace;
            this.nameTextBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(1)))), ((int)(((byte)(1)))));
            this.nameTextBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.nameTextBox.FillColor = System.Drawing.SystemColors.AppWorkspace;
            this.nameTextBox.FocusedState.BorderColor = System.Drawing.Color.Red;
            this.nameTextBox.Font = new System.Drawing.Font("Segoe UI", 14.25F);
            this.nameTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(1)))), ((int)(((byte)(1)))));
            this.nameTextBox.HoverState.BorderColor = System.Drawing.Color.Red;
            this.nameTextBox.Location = new System.Drawing.Point(4, 17);
            this.nameTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.PasswordChar = '\0';
            this.nameTextBox.PlaceholderText = "";
            this.nameTextBox.ReadOnly = true;
            this.nameTextBox.SelectedText = "";
            this.nameTextBox.Size = new System.Drawing.Size(306, 40);
            this.nameTextBox.TabIndex = 96;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(12, 58);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(44, 16);
            this.label7.TabIndex = 102;
            this.label7.Text = "Soyad";
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
            this.tcnoTextBox.Location = new System.Drawing.Point(4, 116);
            this.tcnoTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.tcnoTextBox.Name = "tcnoTextBox";
            this.tcnoTextBox.PasswordChar = '\0';
            this.tcnoTextBox.PlaceholderText = "";
            this.tcnoTextBox.ReadOnly = true;
            this.tcnoTextBox.SelectedText = "";
            this.tcnoTextBox.Size = new System.Drawing.Size(306, 40);
            this.tcnoTextBox.TabIndex = 98;
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
            this.mailTextBox.Location = new System.Drawing.Point(4, 165);
            this.mailTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.mailTextBox.Name = "mailTextBox";
            this.mailTextBox.PasswordChar = '\0';
            this.mailTextBox.PlaceholderText = "";
            this.mailTextBox.ReadOnly = true;
            this.mailTextBox.SelectedText = "";
            this.mailTextBox.Size = new System.Drawing.Size(306, 40);
            this.mailTextBox.TabIndex = 99;
            // 
            // surnameTextBox
            // 
            this.surnameTextBox.Animated = true;
            this.surnameTextBox.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(46)))), ((int)(((byte)(46)))));
            this.surnameTextBox.BorderRadius = 2;
            this.surnameTextBox.BorderThickness = 2;
            this.surnameTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
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
            this.surnameTextBox.Location = new System.Drawing.Point(4, 66);
            this.surnameTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.surnameTextBox.Name = "surnameTextBox";
            this.surnameTextBox.PasswordChar = '\0';
            this.surnameTextBox.PlaceholderText = "";
            this.surnameTextBox.ReadOnly = true;
            this.surnameTextBox.SelectedText = "";
            this.surnameTextBox.Size = new System.Drawing.Size(306, 40);
            this.surnameTextBox.TabIndex = 97;
            // 
            // refreshDgvButton
            // 
            this.refreshDgvButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.refreshDgvButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.refreshDgvButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.refreshDgvButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.refreshDgvButton.FillColor = System.Drawing.Color.Orange;
            this.refreshDgvButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.refreshDgvButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(46)))), ((int)(((byte)(46)))));
            this.refreshDgvButton.Location = new System.Drawing.Point(318, 305);
            this.refreshDgvButton.Name = "refreshDgvButton";
            this.refreshDgvButton.Size = new System.Drawing.Size(180, 45);
            this.refreshDgvButton.TabIndex = 19;
            this.refreshDgvButton.Text = "YENİLE";
            this.refreshDgvButton.Visible = false;
            this.refreshDgvButton.Click += new System.EventHandler(this.refreshDgvButton_Click);
            // 
            // noAppointmentLabel
            // 
            this.noAppointmentLabel.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.noAppointmentLabel.Location = new System.Drawing.Point(97, 260);
            this.noAppointmentLabel.Name = "noAppointmentLabel";
            this.noAppointmentLabel.Size = new System.Drawing.Size(638, 42);
            this.noAppointmentLabel.TabIndex = 18;
            this.noAppointmentLabel.Text = "BEKLEYEN RANDEVUNUZ BULUNMAMAKTADIR!";
            this.noAppointmentLabel.Visible = false;
            // 
            // dgvAwaitingAppointments
            // 
            this.dgvAwaitingAppointments.AllowUserToAddRows = false;
            this.dgvAwaitingAppointments.AllowUserToResizeColumns = false;
            this.dgvAwaitingAppointments.AllowUserToResizeRows = false;
            this.dgvAwaitingAppointments.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvAwaitingAppointments.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvAwaitingAppointments.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(46)))), ((int)(((byte)(46)))));
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(46)))), ((int)(((byte)(46)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(46)))), ((int)(((byte)(46)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvAwaitingAppointments.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvAwaitingAppointments.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAwaitingAppointments.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvAwaitingAppointments.EnableHeadersVisualStyles = false;
            this.dgvAwaitingAppointments.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(46)))), ((int)(((byte)(46)))));
            this.dgvAwaitingAppointments.Location = new System.Drawing.Point(0, 208);
            this.dgvAwaitingAppointments.MultiSelect = false;
            this.dgvAwaitingAppointments.Name = "dgvAwaitingAppointments";
            this.dgvAwaitingAppointments.ReadOnly = true;
            this.dgvAwaitingAppointments.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(46)))), ((int)(((byte)(46)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvAwaitingAppointments.RowHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvAwaitingAppointments.RowHeadersVisible = false;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(46)))), ((int)(((byte)(46)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.White;
            this.dgvAwaitingAppointments.RowsDefaultCellStyle = dataGridViewCellStyle6;
            this.dgvAwaitingAppointments.RowTemplate.Height = 25;
            this.dgvAwaitingAppointments.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvAwaitingAppointments.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAwaitingAppointments.Size = new System.Drawing.Size(834, 177);
            this.dgvAwaitingAppointments.TabIndex = 17;
            this.dgvAwaitingAppointments.Click += new System.EventHandler(this.dgvAwaitingAppointments_Click);
            // 
            // DoctorLayer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Orange;
            this.ClientSize = new System.Drawing.Size(836, 416);
            this.ControlBox = false;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.topWindowPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "DoctorLayer";
            this.Padding = new System.Windows.Forms.Padding(1);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "DoctorLayer";
            this.Load += new System.EventHandler(this.DoctorLayer_Load);
            this.topWindowPanel.ResumeLayout(false);
            this.topWindowPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.profilePicture)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAwaitingAppointments)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2ControlBox minimizeControlBox;
        private Guna.UI2.WinForms.Guna2ControlBox exitControlBox;
        private Guna.UI2.WinForms.Guna2Panel topWindowPanel;
        private Guna.UI2.WinForms.Guna2CirclePictureBox profilePicture;
        private Guna.UI2.WinForms.Guna2GradientButton accountButton;
        private System.Windows.Forms.Label windowName;
        private Guna.UI2.WinForms.Guna2DragControl topWindowPanelDragControl;
        private Guna.UI2.WinForms.Guna2DragControl windowNameDragControl;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dgvAwaitingAppointments;
        private System.Windows.Forms.Label noAppointmentLabel;
        private Guna.UI2.WinForms.Guna2Button refreshDgvButton;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.RichTextBox addressTextBox;
        private Guna.UI2.WinForms.Guna2TextBox guna2TextBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private Guna.UI2.WinForms.Guna2TextBox phoneTextBox;
        private Guna.UI2.WinForms.Guna2TextBox nameTextBox;
        private System.Windows.Forms.Label label7;
        private Guna.UI2.WinForms.Guna2TextBox tcnoTextBox;
        private Guna.UI2.WinForms.Guna2TextBox mailTextBox;
        private Guna.UI2.WinForms.Guna2TextBox surnameTextBox;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2TextBox guna2TextBox2;
        private Guna.UI2.WinForms.Guna2Button exportPdfButton;
        private Guna.UI2.WinForms.Guna2Button sendAppointmentDetailsToPatientViaMail;
    }
}