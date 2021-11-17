﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using GroupProjCS3560num2.Database;

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
        // Managed components in AdminMain form
        ListView lv;
        Button addRowBtn;
        // Variable to track which table the database display is on
        Tables currTbl;

        public AdminMainHandler(ListView lv, Button addRowBtn, Tables currTbl = Tables.EMPLOYEE)
        {
            this.lv = lv;
            this.addRowBtn = addRowBtn;
            this.currTbl = currTbl;
        }

        public void changeTbl(Tables tbl)
        {
            var cols = lv.Columns;
            cols.Clear();
            switch (tbl)
            {
                case Tables.EMPLOYEE:
                    addRowBtn.Text = "Add New Employee";

                    // Replace the removed columns
                    for (int i = 0; i < 6; i++)
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
                    break;
                case Tables.ISSUE:
                    addRowBtn.Text = "Add New Issue";

                    // Replace the removed columns
                    for (int i = 0; i < 4; i++)
                    {
                        cols.Add(new ColumnHeader());
                    }

                    // Set visible properties for each column
                    cols[0].Name = "solved";
                    cols[0].Text = "Solved";
                    cols[0].Width = 70;

                    cols[1].Name = "issueID";
                    cols[1].Text = "ID";
                    cols[1].Width = 30;

                    cols[2].Name = "employeeName";
                    cols[2].Text = "Employee";
                    cols[2].Width = 90;

                    cols[3].Name = "adminName";
                    cols[3].Text = "Admin";
                    cols[3].Width = 70;
                    break;
                case Tables.TIMELOG:
                    addRowBtn.Text = "Add New Time Log";

                    // Replace the removed columns
                    for (int i = 0; i < 4; i++)
                    {
                        cols.Add(new ColumnHeader());
                    }

                    // Set visible properties for each column
                    cols[0].Name = "logID";
                    cols[0].Text = "ID";
                    cols[0].Width = 30;

                    cols[1].Name = "employeeName";
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
                    addRowBtn.Text = "Add New Job";

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
            currTbl = tbl;
            populateColumns();
        }


        public void populateColumns(string where = "")
        {
            lv.Items.Clear();
            switch (currTbl)
            {
                case Tables.EMPLOYEE:
                    var emps = DatabaseHelper.SelectAllEmployees(where);

                    // Display all returned rows
                    foreach (var emp in emps)
                    {
                        string[] attributes = {
                            emp.getEmpName().ToString(),
                            DatabaseHelper.SelectJob(emp.getJobID()).getJobTitle(),
                            emp.getPhysicalAddress(),
                            emp.getEmail(),
                            emp.getPhoneNumber()
                        };
                        lv.Items.Add(emp.getEmployeeID().ToString()).SubItems.AddRange(attributes);
                    }
                    break;
                case Tables.ISSUE:
                    var issues = DatabaseHelper.SelectAllIssues(where);

                    // Display all returned rows
                    foreach (var issue in issues)
                    {
                        string[] attributes = {
                            issue.getIssueID().ToString(),
                            DatabaseHelper.SelectEmployee(issue.getEmployeeID()).getEmpName(),
                            DatabaseHelper.SelectEmployee(issue.getAdminID()).getEmpName()
                        };
                        lv.Items.Add(issue.isSolved() ? "X" : "").SubItems.AddRange(attributes);
                    }
                    break;
                case Tables.TIMELOG:
                    var logs = DatabaseHelper.SelectAllTimeLogs(where);

                    // Display all returned rows
                    foreach (var log in logs)
                    {
                        string[] attributes = {
                            DatabaseHelper.SelectEmployee(log.getEmployeeID()).getEmpName(),
                            log.getCheckIn() == default(DateTime) ? "" : log.getCheckIn().ToString(),
                            log.getCheckOut() == default(DateTime) ? "" : log.getCheckOut().ToString()
                        };
                        lv.Items.Add(log.getLogID().ToString()).SubItems.AddRange(attributes);
                    }
                    break;
                case Tables.JOB:
                    var jobs = DatabaseHelper.SelectAllJobs(where);

                    // Display all returned rows
                    foreach (var job in jobs)
                    {
                        string[] attributes = {
                            job.getJobTitle(),
                            job.getBasePayrate().ToString()
                        };
                        lv.Items.Add(job.getJobID().ToString()).SubItems.AddRange(attributes);
                    }
                    break;
            }
        }

        public string getSearchQuery(string value)
        {
            string halfQuery = " where ";
            switch (currTbl)
            {
                // TODO: get correct query for each case
                case Tables.EMPLOYEE:
                case Tables.ISSUE:
                case Tables.TIMELOG:
                    halfQuery += "empName";
                    break;
                case Tables.JOB:
                    halfQuery += "jobTitle";
                    break;
            }
            return halfQuery + " = \"" + value + "\"";
        }
    }
}