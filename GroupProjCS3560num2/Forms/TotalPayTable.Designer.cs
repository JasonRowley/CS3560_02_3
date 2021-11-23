
namespace GroupProjCS3560num2.Forms
{
    partial class TotalPayTable
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.listView1 = new System.Windows.Forms.ListView();
            this.warning = new System.Windows.Forms.Label();
            this.stopDate = new System.Windows.Forms.DateTimePicker();
            this.startDate = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 73);
            this.textBox1.Name = "textBox1";
            this.textBox1.PlaceholderText = "Search";
            this.textBox1.Size = new System.Drawing.Size(300, 23);
            this.textBox1.TabIndex = 15;
            // 
            // listView1
            // 
            this.listView1.Activation = System.Windows.Forms.ItemActivation.OneClick;
            this.listView1.AllowColumnReorder = true;
            this.listView1.FullRowSelect = true;
            this.listView1.HideSelection = false;
            this.listView1.HoverSelection = true;
            this.listView1.Location = new System.Drawing.Point(12, 102);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(530, 336);
            this.listView1.TabIndex = 12;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // warning
            // 
            this.warning.AutoSize = true;
            this.warning.ForeColor = System.Drawing.Color.Red;
            this.warning.Location = new System.Drawing.Point(292, 55);
            this.warning.Name = "warning";
            this.warning.Size = new System.Drawing.Size(217, 15);
            this.warning.TabIndex = 41;
            this.warning.Text = "* stop time must be later than start time";
            // 
            // stopDate
            // 
            this.stopDate.Location = new System.Drawing.Point(292, 27);
            this.stopDate.Name = "stopDate";
            this.stopDate.Size = new System.Drawing.Size(250, 23);
            this.stopDate.TabIndex = 40;
            this.stopDate.Value = new System.DateTime(2021, 11, 22, 0, 0, 0, 0);
            this.stopDate.ValueChanged += new System.EventHandler(this.stopDate_ValueChanged);
            // 
            // startDate
            // 
            this.startDate.Location = new System.Drawing.Point(12, 27);
            this.startDate.Name = "startDate";
            this.startDate.Size = new System.Drawing.Size(250, 23);
            this.startDate.TabIndex = 39;
            this.startDate.Value = new System.DateTime(2021, 11, 15, 0, 0, 0, 0);
            this.startDate.ValueChanged += new System.EventHandler(this.startDate_ValueChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(292, 9);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(47, 15);
            this.label7.TabIndex = 38;
            this.label7.Text = "Stop by";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 15);
            this.label5.TabIndex = 37;
            this.label5.Text = "Start by";
            // 
            // TotalPayTable
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(556, 450);
            this.Controls.Add(this.warning);
            this.Controls.Add(this.stopDate);
            this.Controls.Add(this.startDate);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.listView1);
            this.Name = "TotalPayTable";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Label warning;
        private System.Windows.Forms.DateTimePicker stopDate;
        private System.Windows.Forms.DateTimePicker startDate;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
    }
}