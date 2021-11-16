using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using GroupProjCS3560num2.Forms;
using GroupProjCS3560num2.Classes.Handlers;

namespace GroupProjCS3560num2.Forms
{
    public partial class AdminMain : Form
    {
        public AdminMain()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e) // do nothing
        {
            
        }

        private void button3_Click(object sender, EventArgs e) // issues
        {

        }

        private void button4_Click(object sender, EventArgs e) // timelogs
        {

        }

        private void button5_Click(object sender, EventArgs e) // add employee
        {
            AddEmployee f = new AddEmployee();
            f.Show();
        }

        private void button6_Click(object sender, EventArgs e) // logout
        {
            this.Hide();
            StartPage f = new StartPage();
            f.Show();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e) // employee table
        {
/*            var emp = DisplayEmployeeHandler.DispEmp();
            foreach (var Employee in emp)
            {
                var row = new string[]
                {
                    //(string)Employee.getEmployeeID(), Employee.getEmpName(), Employee.getJobID(), 
                }
            }*/

            // get the list of employees and their information from the data base
            // display the list of employees and their information
        }

    }
}
