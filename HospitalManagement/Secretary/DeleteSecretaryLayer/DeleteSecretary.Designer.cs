namespace HospitalManagement.Secretary.DeleteSecretaryLayer
{
    partial class DeleteSecretary
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
            this.secretaryNameTextBox = new Guna.UI2.WinForms.Guna2TextBox();
            this.searchButton = new Guna.UI2.WinForms.Guna2Button();
            this.dgvSecretary = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSecretary)).BeginInit();
            this.SuspendLayout();
            // 
            // secretaryNameTextBox
            // 
            this.secretaryNameTextBox.BorderThickness = 0;
            this.secretaryNameTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.secretaryNameTextBox.DefaultText = "";
            this.secretaryNameTextBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.secretaryNameTextBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.secretaryNameTextBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.secretaryNameTextBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.secretaryNameTextBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.secretaryNameTextBox.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(46)))), ((int)(((byte)(46)))));
            this.secretaryNameTextBox.FocusedState.BorderColor = System.Drawing.Color.White;
            this.secretaryNameTextBox.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.secretaryNameTextBox.ForeColor = System.Drawing.Color.White;
            this.secretaryNameTextBox.HoverState.BorderColor = System.Drawing.Color.White;
            this.secretaryNameTextBox.Location = new System.Drawing.Point(0, 0);
            this.secretaryNameTextBox.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.secretaryNameTextBox.Name = "secretaryNameTextBox";
            this.secretaryNameTextBox.PasswordChar = '\0';
            this.secretaryNameTextBox.PlaceholderText = "";
            this.secretaryNameTextBox.SelectedText = "";
            this.secretaryNameTextBox.Size = new System.Drawing.Size(617, 45);
            this.secretaryNameTextBox.TabIndex = 0;
            // 
            // searchButton
            // 
            this.searchButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.searchButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.searchButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.searchButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.searchButton.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.searchButton.ForeColor = System.Drawing.Color.White;
            this.searchButton.Location = new System.Drawing.Point(518, 2);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(94, 41);
            this.searchButton.TabIndex = 3;
            this.searchButton.Text = "ARA";
            // 
            // dgvSecretary
            // 
            this.dgvSecretary.AllowUserToAddRows = false;
            this.dgvSecretary.AllowUserToResizeColumns = false;
            this.dgvSecretary.AllowUserToResizeRows = false;
            this.dgvSecretary.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvSecretary.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvSecretary.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSecretary.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvSecretary.Location = new System.Drawing.Point(0, 47);
            this.dgvSecretary.MultiSelect = false;
            this.dgvSecretary.Name = "dgvSecretary";
            this.dgvSecretary.Size = new System.Drawing.Size(617, 340);
            this.dgvSecretary.TabIndex = 6;
            this.dgvSecretary.Click += new System.EventHandler(this.dgvSecretary_CurrentCellChanged);
            // 
            // DeleteSecretary
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(617, 387);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.secretaryNameTextBox);
            this.Controls.Add(this.dgvSecretary);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "DeleteSecretary";
            this.Text = "DeleteSecretary";
            ((System.ComponentModel.ISupportInitialize)(this.dgvSecretary)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2TextBox secretaryNameTextBox;
        private Guna.UI2.WinForms.Guna2Button searchButton;
        private System.Windows.Forms.DataGridView dgvSecretary;
    }
}