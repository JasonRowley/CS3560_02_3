﻿
namespace GroupProjCS3560num2.Forms.EmpForms
{
    partial class ReducedEmployeeInfo
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
            this.IDTextBox = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.phoneMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.ssnMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.jobComboBox = new System.Windows.Forms.ComboBox();
            this.textBox12 = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.jobLabel = new System.Windows.Forms.Label();
            this.pwLabel = new System.Windows.Forms.Label();
            this.bankLabel = new System.Windows.Forms.Label();
            this.ssnLabel = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.pwTextBox = new System.Windows.Forms.TextBox();
            this.bankTextBox = new System.Windows.Forms.TextBox();
            this.adjustmentLabel = new System.Windows.Forms.Label();
            this.phoneLabel = new System.Windows.Forms.Label();
            this.emailLabel = new System.Windows.Forms.Label();
            this.addressLabel = new System.Windows.Forms.Label();
            this.nameLabel = new System.Windows.Forms.Label();
            this.adjustmentTextBox = new System.Windows.Forms.TextBox();
            this.emailTextBox = new System.Windows.Forms.TextBox();
            this.addressTextBox = new System.Windows.Forms.TextBox();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // IDTextBox
            // 
            this.IDTextBox.Location = new System.Drawing.Point(99, 53);
            this.IDTextBox.Name = "IDTextBox";
            this.IDTextBox.ReadOnly = true;
            this.IDTextBox.Size = new System.Drawing.Size(274, 23);
            this.IDTextBox.TabIndex = 59;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(25, 57);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(18, 15);
            this.label10.TabIndex = 58;
            this.label10.Text = "ID";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(122, 353);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 57;
            this.button2.Text = "Cancel";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(203, 353);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 56;
            this.button1.Text = "Confirm";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // phoneMaskedTextBox
            // 
            this.phoneMaskedTextBox.Location = new System.Drawing.Point(99, 83);
            this.phoneMaskedTextBox.Mask = "(999) 000-0000";
            this.phoneMaskedTextBox.Name = "phoneMaskedTextBox";
            this.phoneMaskedTextBox.Size = new System.Drawing.Size(274, 23);
            this.phoneMaskedTextBox.TabIndex = 55;
            // 
            // ssnMaskedTextBox
            // 
            this.ssnMaskedTextBox.Location = new System.Drawing.Point(99, 255);
            this.ssnMaskedTextBox.Mask = "000-00-0000";
            this.ssnMaskedTextBox.Name = "ssnMaskedTextBox";
            this.ssnMaskedTextBox.Size = new System.Drawing.Size(274, 23);
            this.ssnMaskedTextBox.TabIndex = 54;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(99, 226);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(274, 23);
            this.dateTimePicker1.TabIndex = 53;
            // 
            // jobComboBox
            // 
            this.jobComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.jobComboBox.Enabled = false;
            this.jobComboBox.FormattingEnabled = true;
            this.jobComboBox.Location = new System.Drawing.Point(99, 169);
            this.jobComboBox.Name = "jobComboBox";
            this.jobComboBox.Size = new System.Drawing.Size(274, 23);
            this.jobComboBox.TabIndex = 52;
            // 
            // textBox12
            // 
            this.textBox12.Location = new System.Drawing.Point(99, 198);
            this.textBox12.Name = "textBox12";
            this.textBox12.ReadOnly = true;
            this.textBox12.Size = new System.Drawing.Size(100, 23);
            this.textBox12.TabIndex = 51;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(25, 201);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(53, 15);
            this.label12.TabIndex = 50;
            this.label12.Text = "Base Pay";
            // 
            // jobLabel
            // 
            this.jobLabel.AutoSize = true;
            this.jobLabel.Location = new System.Drawing.Point(25, 172);
            this.jobLabel.Name = "jobLabel";
            this.jobLabel.Size = new System.Drawing.Size(25, 15);
            this.jobLabel.TabIndex = 49;
            this.jobLabel.Text = "Job";
            // 
            // pwLabel
            // 
            this.pwLabel.AutoSize = true;
            this.pwLabel.Location = new System.Drawing.Point(26, 316);
            this.pwLabel.Name = "pwLabel";
            this.pwLabel.Size = new System.Drawing.Size(57, 15);
            this.pwLabel.TabIndex = 48;
            this.pwLabel.Text = "Password";
            // 
            // bankLabel
            // 
            this.bankLabel.AutoSize = true;
            this.bankLabel.Location = new System.Drawing.Point(26, 287);
            this.bankLabel.Name = "bankLabel";
            this.bankLabel.Size = new System.Drawing.Size(121, 15);
            this.bankLabel.TabIndex = 47;
            this.bankLabel.Text = "Bank Accout Number";
            // 
            // ssnLabel
            // 
            this.ssnLabel.AutoSize = true;
            this.ssnLabel.Location = new System.Drawing.Point(26, 258);
            this.ssnLabel.Name = "ssnLabel";
            this.ssnLabel.Size = new System.Drawing.Size(28, 15);
            this.ssnLabel.TabIndex = 46;
            this.ssnLabel.Text = "SSN";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(26, 232);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 15);
            this.label6.TabIndex = 45;
            this.label6.Text = "Birthdate";
            // 
            // pwTextBox
            // 
            this.pwTextBox.Location = new System.Drawing.Point(99, 313);
            this.pwTextBox.Name = "pwTextBox";
            this.pwTextBox.Size = new System.Drawing.Size(274, 23);
            this.pwTextBox.TabIndex = 44;
            // 
            // bankTextBox
            // 
            this.bankTextBox.Location = new System.Drawing.Point(153, 284);
            this.bankTextBox.Name = "bankTextBox";
            this.bankTextBox.Size = new System.Drawing.Size(220, 23);
            this.bankTextBox.TabIndex = 43;
            // 
            // adjustmentLabel
            // 
            this.adjustmentLabel.AutoSize = true;
            this.adjustmentLabel.Location = new System.Drawing.Point(205, 201);
            this.adjustmentLabel.Name = "adjustmentLabel";
            this.adjustmentLabel.Size = new System.Drawing.Size(69, 15);
            this.adjustmentLabel.TabIndex = 42;
            this.adjustmentLabel.Text = "Adjustment";
            // 
            // phoneLabel
            // 
            this.phoneLabel.AutoSize = true;
            this.phoneLabel.Location = new System.Drawing.Point(25, 85);
            this.phoneLabel.Name = "phoneLabel";
            this.phoneLabel.Size = new System.Drawing.Size(41, 15);
            this.phoneLabel.TabIndex = 41;
            this.phoneLabel.Text = "Phone";
            // 
            // emailLabel
            // 
            this.emailLabel.AutoSize = true;
            this.emailLabel.Location = new System.Drawing.Point(25, 114);
            this.emailLabel.Name = "emailLabel";
            this.emailLabel.Size = new System.Drawing.Size(36, 15);
            this.emailLabel.TabIndex = 40;
            this.emailLabel.Text = "Email";
            // 
            // addressLabel
            // 
            this.addressLabel.AutoSize = true;
            this.addressLabel.Location = new System.Drawing.Point(25, 143);
            this.addressLabel.Name = "addressLabel";
            this.addressLabel.Size = new System.Drawing.Size(49, 15);
            this.addressLabel.TabIndex = 39;
            this.addressLabel.Text = "Address";
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Location = new System.Drawing.Point(25, 31);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(39, 15);
            this.nameLabel.TabIndex = 38;
            this.nameLabel.Text = "Name";
            // 
            // adjustmentTextBox
            // 
            this.adjustmentTextBox.Location = new System.Drawing.Point(280, 198);
            this.adjustmentTextBox.Name = "adjustmentTextBox";
            this.adjustmentTextBox.ReadOnly = true;
            this.adjustmentTextBox.Size = new System.Drawing.Size(93, 23);
            this.adjustmentTextBox.TabIndex = 37;
            // 
            // emailTextBox
            // 
            this.emailTextBox.Location = new System.Drawing.Point(99, 111);
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.Size = new System.Drawing.Size(274, 23);
            this.emailTextBox.TabIndex = 36;
            // 
            // addressTextBox
            // 
            this.addressTextBox.Location = new System.Drawing.Point(99, 140);
            this.addressTextBox.Name = "addressTextBox";
            this.addressTextBox.Size = new System.Drawing.Size(274, 23);
            this.addressTextBox.TabIndex = 35;
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(99, 24);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(274, 23);
            this.nameTextBox.TabIndex = 34;
            // 
            // ReducedEmployeeInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(407, 393);
            this.Controls.Add(this.IDTextBox);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.phoneMaskedTextBox);
            this.Controls.Add(this.ssnMaskedTextBox);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.jobComboBox);
            this.Controls.Add(this.textBox12);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.jobLabel);
            this.Controls.Add(this.pwLabel);
            this.Controls.Add(this.bankLabel);
            this.Controls.Add(this.ssnLabel);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.pwTextBox);
            this.Controls.Add(this.bankTextBox);
            this.Controls.Add(this.adjustmentLabel);
            this.Controls.Add(this.phoneLabel);
            this.Controls.Add(this.emailLabel);
            this.Controls.Add(this.addressLabel);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.adjustmentTextBox);
            this.Controls.Add(this.emailTextBox);
            this.Controls.Add(this.addressTextBox);
            this.Controls.Add(this.nameTextBox);
            this.Name = "ReducedEmployeeInfo";
            this.Text = "ReducedEmployeeInfo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox IDTextBox;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.MaskedTextBox phoneMaskedTextBox;
        private System.Windows.Forms.MaskedTextBox ssnMaskedTextBox;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.ComboBox jobComboBox;
        private System.Windows.Forms.TextBox textBox12;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label jobLabel;
        private System.Windows.Forms.Label pwLabel;
        private System.Windows.Forms.Label bankLabel;
        private System.Windows.Forms.Label ssnLabel;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox pwTextBox;
        private System.Windows.Forms.TextBox bankTextBox;
        private System.Windows.Forms.Label adjustmentLabel;
        private System.Windows.Forms.Label phoneLabel;
        private System.Windows.Forms.Label emailLabel;
        private System.Windows.Forms.Label addressLabel;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.TextBox adjustmentTextBox;
        private System.Windows.Forms.TextBox emailTextBox;
        private System.Windows.Forms.TextBox addressTextBox;
        private System.Windows.Forms.TextBox nameTextBox;
    }
}