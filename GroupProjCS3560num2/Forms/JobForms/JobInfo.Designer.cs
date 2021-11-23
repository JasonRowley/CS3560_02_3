
namespace GroupProjCS3560num2.Forms
{
    partial class JobInfo
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
            this.basePayrateLabel = new System.Windows.Forms.Label();
            this.jobIDLabel = new System.Windows.Forms.Label();
            this.jobTitleLabel = new System.Windows.Forms.Label();
            this.jobIDBox = new System.Windows.Forms.TextBox();
            this.cancelButton = new System.Windows.Forms.Button();
            this.confirmButton = new System.Windows.Forms.Button();
            this.deleteButton = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // basePayrateLabel
            // 
            this.basePayrateLabel.AutoSize = true;
            this.basePayrateLabel.Location = new System.Drawing.Point(27, 145);
            this.basePayrateLabel.Name = "basePayrateLabel";
            this.basePayrateLabel.Size = new System.Drawing.Size(92, 20);
            this.basePayrateLabel.TabIndex = 2;
            this.basePayrateLabel.Text = "Base Payrate";
            // 
            // jobIDLabel
            // 
            this.jobIDLabel.AutoSize = true;
            this.jobIDLabel.Location = new System.Drawing.Point(27, 99);
            this.jobIDLabel.Name = "jobIDLabel";
            this.jobIDLabel.Size = new System.Drawing.Size(51, 20);
            this.jobIDLabel.TabIndex = 3;
            this.jobIDLabel.Text = "Job ID";
            // 
            // jobTitleLabel
            // 
            this.jobTitleLabel.AutoSize = true;
            this.jobTitleLabel.Location = new System.Drawing.Point(27, 48);
            this.jobTitleLabel.Name = "jobTitleLabel";
            this.jobTitleLabel.Size = new System.Drawing.Size(65, 20);
            this.jobTitleLabel.TabIndex = 4;
            this.jobTitleLabel.Text = "Job Title";
            // 
            // jobIDBox
            // 
            this.jobIDBox.Location = new System.Drawing.Point(122, 95);
            this.jobIDBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.jobIDBox.Name = "jobIDBox";
            this.jobIDBox.ReadOnly = true;
            this.jobIDBox.Size = new System.Drawing.Size(267, 27);
            this.jobIDBox.TabIndex = 10;
            this.jobIDBox.TextChanged += new System.EventHandler(this.jobIDBox_TextChanged);
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(82, 215);
            this.cancelButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(86, 31);
            this.cancelButton.TabIndex = 8;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // confirmButton
            // 
            this.confirmButton.Location = new System.Drawing.Point(174, 215);
            this.confirmButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.confirmButton.Name = "confirmButton";
            this.confirmButton.Size = new System.Drawing.Size(86, 31);
            this.confirmButton.TabIndex = 9;
            this.confirmButton.Text = "Confirm";
            this.confirmButton.UseVisualStyleBackColor = true;
            this.confirmButton.Click += new System.EventHandler(this.confirmButton_Click);
            // 
            // deleteButton
            // 
            this.deleteButton.BackColor = System.Drawing.Color.Red;
            this.deleteButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.deleteButton.Location = new System.Drawing.Point(266, 215);
            this.deleteButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(86, 31);
            this.deleteButton.TabIndex = 2;
            this.deleteButton.Text = "Delete";
            this.deleteButton.UseVisualStyleBackColor = false;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.Location = new System.Drawing.Point(122, 44);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(267, 28);
            this.comboBox1.TabIndex = 0;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(122, 141);
            this.textBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBox1.Name = "textBox1";
            this.textBox1.PlaceholderText = "0.0";
            this.textBox1.Size = new System.Drawing.Size(267, 27);
            this.textBox1.TabIndex = 11;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(16, 181);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(394, 20);
            this.label1.TabIndex = 12;
            this.label1.Text = "* Cannot delete job: there exists an employee with this job";
            this.label1.Visible = false;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // JobInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(433, 277);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.confirmButton);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.jobIDBox);
            this.Controls.Add(this.jobTitleLabel);
            this.Controls.Add(this.jobIDLabel);
            this.Controls.Add(this.basePayrateLabel);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "JobInfo";
            this.Text = "JobInfo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label basePayrateLabel;
        private System.Windows.Forms.Label jobIDLabel;
        private System.Windows.Forms.Label jobTitleLabel;
        private System.Windows.Forms.TextBox jobIDBox;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Button confirmButton;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
    }
}