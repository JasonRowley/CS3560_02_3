
namespace GroupProjCS3560num2.Forms
{
    partial class TotalPay
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
            this.stopDate = new System.Windows.Forms.DateTimePicker();
            this.startDate = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.employeeComboBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.warning = new System.Windows.Forms.Label();
            this.confirmTimestamp = new System.Windows.Forms.Button();
            this.cancelTimestamp = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.totalP = new System.Windows.Forms.Label();
            this.totalH = new System.Windows.Forms.Label();
            this.hourlyRate = new System.Windows.Forms.Label();
            this.adj = new System.Windows.Forms.Label();
            this.basePay = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // stopDate
            // 
            this.stopDate.Location = new System.Drawing.Point(292, 88);
            this.stopDate.Name = "stopDate";
            this.stopDate.Size = new System.Drawing.Size(250, 23);
            this.stopDate.TabIndex = 33;
            this.stopDate.Value = new System.DateTime(2021, 11, 22, 0, 0, 0, 0);
            // 
            // startDate
            // 
            this.startDate.Location = new System.Drawing.Point(12, 88);
            this.startDate.Name = "startDate";
            this.startDate.Size = new System.Drawing.Size(250, 23);
            this.startDate.TabIndex = 32;
            this.startDate.Value = new System.DateTime(2021, 11, 15, 0, 0, 0, 0);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(292, 70);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(47, 15);
            this.label7.TabIndex = 31;
            this.label7.Text = "Stop by";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 70);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 15);
            this.label5.TabIndex = 30;
            this.label5.Text = "Start by";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // employeeComboBox
            // 
            this.employeeComboBox.AllowDrop = true;
            this.employeeComboBox.BackColor = System.Drawing.Color.White;
            this.employeeComboBox.FormattingEnabled = true;
            this.employeeComboBox.Location = new System.Drawing.Point(12, 27);
            this.employeeComboBox.Name = "employeeComboBox";
            this.employeeComboBox.Size = new System.Drawing.Size(250, 23);
            this.employeeComboBox.TabIndex = 29;
            this.employeeComboBox.Text = "Employee...";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 15);
            this.label1.TabIndex = 28;
            this.label1.Text = "Select employee: ";
            // 
            // warning
            // 
            this.warning.AutoSize = true;
            this.warning.ForeColor = System.Drawing.Color.Red;
            this.warning.Location = new System.Drawing.Point(292, 116);
            this.warning.Name = "warning";
            this.warning.Size = new System.Drawing.Size(217, 15);
            this.warning.TabIndex = 36;
            this.warning.Text = "* stop time must be later than start time";
            // 
            // confirmTimestamp
            // 
            this.confirmTimestamp.Location = new System.Drawing.Point(292, 150);
            this.confirmTimestamp.Name = "confirmTimestamp";
            this.confirmTimestamp.Size = new System.Drawing.Size(75, 23);
            this.confirmTimestamp.TabIndex = 35;
            this.confirmTimestamp.Text = "Confirm";
            this.confirmTimestamp.UseVisualStyleBackColor = true;
            this.confirmTimestamp.Click += new System.EventHandler(this.confirmTimestamp_Click);
            // 
            // cancelTimestamp
            // 
            this.cancelTimestamp.Location = new System.Drawing.Point(187, 150);
            this.cancelTimestamp.Name = "cancelTimestamp";
            this.cancelTimestamp.Size = new System.Drawing.Size(75, 23);
            this.cancelTimestamp.TabIndex = 34;
            this.cancelTimestamp.Text = "Cancel";
            this.cancelTimestamp.UseVisualStyleBackColor = true;
            this.cancelTimestamp.Click += new System.EventHandler(this.cancelTimestamp_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Silver;
            this.label2.Location = new System.Drawing.Point(15, 185);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 15);
            this.label2.TabIndex = 37;
            this.label2.Text = "Base Pay";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.label3.Location = new System.Drawing.Point(115, 185);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 15);
            this.label3.TabIndex = 38;
            this.label3.Text = "Adjustment";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.label4.Location = new System.Drawing.Point(215, 185);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 15);
            this.label4.TabIndex = 39;
            this.label4.Text = "Hourly Rate";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.label6.Location = new System.Drawing.Point(350, 185);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 15);
            this.label6.TabIndex = 40;
            this.label6.Text = "Total Hours";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.label8.Location = new System.Drawing.Point(450, 185);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(54, 15);
            this.label8.TabIndex = 41;
            this.label8.Text = "Total Pay";
            // 
            // totalP
            // 
            this.totalP.AutoSize = true;
            this.totalP.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.totalP.Location = new System.Drawing.Point(450, 200);
            this.totalP.Name = "totalP";
            this.totalP.Size = new System.Drawing.Size(31, 15);
            this.totalP.TabIndex = 46;
            this.totalP.Text = "$ ---";
            // 
            // totalH
            // 
            this.totalH.AutoSize = true;
            this.totalH.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.totalH.Location = new System.Drawing.Point(350, 200);
            this.totalH.Name = "totalH";
            this.totalH.Size = new System.Drawing.Size(43, 15);
            this.totalH.TabIndex = 45;
            this.totalH.Text = "--- Hrs";
            this.totalH.Click += new System.EventHandler(this.totalHrs_Click);
            // 
            // hourlyRate
            // 
            this.hourlyRate.AutoSize = true;
            this.hourlyRate.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.hourlyRate.Location = new System.Drawing.Point(215, 200);
            this.hourlyRate.Name = "hourlyRate";
            this.hourlyRate.Size = new System.Drawing.Size(43, 15);
            this.hourlyRate.TabIndex = 44;
            this.hourlyRate.Text = "--- Hrs";
            // 
            // adj
            // 
            this.adj.AutoSize = true;
            this.adj.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.adj.Location = new System.Drawing.Point(115, 200);
            this.adj.Name = "adj";
            this.adj.Size = new System.Drawing.Size(31, 15);
            this.adj.TabIndex = 43;
            this.adj.Text = "$ ---";
            // 
            // basePay
            // 
            this.basePay.AutoSize = true;
            this.basePay.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.basePay.Location = new System.Drawing.Point(15, 200);
            this.basePay.Name = "basePay";
            this.basePay.Size = new System.Drawing.Size(31, 15);
            this.basePay.TabIndex = 42;
            this.basePay.Text = "$ ---";
            // 
            // TotalPay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(554, 225);
            this.Controls.Add(this.totalP);
            this.Controls.Add(this.totalH);
            this.Controls.Add(this.hourlyRate);
            this.Controls.Add(this.adj);
            this.Controls.Add(this.basePay);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.warning);
            this.Controls.Add(this.confirmTimestamp);
            this.Controls.Add(this.cancelTimestamp);
            this.Controls.Add(this.stopDate);
            this.Controls.Add(this.startDate);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.employeeComboBox);
            this.Controls.Add(this.label1);
            this.Name = "TotalPay";
            this.Text = "Look Pay by Range";
            this.Load += new System.EventHandler(this.TotalPay_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker stopDate;
        private System.Windows.Forms.DateTimePicker startDate;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox employeeComboBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label warning;
        private System.Windows.Forms.Button confirmTimestamp;
        private System.Windows.Forms.Button cancelTimestamp;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label totalP;
        private System.Windows.Forms.Label totalH;
        private System.Windows.Forms.Label hourlyRate;
        private System.Windows.Forms.Label adj;
        private System.Windows.Forms.Label basePay;
    }
}