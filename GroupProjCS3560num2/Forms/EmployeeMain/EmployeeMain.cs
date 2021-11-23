using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using GroupProjCS3560num2.Classes;
using GroupProjCS3560num2.Classes.Handlers;

namespace GroupProjCS3560num2.Forms
{
    public partial class EmployeeMain : Form
    {
        EmployeeMainHandler amh;
        Employee emp;
        public EmployeeMain(Employee emp)
        {
            InitializeComponent();
            // Create handler and display employee table
            this.emp = emp;
            amh = new EmployeeMainHandler(emp, listView1);
            amh.changeTbl();
        }



        private void button2_Click(object sender, EventArgs e)
        {
            //this needs to be changed to Lilly version.
            EmployeeInfo aE = new EmployeeInfo(emp);
            aE.StartPosition = FormStartPosition.CenterScreen;
            aE.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //Add new Issue

            /*
                AddIssue aT = new AddIssue();
                aT.StartPosition = FormStartPosition.CenterScreen;
                aT.ShowDialog();
            */
        }
    }
}
