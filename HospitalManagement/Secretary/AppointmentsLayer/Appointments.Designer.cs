namespace HospitalManagement.Secretary.AppointmentsLayer
{
    partial class Appointments
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvAppointment = new System.Windows.Forms.DataGridView();
            this.dateTimePicker = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.tcNoTextBox = new Guna.UI2.WinForms.Guna2TextBox();
            this.fetchAppointments = new Guna.UI2.WinForms.Guna2Button();
            this.dateIncludeCheckBox = new Guna.UI2.WinForms.Guna2CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAppointment)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvAppointment
            // 
            this.dgvAppointment.AllowUserToAddRows = false;
            this.dgvAppointment.AllowUserToResizeColumns = false;
            this.dgvAppointment.AllowUserToResizeRows = false;
            this.dgvAppointment.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvAppointment.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvAppointment.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(46)))), ((int)(((byte)(46)))));
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(46)))), ((int)(((byte)(46)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(46)))), ((int)(((byte)(46)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvAppointment.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvAppointment.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAppointment.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvAppointment.EnableHeadersVisualStyles = false;
            this.dgvAppointment.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(46)))), ((int)(((byte)(46)))));
            this.dgvAppointment.Location = new System.Drawing.Point(0, 36);
            this.dgvAppointment.MultiSelect = false;
            this.dgvAppointment.Name = "dgvAppointment";
            this.dgvAppointment.ReadOnly = true;
            this.dgvAppointment.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(46)))), ((int)(((byte)(46)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvAppointment.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvAppointment.RowHeadersVisible = false;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(46)))), ((int)(((byte)(46)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            this.dgvAppointment.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvAppointment.RowTemplate.Height = 25;
            this.dgvAppointment.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvAppointment.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAppointment.Size = new System.Drawing.Size(617, 349);
            this.dgvAppointment.TabIndex = 13;
            this.dgvAppointment.Click += new System.EventHandler(this.dgvAppointment_Click);
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.BackColor = System.Drawing.Color.Transparent;
            this.dateTimePicker.Checked = true;
            this.dateTimePicker.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(46)))), ((int)(((byte)(46)))));
            this.dateTimePicker.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dateTimePicker.ForeColor = System.Drawing.Color.White;
            this.dateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.dateTimePicker.Location = new System.Drawing.Point(0, 0);
            this.dateTimePicker.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dateTimePicker.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(189, 36);
            this.dateTimePicker.TabIndex = 14;
            this.dateTimePicker.UseTransparentBackground = true;
            this.dateTimePicker.Value = new System.DateTime(2024, 5, 3, 10, 7, 59, 203);
            // 
            // tcNoTextBox
            // 
            this.tcNoTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tcNoTextBox.DefaultText = "";
            this.tcNoTextBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tcNoTextBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tcNoTextBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tcNoTextBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tcNoTextBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tcNoTextBox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.tcNoTextBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tcNoTextBox.Location = new System.Drawing.Point(287, 0);
            this.tcNoTextBox.Name = "tcNoTextBox";
            this.tcNoTextBox.PasswordChar = '\0';
            this.tcNoTextBox.PlaceholderText = "TCNO";
            this.tcNoTextBox.SelectedText = "";
            this.tcNoTextBox.Size = new System.Drawing.Size(210, 36);
            this.tcNoTextBox.TabIndex = 15;
            // 
            // fetchAppointments
            // 
            this.fetchAppointments.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.fetchAppointments.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.fetchAppointments.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.fetchAppointments.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.fetchAppointments.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.fetchAppointments.ForeColor = System.Drawing.Color.White;
            this.fetchAppointments.Location = new System.Drawing.Point(497, 0);
            this.fetchAppointments.Name = "fetchAppointments";
            this.fetchAppointments.Size = new System.Drawing.Size(120, 36);
            this.fetchAppointments.TabIndex = 16;
            this.fetchAppointments.Text = "Randevuları Getir";
            this.fetchAppointments.Click += new System.EventHandler(this.fetchAppointments_Click);
            // 
            // dateIncludeCheckBox
            // 
            this.dateIncludeCheckBox.Animated = true;
            this.dateIncludeCheckBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(136)))), ((int)(((byte)(77)))));
            this.dateIncludeCheckBox.Checked = true;
            this.dateIncludeCheckBox.CheckedState.BorderColor = System.Drawing.Color.Green;
            this.dateIncludeCheckBox.CheckedState.BorderRadius = 0;
            this.dateIncludeCheckBox.CheckedState.BorderThickness = 0;
            this.dateIncludeCheckBox.CheckedState.FillColor = System.Drawing.Color.Green;
            this.dateIncludeCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.dateIncludeCheckBox.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateIncludeCheckBox.ForeColor = System.Drawing.Color.White;
            this.dateIncludeCheckBox.Location = new System.Drawing.Point(186, 0);
            this.dateIncludeCheckBox.Name = "dateIncludeCheckBox";
            this.dateIncludeCheckBox.Size = new System.Drawing.Size(103, 36);
            this.dateIncludeCheckBox.TabIndex = 17;
            this.dateIncludeCheckBox.Text = "Tarih\'e Göre";
            this.dateIncludeCheckBox.UncheckedState.BorderColor = System.Drawing.Color.Red;
            this.dateIncludeCheckBox.UncheckedState.BorderRadius = 0;
            this.dateIncludeCheckBox.UncheckedState.BorderThickness = 0;
            this.dateIncludeCheckBox.UncheckedState.FillColor = System.Drawing.Color.Red;
            this.dateIncludeCheckBox.UseVisualStyleBackColor = false;
            // 
            // Appointments
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(617, 385);
            this.Controls.Add(this.dateIncludeCheckBox);
            this.Controls.Add(this.fetchAppointments);
            this.Controls.Add(this.tcNoTextBox);
            this.Controls.Add(this.dateTimePicker);
            this.Controls.Add(this.dgvAppointment);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Appointments";
            this.Text = "v";
            ((System.ComponentModel.ISupportInitialize)(this.dgvAppointment)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvAppointment;
        private Guna.UI2.WinForms.Guna2DateTimePicker dateTimePicker;
        private Guna.UI2.WinForms.Guna2TextBox tcNoTextBox;
        private Guna.UI2.WinForms.Guna2Button fetchAppointments;
        private Guna.UI2.WinForms.Guna2CheckBox dateIncludeCheckBox;
    }
}