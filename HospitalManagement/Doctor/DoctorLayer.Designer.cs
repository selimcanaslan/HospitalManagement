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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.minimizeControlBox = new Guna.UI2.WinForms.Guna2ControlBox();
            this.exitControlBox = new Guna.UI2.WinForms.Guna2ControlBox();
            this.topWindowPanel = new Guna.UI2.WinForms.Guna2Panel();
            this.profilePicture = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.accountButton = new Guna.UI2.WinForms.Guna2GradientButton();
            this.windowName = new System.Windows.Forms.Label();
            this.topWindowPanelDragControl = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.windowNameDragControl = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
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
            this.panel1.Controls.Add(this.refreshDgvButton);
            this.panel1.Controls.Add(this.noAppointmentLabel);
            this.panel1.Controls.Add(this.dgvAwaitingAppointments);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(1, 30);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(834, 385);
            this.panel1.TabIndex = 10;
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
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(46)))), ((int)(((byte)(46)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(46)))), ((int)(((byte)(46)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvAwaitingAppointments.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvAwaitingAppointments.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAwaitingAppointments.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvAwaitingAppointments.EnableHeadersVisualStyles = false;
            this.dgvAwaitingAppointments.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(46)))), ((int)(((byte)(46)))));
            this.dgvAwaitingAppointments.Location = new System.Drawing.Point(0, 208);
            this.dgvAwaitingAppointments.MultiSelect = false;
            this.dgvAwaitingAppointments.Name = "dgvAwaitingAppointments";
            this.dgvAwaitingAppointments.ReadOnly = true;
            this.dgvAwaitingAppointments.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(46)))), ((int)(((byte)(46)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvAwaitingAppointments.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvAwaitingAppointments.RowHeadersVisible = false;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(46)))), ((int)(((byte)(46)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            this.dgvAwaitingAppointments.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvAwaitingAppointments.RowTemplate.Height = 25;
            this.dgvAwaitingAppointments.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvAwaitingAppointments.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAwaitingAppointments.Size = new System.Drawing.Size(834, 177);
            this.dgvAwaitingAppointments.TabIndex = 17;
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
    }
}