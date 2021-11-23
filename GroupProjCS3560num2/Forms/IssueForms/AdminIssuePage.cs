using GroupProjCS3560num2.Classes;
using GroupProjCS3560num2.Database;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace GroupProjCS3560num2.Forms
{
    public partial class AdminIssuePage : Form
    {
        Issue currentIssue;

        public AdminIssuePage(Issue issue)   // the issue is the issue you click on as the admin. Admin is to replace the dummbAdmin
        {
            currentIssue = issue;

            InitializeComponent();
            string myString = currentIssue.getIssueStr();
            richTextBox1.Text = myString;
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {


        }

        private void button1_Click(object sender, EventArgs e)
        {
            DatabaseHelper.DeleteIssue(currentIssue.getIssueID());
            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //currentIssue.setAdminID(adminID);
            currentIssue.setSolved(true);
            DatabaseHelper.UpdateIssue(currentIssue);
            Close();
        }
    }
}
