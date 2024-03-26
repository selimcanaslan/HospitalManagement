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
            this.add_new_doctor_button = new System.Windows.Forms.Button();
            this.add_new_secretary_button = new System.Windows.Forms.Button();
            this.process1 = new System.Diagnostics.Process();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // add_new_doctor_button
            // 
            this.add_new_doctor_button.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.add_new_doctor_button.Location = new System.Drawing.Point(189, 108);
            this.add_new_doctor_button.Name = "add_new_doctor_button";
            this.add_new_doctor_button.Size = new System.Drawing.Size(120, 39);
            this.add_new_doctor_button.TabIndex = 0;
            this.add_new_doctor_button.Text = "Add Doctor";
            this.add_new_doctor_button.UseVisualStyleBackColor = true;
            this.add_new_doctor_button.Click += new System.EventHandler(this.add_new_doctor_button_Click);
            // 
            // add_new_secretary_button
            // 
            this.add_new_secretary_button.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.add_new_secretary_button.Location = new System.Drawing.Point(98, 88);
            this.add_new_secretary_button.Name = "add_new_secretary_button";
            this.add_new_secretary_button.Size = new System.Drawing.Size(118, 34);
            this.add_new_secretary_button.TabIndex = 1;
            this.add_new_secretary_button.Text = "Add Secretary";
            this.add_new_secretary_button.UseVisualStyleBackColor = true;
            this.add_new_secretary_button.Click += new System.EventHandler(this.add_new_secretary_button_Click);
            // 
            // process1
            // 
            this.process1.StartInfo.Domain = "";
            this.process1.StartInfo.LoadUserProfile = false;
            this.process1.StartInfo.Password = null;
            this.process1.StartInfo.StandardErrorEncoding = null;
            this.process1.StartInfo.StandardOutputEncoding = null;
            this.process1.StartInfo.UserName = "";
            this.process1.SynchronizingObject = this;
            // 
            // tabControl1
            // 
            this.tabControl1.Alignment = System.Windows.Forms.TabAlignment.Bottom;
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tabControl1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.Padding = new System.Drawing.Point(15, 5);
            this.tabControl1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(640, 360);
            this.tabControl1.TabIndex = 2;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.tabPage1.Controls.Add(this.add_new_secretary_button);
            this.tabPage1.Location = new System.Drawing.Point(4, 4);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(632, 324);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Hasta İşlemleri";
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.tabPage2.Controls.Add(this.add_new_doctor_button);
            this.tabPage2.Location = new System.Drawing.Point(4, 4);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(632, 324);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Doktor İşlemleri";
            // 
            // SecretaryLayer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(704, 393);
            this.Controls.Add(this.tabControl1);
            this.Name = "SecretaryLayer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "SecretaryLayer";
            this.Load += new System.EventHandler(this.SecretaryLayer_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button add_new_doctor_button;
        private System.Windows.Forms.Button add_new_secretary_button;
        private System.Diagnostics.Process process1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
    }
}