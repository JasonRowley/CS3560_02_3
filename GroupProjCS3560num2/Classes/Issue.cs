using System;
using System.Collections.Generic;
using System.Text;

namespace GroupProjCS3560num2.Classes
{
    public class Issue
    {
        int issueID;
        int employeeID;
        int adminID;
        string issueStr;
        bool solved;

        public Issue(int issueID, int employeeID, int adminID, string issueStr, bool solved)
        {
            this.issueID = issueID;
            this.employeeID = employeeID;
            this.adminID = adminID;
            this.issueStr = issueStr;
            this.solved = solved;
        }

        public int getIssueID()
        {
            return issueID;
        }

        public int getEmployeeID()
        {
            return employeeID;
        }

        public int getAdminID()
        {
            return adminID;
        }

        public string getIssueStr()
        {
            return issueStr;
        }

        public bool isSolved()
        {
            return solved;
        }
    
    
    }
}
