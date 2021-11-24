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
    public partial class AddIssue : Form
    {

        private int employeeID;
        private List<int> adminIDs;

        public AddIssue(int employeeID)   //   <<----- ask for Employee id of the person currently logged in  upon logging in . Otherwise, I have no choice but to give people free reign of identity theft. Heed my wanrning.
        {
            // Initialize private members
            this.employeeID = employeeID;
            adminIDs = new List<int>();

            InitializeComponent();
            label1.Hide();
            adminComboBox.DropDownStyle = ComboBoxStyle.DropDownList;

            // Setup admin dropdown labels
            var admins = IssueHandler.GetAllAdmin();
            foreach (var admin in admins)
            {
                adminComboBox.Items.Add(
                    admin.getEmpName()
                    + " - ID: " +
                    admin.getEmployeeID()
                    );
                adminIDs.Add(admin.getEmployeeID());
            }
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

        private async void button1_Click(object sender, EventArgs e)
        {
            // collect whatever message is being typed in by the employee 
            bool isProperFormat = true;

            if (string.IsNullOrEmpty(richTextBox1.Text))
            {
                label1.Text = "* Needs message";
                label1.ForeColor = System.Drawing.Color.Red;
                label1.Show();
                isProperFormat = false;
            }

            if (adminComboBox.SelectedIndex == -1)
            {
                label2.ForeColor = System.Drawing.Color.Red;
                isProperFormat = false;
            }

            if (isProperFormat)
            {
                label2.ForeColor = System.Drawing.Color.Black;
                label1.Text = "Issue successfully submitted!";
                label1.ForeColor = System.Drawing.Color.DodgerBlue;
                label1.Show();

                string tempString = richTextBox1.Text;
                IssueHandler.AddIssue(employeeID, adminIDs[adminComboBox.SelectedIndex], tempString);
                button1.Enabled = false;
                await Task.Delay(1000);
                Close();
            }
        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }
    }
}
