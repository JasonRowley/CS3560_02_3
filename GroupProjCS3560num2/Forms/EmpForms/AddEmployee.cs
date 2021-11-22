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
            long bankAccountNumber;
            double adjustment;

            TextBox[] textBoxes = { textBox1, textBox3, textBox2, textBox9, textBox8};
            MaskedTextBox[] maskedTextBoxes = { maskedTextBox2, maskedTextBox1 };
            Label[] labels = { label1, label3, label2, label9, label8, label11, label5, label4, label7 };

            // verifies if name, email, addres, password, bank account number are empty
            for (int i = 0; i < 5; i++)
            {
                if (textBoxes[i].Text == "")
                    labels[i].ForeColor = System.Drawing.Color.Red;
                else
                    labels[i].ForeColor = System.Drawing.Color.Black;
            }

            // verifies phone, ssn
            for (int i = 0; i < 2; i++)
            {
                if (!maskedTextBoxes[i].MaskCompleted)
                    labels[7 + i].ForeColor = System.Drawing.Color.Red;
                else
                    labels[7 + i].ForeColor = System.Drawing.Color.Black;
            }

            // verifies job
            if (comboBox1.SelectedIndex == -1)
                label11.ForeColor = System.Drawing.Color.Red;
            else
                label11.ForeColor = System.Drawing.Color.Black;
            
            // verifies adjustment
            bool adj = double.TryParse(textBox5.Text, out adjustment);
            if (!adj || adjustment < 0)
                label5.ForeColor = System.Drawing.Color.Red;
            else
                label5.ForeColor = System.Drawing.Color.Black;

            // verifies bank account number as integer
            bool bankNumber = Int64.TryParse(textBox8.Text, out bankAccountNumber);
            if (!bankNumber || bankAccountNumber < 1)
                label8.ForeColor = System.Drawing.Color.Red;
            else
            {
                label8.ForeColor = System.Drawing.Color.Black;
                textBox8.Text = bankAccountNumber.ToString();
            }

            // verifies that none is empty
            int countNotEmpty = 0;
            for (int i = 0; i < 9; i++)
            {
                if (labels[i].ForeColor == System.Drawing.Color.Black)
                    countNotEmpty += 1;
                if (countNotEmpty == 9)
                {
                    EmployeeHandler.addEmployee(0, JobHandler.getJobID(comboBox1.Text), textBox9.Text, textBox1.Text, textBox2.Text, 
                        textBox3.Text, maskedTextBox2.Text, dateTimePicker1.Value, textBox8.Text, maskedTextBox1.Text, adjustment);
                    this.Close();
                }
            }
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
            //label1.ForeColor = System.Drawing.Color.Red;
        }

    }
}
