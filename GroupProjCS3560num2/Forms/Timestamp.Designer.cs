
namespace GroupProjCS3560num2.Forms
{
    partial class Timestamp
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
            this.empName = new System.Windows.Forms.Label();
            this.empID = new System.Windows.Forms.Label();
            this.empJob = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.deleteTimestamp = new System.Windows.Forms.Button();
            this.cancelTimestamp = new System.Windows.Forms.Button();
            this.confirmTimestamp = new System.Windows.Forms.Button();
            this.clockInDate = new System.Windows.Forms.DateTimePicker();
            this.clockInTime = new System.Windows.Forms.DateTimePicker();
            this.clockOutDate = new System.Windows.Forms.DateTimePicker();
            this.clockOutTime = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.timelogID = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.warning = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Employee info:";
            // 
            // empName
            // 
            this.empName.AutoSize = true;
            this.empName.Location = new System.Drawing.Point(33, 28);
            this.empName.Name = "empName";
            this.empName.Size = new System.Drawing.Size(91, 15);
            this.empName.TabIndex = 1;
            this.empName.Text = "employeeName";
            this.empName.Click += new System.EventHandler(this.label2_Click);
            // 
            // empID
            // 
            this.empID.AutoSize = true;
            this.empID.Location = new System.Drawing.Point(54, 43);
            this.empID.Name = "empID";
            this.empID.Size = new System.Drawing.Size(70, 15);
            this.empID.TabIndex = 2;
            this.empID.Text = "employeeID";
            this.empID.Click += new System.EventHandler(this.label3_Click);
            // 
            // empJob
            // 
            this.empJob.AutoSize = true;
            this.empJob.Location = new System.Drawing.Point(33, 58);
            this.empJob.Name = "empJob";
            this.empJob.Size = new System.Drawing.Size(77, 15);
            this.empJob.TabIndex = 3;
            this.empJob.Text = "employeeJob";
            this.empJob.Click += new System.EventHandler(this.empJob_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 119);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 15);
            this.label5.TabIndex = 4;
            this.label5.Text = "Clock In Time";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(269, 154);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(18, 15);
            this.label6.TabIndex = 6;
            this.label6.Text = "to";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(293, 119);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(89, 15);
            this.label7.TabIndex = 7;
            this.label7.Text = "Clock Out Time";
            // 
            // deleteTimestamp
            // 
            this.deleteTimestamp.BackColor = System.Drawing.Color.Red;
            this.deleteTimestamp.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.deleteTimestamp.Location = new System.Drawing.Point(13, 195);
            this.deleteTimestamp.Name = "deleteTimestamp";
            this.deleteTimestamp.Size = new System.Drawing.Size(111, 23);
            this.deleteTimestamp.TabIndex = 9;
            this.deleteTimestamp.Text = "Delete Timestamp";
            this.deleteTimestamp.UseVisualStyleBackColor = false;
            this.deleteTimestamp.Click += new System.EventHandler(this.deleteTimestamp_Click);
            // 
            // cancelTimestamp
            // 
            this.cancelTimestamp.Location = new System.Drawing.Point(269, 230);
            this.cancelTimestamp.Name = "cancelTimestamp";
            this.cancelTimestamp.Size = new System.Drawing.Size(75, 23);
            this.cancelTimestamp.TabIndex = 10;
            this.cancelTimestamp.Text = "Cancel";
            this.cancelTimestamp.UseVisualStyleBackColor = true;
            this.cancelTimestamp.Click += new System.EventHandler(this.cancelTimestamp_Click);
            // 
            // confirmTimestamp
            // 
            this.confirmTimestamp.Location = new System.Drawing.Point(436, 230);
            this.confirmTimestamp.Name = "confirmTimestamp";
            this.confirmTimestamp.Size = new System.Drawing.Size(75, 23);
            this.confirmTimestamp.TabIndex = 11;
            this.confirmTimestamp.Text = "Confirm";
            this.confirmTimestamp.UseVisualStyleBackColor = true;
            this.confirmTimestamp.Click += new System.EventHandler(this.confirmTimestamp_Click);
            // 
            // clockInDate
            // 
            this.clockInDate.Location = new System.Drawing.Point(13, 137);
            this.clockInDate.Name = "clockInDate";
            this.clockInDate.Size = new System.Drawing.Size(250, 23);
            this.clockInDate.TabIndex = 14;
            this.clockInDate.Value = new System.DateTime(2021, 11, 15, 0, 43, 0, 0);
            this.clockInDate.ValueChanged += new System.EventHandler(this.clockInDate_ValueChanged);
            // 
            // clockInTime
            // 
            this.clockInTime.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.clockInTime.Location = new System.Drawing.Point(13, 166);
            this.clockInTime.Name = "clockInTime";
            this.clockInTime.ShowUpDown = true;
            this.clockInTime.Size = new System.Drawing.Size(250, 23);
            this.clockInTime.TabIndex = 16;
            // 
            // clockOutDate
            // 
            this.clockOutDate.Location = new System.Drawing.Point(293, 137);
            this.clockOutDate.Name = "clockOutDate";
            this.clockOutDate.Size = new System.Drawing.Size(250, 23);
            this.clockOutDate.TabIndex = 17;
            // 
            // clockOutTime
            // 
            this.clockOutTime.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.clockOutTime.Location = new System.Drawing.Point(293, 166);
            this.clockOutTime.Name = "clockOutTime";
            this.clockOutTime.ShowUpDown = true;
            this.clockOutTime.Size = new System.Drawing.Size(250, 23);
            this.clockOutTime.TabIndex = 18;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 101);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 15);
            this.label2.TabIndex = 19;
            this.label2.Text = "TimestampID: ";
            // 
            // timelogID
            // 
            this.timelogID.AutoSize = true;
            this.timelogID.Location = new System.Drawing.Point(102, 101);
            this.timelogID.Name = "timelogID";
            this.timelogID.Size = new System.Drawing.Size(38, 15);
            this.timelogID.TabIndex = 20;
            this.timelogID.Text = "label3";
            this.timelogID.Click += new System.EventHandler(this.timestampID_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(33, 43);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(24, 15);
            this.label3.TabIndex = 21;
            this.label3.Text = "ID: ";
            // 
            // warning
            // 
            this.warning.AutoSize = true;
            this.warning.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.warning.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.warning.Location = new System.Drawing.Point(293, 199);
            this.warning.Name = "warning";
            this.warning.Size = new System.Drawing.Size(216, 15);
            this.warning.TabIndex = 22;
            this.warning.Text = "(!) Clock out time must be after clock in";
            this.warning.Click += new System.EventHandler(this.warning_Click);
            // 
            // Timestamp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.warning);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.timelogID);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.clockOutTime);
            this.Controls.Add(this.clockOutDate);
            this.Controls.Add(this.clockInTime);
            this.Controls.Add(this.clockInDate);
            this.Controls.Add(this.confirmTimestamp);
            this.Controls.Add(this.cancelTimestamp);
            this.Controls.Add(this.deleteTimestamp);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.empJob);
            this.Controls.Add(this.empID);
            this.Controls.Add(this.empName);
            this.Controls.Add(this.label1);
            this.Name = "Timestamp";
            this.Text = "Employee Timestamp";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label empName;
        private System.Windows.Forms.Label empID;
        private System.Windows.Forms.Label empJob;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button deleteTimestamp;
        private System.Windows.Forms.Button cancelTimestamp;
        private System.Windows.Forms.Button confirmTimestamp;
        private System.Windows.Forms.DateTimePicker clockInDate;
        private System.Windows.Forms.DateTimePicker clockInTime;
        private System.Windows.Forms.DateTimePicker clockOutDate;
        private System.Windows.Forms.DateTimePicker clockOutTime;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label timelogID;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label warning;
    }
}