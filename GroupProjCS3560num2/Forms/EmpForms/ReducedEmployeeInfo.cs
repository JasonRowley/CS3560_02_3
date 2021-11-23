using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using GroupProjCS3560num2.Database;
using GroupProjCS3560num2.Classes;
using GroupProjCS3560num2.Classes.Handlers;

namespace GroupProjCS3560num2.Forms.EmpForms
{
    public partial class ReducedEmployeeInfo : Form
    {
        public ReducedEmployeeInfo(Employee emp)
        {
            InitializeComponent();
            List<Job> j = DatabaseHelper.SelectAllJobs();
            for (int i = 0; i < j.Count; i++)
            {
                jobComboBox.Items.Add(j[i].getJobTitle());
            }

            for (int i = 0; i < j.Count; i++)
            {
                if (emp.getJobID() == j[i].getJobID())
                {
                    jobComboBox.Text = j[i].getJobTitle();
                    textBox12.Text = j[i].getBasePayrate().ToString();
                    break;
                }
            }

            nameTextBox.Text = emp.getEmpName();
            IDTextBox.Text = emp.getEmployeeID().ToString();
            phoneMaskedTextBox.Text = emp.getPhoneNumber();
            emailTextBox.Text = emp.getEmail();
            addressTextBox.Text = emp.getPhysicalAddress();
            adjustmentTextBox.Text = emp.getAdjustment().ToString();
            dateTimePicker1.Text = emp.getDateOfBirth().ToString();
            ssnMaskedTextBox.Text = emp.getSSN();
            bankTextBox.Text = emp.getBankAccNum();
            pwTextBox.Text = emp.getPw();
        }

        private void button1_Click(object sender, EventArgs e) // confimr button
        {
            long bankAccountNumber;
            TextBox[] textBoxes = { nameTextBox, emailTextBox, addressTextBox, bankTextBox, pwTextBox };
            MaskedTextBox[] maskedTextBoxes = { phoneMaskedTextBox, ssnMaskedTextBox };
            Label[] labels = { nameLabel, emailLabel, addressLabel, bankLabel, pwLabel, phoneLabel, ssnLabel };

            // verifies that name, email, address, bank account number, password are not empty
            for (int i = 0; i < 5; i++)
            {
                if (textBoxes[i].Text == "")
                    labels[i].ForeColor = System.Drawing.Color.Red;
                else
                    labels[i].ForeColor = System.Drawing.Color.Black;
            }

            // verifies phone number and ssn
            for (int i = 0; i < 2; i++)
            {
                if (!maskedTextBoxes[i].MaskCompleted)
                    labels[5 + i].ForeColor = System.Drawing.Color.Red;
                else
                    labels[5 + i].ForeColor = System.Drawing.Color.Black;
            }

            // verifies bank account number as integer
            bool bankNumber = Int64.TryParse(bankTextBox.Text, out bankAccountNumber);
            if (!bankNumber || bankAccountNumber < 1)
                bankLabel.ForeColor = System.Drawing.Color.Red;
            else
            {
                bankLabel.ForeColor = System.Drawing.Color.Black;
                bankTextBox.Text = bankAccountNumber.ToString();
            }

            // verifies that none is empty
            int countNotEmpty = 0;
            for (int i = 0; i < 7; i++)
            {
                if (labels[i].ForeColor == System.Drawing.Color.Black)
                    countNotEmpty += 1;
                if (countNotEmpty == 7)
                {
                    EmployeeHandler.updateEmployee(Int32.Parse(IDTextBox.Text), JobHandler.getJobID(jobComboBox.Text), pwTextBox.Text, nameTextBox.Text,
                        addressTextBox.Text, emailTextBox.Text, phoneMaskedTextBox.Text, dateTimePicker1.Value, bankTextBox.Text, ssnMaskedTextBox.Text, double.Parse(adjustmentTextBox.Text));
                    this.Close();
                }
            }
        }

        private void button2_Click(object sender, EventArgs e) // cancel button
        {
            Close();
        }
    }
}
