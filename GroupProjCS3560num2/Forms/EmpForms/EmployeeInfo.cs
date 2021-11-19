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
                comboBox1.Items.Add(j[i].getJobTitle());
            }

            for (int i = 0; i < j.Count; i++)
            {
                if (emp.getJobID() == j[i].getJobID())
                {
                    comboBox1.Text = j[i].getJobTitle();
                    textBox12.Text = j[i].getBasePayrate().ToString();
                    break;
                }
            }

            textBox1.Text = emp.getEmpName();
            textBox4.Text = emp.getEmployeeID().ToString();
            maskedTextBox2.Text = emp.getPhoneNumber();
            textBox3.Text = emp.getEmail();
            textBox2.Text = emp.getPhysicalAddress();
            textBox5.Text = emp.getAdjustment().ToString();
            dateTimePicker1.Text = emp.getDateOfBirth().ToString();
            maskedTextBox1.Text = emp.getSSN();
            textBox8.Text = emp.getBankAccNum();
            textBox9.Text = emp.getPw();
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
                if (j[i].getJobTitle() == comboBox1.SelectedItem.ToString())
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
            int empID = Int32.Parse(textBox4.Text);
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
            int employeeID = Int32.Parse(textBox4.Text);
            int jobID = JobHandler.getJobID(comboBox1.Text);
            String phoneNumber = maskedTextBox2.Text;
            double adjustment = 0;
            try
            {
                adjustment = double.Parse(textBox5.Text); // verifies that is pasing a number
                if (adjustment < 0)
                    adjustment *= -1;
            } catch { }
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

        private void textBox9_TextChanged(object sender, EventArgs e) // password
        {

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
