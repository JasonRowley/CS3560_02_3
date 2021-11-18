﻿
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
            this.basePayrateBox = new System.Windows.Forms.MaskedTextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // basePayrateLabel
            // 
            this.basePayrateLabel.AutoSize = true;
            this.basePayrateLabel.Location = new System.Drawing.Point(24, 109);
            this.basePayrateLabel.Name = "basePayrateLabel";
            this.basePayrateLabel.Size = new System.Drawing.Size(73, 15);
            this.basePayrateLabel.TabIndex = 2;
            this.basePayrateLabel.Text = "Base Payrate";
            // 
            // jobIDLabel
            // 
            this.jobIDLabel.AutoSize = true;
            this.jobIDLabel.Location = new System.Drawing.Point(24, 74);
            this.jobIDLabel.Name = "jobIDLabel";
            this.jobIDLabel.Size = new System.Drawing.Size(39, 15);
            this.jobIDLabel.TabIndex = 3;
            this.jobIDLabel.Text = "Job ID";
            // 
            // jobTitleLabel
            // 
            this.jobTitleLabel.AutoSize = true;
            this.jobTitleLabel.Location = new System.Drawing.Point(24, 36);
            this.jobTitleLabel.Name = "jobTitleLabel";
            this.jobTitleLabel.Size = new System.Drawing.Size(50, 15);
            this.jobTitleLabel.TabIndex = 4;
            this.jobTitleLabel.Text = "Job Title";
            // 
            // jobIDBox
            // 
            this.jobIDBox.Location = new System.Drawing.Point(107, 71);
            this.jobIDBox.Name = "jobIDBox";
            this.jobIDBox.ReadOnly = true;
            this.jobIDBox.Size = new System.Drawing.Size(121, 23);
            this.jobIDBox.TabIndex = 10;
            this.jobIDBox.TextChanged += new System.EventHandler(this.jobIDBox_TextChanged);
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(29, 158);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(75, 23);
            this.cancelButton.TabIndex = 8;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // confirmButton
            // 
            this.confirmButton.Location = new System.Drawing.Point(119, 158);
            this.confirmButton.Name = "confirmButton";
            this.confirmButton.Size = new System.Drawing.Size(75, 23);
            this.confirmButton.TabIndex = 9;
            this.confirmButton.Text = "Confirm";
            this.confirmButton.UseVisualStyleBackColor = true;
            this.confirmButton.Click += new System.EventHandler(this.confirmButton_Click);
            // 
            // deleteButton
            // 
            this.deleteButton.BackColor = System.Drawing.Color.Red;
            this.deleteButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.deleteButton.Location = new System.Drawing.Point(212, 158);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(75, 23);
            this.deleteButton.TabIndex = 2;
            this.deleteButton.Text = "Delete";
            this.deleteButton.UseVisualStyleBackColor = false;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // basePayrateBox
            // 
            this.basePayrateBox.Location = new System.Drawing.Point(107, 106);
            this.basePayrateBox.Mask = "###.00";
            this.basePayrateBox.Name = "basePayrateBox";
            this.basePayrateBox.Size = new System.Drawing.Size(121, 23);
            this.basePayrateBox.TabIndex = 1;
            this.basePayrateBox.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.basePayrateBox_MaskInputRejected);
            // 
            // comboBox1
            // 
            this.comboBox1.Location = new System.Drawing.Point(107, 33);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 23);
            this.comboBox1.TabIndex = 0;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // JobInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(321, 203);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.basePayrateBox);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.confirmButton);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.jobIDBox);
            this.Controls.Add(this.jobTitleLabel);
            this.Controls.Add(this.jobIDLabel);
            this.Controls.Add(this.basePayrateLabel);
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
        private System.Windows.Forms.MaskedTextBox basePayrateBox;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}