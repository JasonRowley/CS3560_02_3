using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using GroupProjCS3560num2.Forms.Logins;
using GroupProjCS3560num2.Classes.Handlers;

namespace GroupProjCS3560num2.Forms
{
    public partial class AdminMain : Form
    {
        AdminMainHandler amh;

        public AdminMain()
        {
            InitializeComponent();

            // Create handler and display employee table
            amh = new AdminMainHandler(listView1, button5);
            amh.changeTbl(Tables.EMPLOYEE);

            // Search and display specific rows on Enter key press
            textBox1.KeyUp += textBox1_KeyUp;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            amh.changeTbl(Tables.EMPLOYEE);
        }
        
        private void button2_Click(object sender, EventArgs e)
        {
            amh.changeTbl(Tables.JOB);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            amh.changeTbl(Tables.ISSUE);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            amh.changeTbl(Tables.TIMELOG);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            //add to table
            //Login testLogin = new Login();
            //testLogin.ShowDialog();
            //amh.changeTbl(Tables.ISSUE);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            //logout
        }

        private void textBox1_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                try
                {
                    amh.populateColumns(amh.getSearchQuery(textBox1.Text));
                }
                catch (NoTextException) { /* do nothing */ }
                catch (NoEmployeesException) { /* do nothing */ }
                finally
                {
                    e.Handled = true;
                }
            }
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }
    }
}
