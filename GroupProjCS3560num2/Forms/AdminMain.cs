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
    public partial class AdminMain : Form
    {
        AdminMainHandler listView1Handler;

        public AdminMain()
        {
            InitializeComponent();
            listView1Handler = new AdminMainHandler(listView1);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listView1Handler.changeTbl(Tables.EMPLOYEE);
        }
        
        private void button2_Click(object sender, EventArgs e)
        {
            listView1Handler.changeTbl(Tables.JOB);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            listView1Handler.changeTbl(Tables.ISSUE);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            listView1Handler.changeTbl(Tables.TIMELOG);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            //add to table
        }

        private void button6_Click(object sender, EventArgs e)
        {
            //logout
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
