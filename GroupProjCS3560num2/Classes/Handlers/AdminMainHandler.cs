using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace GroupProjCS3560num2.Classes.Handlers
{
    public enum Tables
    {
        EMPLOYEE,
        ISSUE,
        TIMELOG,
        JOB
    }

    public class AdminMainHandler
    {
        // Managed database display
        ListView lv;
        // Variable to track which table the database display is on
        Tables currTbl;

        public AdminMainHandler(ListView lv, Tables currTbl = Tables.EMPLOYEE)
        {
            this.lv = lv;
            this.currTbl = currTbl;
        }

        public void changeTbl(Tables tbl)
        {
            var cols = lv.Columns;
            cols.Clear();
            lv.Items.Clear();
            switch (tbl)
            {
                case Tables.EMPLOYEE:
                    // Replace the removed columns
                    for (int i = 0; i < 7; i++)
                    {
                        cols.Add(new ColumnHeader());
                    }

                    // Set visible properties for each column
                    cols[0].Name = "employeeID";
                    cols[0].Text = "ID";
                    cols[0].Width = 30;

                    cols[1].Name = "employeeName";
                    cols[1].Text = "Name";
                    cols[1].Width = 70;

                    cols[2].Name = "job";
                    cols[2].Text = "Job";
                    cols[2].Width = 50;

                    cols[3].Name = "physicalAddress";
                    cols[3].Text = "Address";
                    cols[3].Width = 90;

                    cols[4].Name = "emailAddress";
                    cols[4].Text = "Email";
                    cols[4].Width = 70;

                    cols[5].Name = "phoneNumber";
                    cols[5].Text = "Phone Number";
                    cols[5].Width = 150;

                    cols[6].Name = "solved";
                    cols[6].Text = "Issue";
                    cols[6].Width = 70;
                    break;
                case Tables.ISSUE:
                    // Replace the removed columns
                    for (int i = 0; i < 5; i++)
                    {
                        cols.Add(new ColumnHeader());
                    }

                    // Set visible properties for each column
                    cols[0].Name = "issueID";
                    cols[0].Text = "ID";
                    cols[0].Width = 30;

                    cols[1].Name = "employeeID";
                    cols[1].Text = "Employee";
                    cols[1].Width = 90;

                    cols[2].Name = "adminID";
                    cols[2].Text = "Admin";
                    cols[2].Width = 70;

                    cols[3].Name = "issueStr";
                    cols[3].Text = "Description";
                    cols[3].Width = 150;

                    cols[4].Name = "solved";
                    cols[4].Text = "Solved";
                    cols[4].Width = 70;
                    break;
                case Tables.TIMELOG:
                    // Replace the removed columns
                    for (int i = 0; i < 4; i++)
                    {
                        cols.Add(new ColumnHeader());
                    }
                    // Set visible properties for each column
                    cols[0].Name = "logID";
                    cols[0].Text = "ID";
                    cols[0].Width = 30;

                    cols[1].Name = "employeeID";
                    cols[1].Text = "Employee";
                    cols[1].Width = 90;

                    cols[2].Name = "checkIn";
                    cols[2].Text = "Check-In Time";
                    cols[2].Width = 150;

                    cols[3].Name = "checkOut";
                    cols[3].Text = "Check-Out Time";
                    cols[3].Width = 150;
                    break;
                case Tables.JOB:
                    // Replace the removed columns
                    for (int i = 0; i < 3; i++)
                    {
                        cols.Add(new ColumnHeader());
                    }
                    // Set visible properties for each column
                    cols[0].Name = "jobID";
                    cols[0].Text = "ID";
                    cols[0].Width = 30;

                    cols[1].Name = "jobTitle";
                    cols[1].Text = "Title";
                    cols[1].Width = 50;

                    cols[2].Name = "basePayrate";
                    cols[2].Text = "Base Payrate";
                    cols[2].Width = 95;
                    break;
            }
        }
    }
}
