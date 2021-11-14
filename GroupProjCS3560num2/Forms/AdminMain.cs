using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace GroupProjCS3560num2.Forms
{
    public partial class AdminMain : Form
    {
        public AdminMain()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //do nothing
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //issues
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //timelogs
        }

        private void button5_Click(object sender, EventArgs e) // add employee
        {
            // open the add employee form
            AddEmployee f = new AddEmployee();
            f.Show();
        }

        private void button6_Click(object sender, EventArgs e) // logout
        {
            // close and open the main login page
            this.Hide();
            StartPage f = new StartPage();
            f.Show();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

    }
}
