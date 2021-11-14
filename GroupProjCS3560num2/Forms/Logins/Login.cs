﻿using GroupProjCS3560num2.Classes;
using GroupProjCS3560num2.Database;
using System;
using System.Windows.Forms;
using GroupProjCS3560num2.Classes.Handlers;
//using GroupProjCS3560num2.Forms.Login;

namespace GroupProjCS3560num2.Forms
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();

        }

        private void button1_Click(object sender, EventArgs e) // cancel button
        {
            this.Close();
        }


        private void textBox2_TextChanged(object sender, EventArgs e) // password box
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            int empID = Int32.Parse(maskedTextBox1.Text);
            String pass = textBox2.Text;
            Employee tempEmployee = LoginHandler.Login(empID, pass);
            if (null == tempEmployee)
            {
                AdminMain f0 = new AdminMain();
                f0.Show();
            }
           /* else
            {
                Forms.Login.IncorrectCredentials f1 = new Forms.Login.IncorrectCredentials();
                f1.Show();
            } */
            
        }


        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e) // id box
        {

        }

        private void Login_Load(object sender, EventArgs e)
        {

        }
    }
}
