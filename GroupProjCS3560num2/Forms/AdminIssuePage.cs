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
        private int issueID, adminID;
        Issue currentIssue;
        public AdminIssuePage(int issueID, int adminID)   // the issue is the issue you click on as the admin. Admin is to replace the dummbAdmin
        {

            this.issueID = issueID;
            this.adminID = adminID;
            currentIssue = DatabaseHelper.SelectIssue(issueID);

            

            InitializeComponent();
            string myString = currentIssue.getIssueStr() + ",  admin = "+ currentIssue.getAdminID()+ " , resolved? = " + currentIssue.isSolved() ;
            //richTextBox1.Text = currentIssue.getIssueStr();
            richTextBox1.Text = myString;
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {


        }

        private void button1_Click(object sender, EventArgs e)
        {
            DatabaseHelper.DeleteIssue(issueID);
            button1.Enabled = false;
            button2.Enabled = false;
            richTextBox1.Text = "your issue is deleted";


        }

        private void button2_Click(object sender, EventArgs e)
        {
            currentIssue.setAdminID(adminID);
            currentIssue.setSolved(true);
            currentIssue.setIssueStr(currentIssue.getIssueStr() + " <- totally solved");

            DatabaseHelper.UpdateIssue(currentIssue);

            //testing purposes

            currentIssue = DatabaseHelper.SelectIssue(issueID);

            string myString = currentIssue.getIssueStr() + ",  admin = " + currentIssue.getAdminID() + " , resolved? = " + currentIssue.isSolved();
           
            richTextBox1.Text = myString;

        }
    }
}
