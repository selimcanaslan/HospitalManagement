namespace HospitalManagement.Secretary.PatientGraphsLayer
{
    partial class PatientGraphs
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
            this.zedGraphControl1 = new ZedGraph.ZedGraphControl();
            this.showGraph = new Guna.UI2.WinForms.Guna2Button();
            this.dataComboBox = new Guna.UI2.WinForms.Guna2ComboBox();
            this.SuspendLayout();
            // 
            // zedGraphControl1
            // 
            this.zedGraphControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.zedGraphControl1.Location = new System.Drawing.Point(0, 0);
            this.zedGraphControl1.Name = "zedGraphControl1";
            this.zedGraphControl1.ScrollGrace = 0D;
            this.zedGraphControl1.ScrollMaxX = 0D;
            this.zedGraphControl1.ScrollMaxY = 0D;
            this.zedGraphControl1.ScrollMaxY2 = 0D;
            this.zedGraphControl1.ScrollMinX = 0D;
            this.zedGraphControl1.ScrollMinY = 0D;
            this.zedGraphControl1.ScrollMinY2 = 0D;
            this.zedGraphControl1.Size = new System.Drawing.Size(617, 351);
            this.zedGraphControl1.TabIndex = 1;
            // 
            // showGraph
            // 
            this.showGraph.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.showGraph.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.showGraph.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.showGraph.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.showGraph.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.showGraph.ForeColor = System.Drawing.Color.White;
            this.showGraph.Location = new System.Drawing.Point(481, 351);
            this.showGraph.Name = "showGraph";
            this.showGraph.Size = new System.Drawing.Size(135, 36);
            this.showGraph.TabIndex = 2;
            this.showGraph.Text = "Göster";
            this.showGraph.Click += new System.EventHandler(this.showGraph_Click);
            // 
            // dataComboBox
            // 
            this.dataComboBox.BackColor = System.Drawing.Color.Transparent;
            this.dataComboBox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.dataComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.dataComboBox.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.dataComboBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.dataComboBox.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.dataComboBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.dataComboBox.ItemHeight = 30;
            this.dataComboBox.Location = new System.Drawing.Point(0, 350);
            this.dataComboBox.Name = "dataComboBox";
            this.dataComboBox.Size = new System.Drawing.Size(481, 36);
            this.dataComboBox.TabIndex = 3;
            // 
            // PatientGraphs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(617, 387);
            this.Controls.Add(this.dataComboBox);
            this.Controls.Add(this.showGraph);
            this.Controls.Add(this.zedGraphControl1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "PatientGraphs";
            this.Text = "PatientGraphs";
            this.Load += new System.EventHandler(this.PatientGraphs_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private ZedGraph.ZedGraphControl zedGraphControl1;
        private Guna.UI2.WinForms.Guna2Button showGraph;
        private Guna.UI2.WinForms.Guna2ComboBox dataComboBox;
    }
}