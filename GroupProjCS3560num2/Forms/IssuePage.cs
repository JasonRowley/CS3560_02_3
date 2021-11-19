using GroupProjCS3560num2.Classes;
using GroupProjCS3560num2.Classes.Handlers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GroupProjCS3560num2.Forms
{
    public partial class IssuePage : Form
    {

        private int employeeID;

        public IssuePage(int employeeID)   //   <<----- ask for Employee id of the person currently logged in  upon logging in . Otherwise, I have no choice but to give people free reign of identity theft. Heed my wanrning.
        {

            this.employeeID = employeeID;
            InitializeComponent();

            
                   }

        private void Issue_Load(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // collect whatever message is being typed in by the employee 

            if (string.IsNullOrEmpty(richTextBox1.Text))
            {

                textBox2.Text = "Empty Input message";
               

            }

            else 
            {

                string tempString = richTextBox1.Text;

                IssueHandler.AddIssue(employeeID, tempString);

                textBox2.Text = "your issue has been submitted";
                button1.Enabled = false;
                //Task.Delay(500).ContinueWith(t => this.Close());

               

            }










        }




        
    }
}
