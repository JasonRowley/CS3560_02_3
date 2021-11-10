using GroupProjCS3560num2.Classes;
using GroupProjCS3560num2.Database;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Collections;

namespace GroupProjCS3560num2.Forms
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
            TimeLog log = DatabaseHelper.VerifyTimeLog(1);
            textBox1.Text = log.getLogID().ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int username = Int32.Parse(textBox1.Text); //EmployeeID
            string password = textBox2.Text;

            
            Employee loginEmployee = DatabaseHelper.VerifyPassword(username, password);

            if(loginEmployee != null)
            {
                //navigate to admin page
            }
            else
            {
                //display message saying invalid password/username
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
