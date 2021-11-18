using GroupProjCS3560num2.Classes;
using GroupProjCS3560num2.Database;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using GroupProjCS3560num2.Classes.Handlers;

namespace GroupProjCS3560num2.Forms
{
    public partial class AddEmployee : Form
    {
        public AddEmployee()
        {
            InitializeComponent();
            List<Job> j = DatabaseHelper.SelectAllJobs();
            for (int i = 0; i < j.Count; i++)
            {
                comboBox1.Items.Add(j[i].getJobTitle());
            }
        }

        private void textBox5_TextChanged(object sender, EventArgs e) // adjustment
        {

        }

        private void button1_Click(object sender, EventArgs e) // confirm button
        {
            int employeeID = 0;
            string jobID = comboBox1.Text;
            String phoneNumber = maskedTextBox2.Text;
            double adjustment = double.Parse(textBox5.Text);
            DateTime dateOfBirth = dateTimePicker1.Value;
            String empName = textBox1.Text;
            String physicalAddress = textBox2.Text;
            String email = textBox3.Text;
            String bankAccNum = textBox8.Text;
            String sSN = maskedTextBox1.Text;
            String password = textBox9.Text;

            EmployeeHandler.updateEmployee(employeeID, jobID, password, empName, physicalAddress, email, phoneNumber, dateOfBirth, bankAccNum, sSN, adjustment);

            this.Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e) // name
        {

        }

        private void maskedTextBox2_MaskInputRejected(object sender, MaskInputRejectedEventArgs e) // phone number
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e) // email
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e) // address
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e) // date of birth
        {

        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e) // SSN
        {

        }

        private void textBox8_TextChanged(object sender, EventArgs e) // bank account number
        {

        }

        private void textBox9_TextChanged(object sender, EventArgs e) // password
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e) // job
        {

        }

        private void button2_Click(object sender, EventArgs e) // cancel button
        {
            this.Close();
        }
    }
}
