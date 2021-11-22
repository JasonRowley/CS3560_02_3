
namespace GroupProjCS3560num2.Forms
{
    partial class AddTimestamp
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
            this.label1 = new System.Windows.Forms.Label();
            this.employeeComboBox = new System.Windows.Forms.ComboBox();
            this.clockOutTime = new System.Windows.Forms.DateTimePicker();
            this.clockOutDate = new System.Windows.Forms.DateTimePicker();
            this.clockInTime = new System.Windows.Forms.DateTimePicker();
            this.clockInDate = new System.Windows.Forms.DateTimePicker();
            this.confirmTimestamp = new System.Windows.Forms.Button();
            this.cancelTimestamp = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.warning = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Select employee: ";
            // 
            // employeeComboBox
            // 
            this.employeeComboBox.AllowDrop = true;
            this.employeeComboBox.BackColor = System.Drawing.Color.White;
            this.employeeComboBox.FormattingEnabled = true;
            this.employeeComboBox.Location = new System.Drawing.Point(12, 27);
            this.employeeComboBox.Name = "employeeComboBox";
            this.employeeComboBox.Size = new System.Drawing.Size(250, 23);
            this.employeeComboBox.TabIndex = 1;
            this.employeeComboBox.Text = "Employee...";
            this.employeeComboBox.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // clockOutTime
            // 
            this.clockOutTime.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.clockOutTime.Location = new System.Drawing.Point(292, 117);
            this.clockOutTime.Name = "clockOutTime";
            this.clockOutTime.ShowUpDown = true;
            this.clockOutTime.Size = new System.Drawing.Size(250, 23);
            this.clockOutTime.TabIndex = 28;
            this.clockOutTime.ValueChanged += new System.EventHandler(this.clockOutTime_ValueChanged);
            // 
            // clockOutDate
            // 
            this.clockOutDate.Location = new System.Drawing.Point(292, 88);
            this.clockOutDate.Name = "clockOutDate";
            this.clockOutDate.Size = new System.Drawing.Size(250, 23);
            this.clockOutDate.TabIndex = 27;
            this.clockOutDate.ValueChanged += new System.EventHandler(this.clockOutDate_ValueChanged);
            // 
            // clockInTime
            // 
            this.clockInTime.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.clockInTime.Location = new System.Drawing.Point(12, 117);
            this.clockInTime.Name = "clockInTime";
            this.clockInTime.ShowUpDown = true;
            this.clockInTime.Size = new System.Drawing.Size(250, 23);
            this.clockInTime.TabIndex = 26;
            this.clockInTime.ValueChanged += new System.EventHandler(this.clockInTime_ValueChanged);
            // 
            // clockInDate
            // 
            this.clockInDate.Location = new System.Drawing.Point(12, 88);
            this.clockInDate.Name = "clockInDate";
            this.clockInDate.Size = new System.Drawing.Size(250, 23);
            this.clockInDate.TabIndex = 25;
            this.clockInDate.Value = new System.DateTime(2021, 11, 15, 0, 43, 0, 0);
            this.clockInDate.ValueChanged += new System.EventHandler(this.clockInDate_ValueChanged);
            // 
            // confirmTimestamp
            // 
            this.confirmTimestamp.Location = new System.Drawing.Point(435, 181);
            this.confirmTimestamp.Name = "confirmTimestamp";
            this.confirmTimestamp.Size = new System.Drawing.Size(75, 23);
            this.confirmTimestamp.TabIndex = 24;
            this.confirmTimestamp.Text = "Confirm";
            this.confirmTimestamp.UseVisualStyleBackColor = true;
            this.confirmTimestamp.Click += new System.EventHandler(this.confirmTimestamp_Click);
            // 
            // cancelTimestamp
            // 
            this.cancelTimestamp.Location = new System.Drawing.Point(268, 181);
            this.cancelTimestamp.Name = "cancelTimestamp";
            this.cancelTimestamp.Size = new System.Drawing.Size(75, 23);
            this.cancelTimestamp.TabIndex = 23;
            this.cancelTimestamp.Text = "Cancel";
            this.cancelTimestamp.UseVisualStyleBackColor = true;
            this.cancelTimestamp.Click += new System.EventHandler(this.cancelTimestamp_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(292, 70);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(89, 15);
            this.label7.TabIndex = 21;
            this.label7.Text = "Clock Out Time";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(268, 105);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(18, 15);
            this.label6.TabIndex = 20;
            this.label6.Text = "to";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 70);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 15);
            this.label5.TabIndex = 19;
            this.label5.Text = "Clock In Time";
            // 
            // warning
            // 
            this.warning.AutoSize = true;
            this.warning.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.warning.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.warning.Location = new System.Drawing.Point(292, 143);
            this.warning.Name = "warning";
            this.warning.Size = new System.Drawing.Size(216, 15);
            this.warning.TabIndex = 29;
            this.warning.Text = "(!) Clock out time must be after clock in";
            this.warning.Click += new System.EventHandler(this.warning_Click);
            // 
            // AddTimestamp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.warning);
            this.Controls.Add(this.clockOutTime);
            this.Controls.Add(this.clockOutDate);
            this.Controls.Add(this.clockInTime);
            this.Controls.Add(this.clockInDate);
            this.Controls.Add(this.confirmTimestamp);
            this.Controls.Add(this.cancelTimestamp);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.employeeComboBox);
            this.Controls.Add(this.label1);
            this.Name = "AddTimestamp";
            this.Text = "New Timelog";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox employeeComboBox;
        private System.Windows.Forms.DateTimePicker clockOutTime;
        private System.Windows.Forms.DateTimePicker clockOutDate;
        private System.Windows.Forms.DateTimePicker clockInTime;
        private System.Windows.Forms.DateTimePicker clockInDate;
        private System.Windows.Forms.Button confirmTimestamp;
        private System.Windows.Forms.Button cancelTimestamp;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label warning;
    }
}