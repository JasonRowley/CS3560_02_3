using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using GroupProjCS3560num2.Database;
using GroupProjCS3560num2.Classes.Handlers;
using GroupProjCS3560num2.Classes;

namespace GroupProjCS3560num2.Forms
{
    public partial class EmployeeInfo : Form
    {
        public EmployeeInfo(Employee emp)
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

        private void EmployeeInfo_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e) // emp name
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e) // address
        {

        }

        private void label2_Click(object sender, EventArgs e) // base pay label
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e) // job comboBox
        {
            // jobID and basePayrate get updated along with the selected job
            List<Job> j = DatabaseHelper.SelectAllJobs();
            for (int i = 0; i < j.Count; i++)
            {
                if (j[i].getJobTitle() == jobComboBox.SelectedItem.ToString())
                {
                    textBox12.Text = j[i].getBasePayrate().ToString();
                }
            }
        }

        private void label9_Click(object sender, EventArgs e) // password label
        {

        }

        private void button3_Click(object sender, EventArgs e) // delete button
        {
            int empID = Int32.Parse(IDTextBox.Text);
            EmployeeHandler.deleteEmployee(empID);
            this.Close();
        }

        private void textBox8_TextChanged(object sender, EventArgs e) // bank account number
        {

        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e) // SSN
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e) // date of birth
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e) // adjustment
        {

        }

        private void textBox12_TextChanged(object sender, EventArgs e) // base pay
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e) // email
        {

        }

        private void maskedTextBox2_MaskInputRejected(object sender, MaskInputRejectedEventArgs e) // phone
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e) // empID
        {

        }

        private void button2_Click(object sender, EventArgs e) // cancel button
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e) // confirm button // to update
        {
            long bankAccountNumber;
            double adjustment;
            TextBox[] textBoxes = { nameTextBox, emailTextBox, addressTextBox, bankTextBox, pwTextBox };
            MaskedTextBox[] maskedTextBoxes = { phoneMaskedTextBox, ssnMaskedTextBox };
            Label[] labels = { nameLabel, emailLabel, addressLabel, bankLabel, pwLabel, phoneLabel, ssnLabel, adjustmentLabel };

            // verifies adjustment
            bool adj = double.TryParse(adjustmentTextBox.Text, out adjustment);
            if (!adj || adjustment < 0)
                adjustmentLabel.ForeColor = System.Drawing.Color.Red;
            else
                adjustmentLabel.ForeColor = System.Drawing.Color.Black;

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
            for (int i = 0; i < 8; i++)
            {
                if (labels[i].ForeColor == System.Drawing.Color.Black)
                    countNotEmpty += 1;
                if (countNotEmpty == 8)
                {
                    EmployeeHandler.updateEmployee(Int32.Parse(IDTextBox.Text), JobHandler.getJobID(jobComboBox.Text), pwTextBox.Text, nameTextBox.Text, 
                        addressTextBox.Text, emailTextBox.Text, phoneMaskedTextBox.Text, dateTimePicker1.Value, bankTextBox.Text, ssnMaskedTextBox.Text, adjustment);
                    this.Close();
                }
            }
        }

        private void textBox9_TextChanged(object sender, EventArgs e) // password
        {

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
