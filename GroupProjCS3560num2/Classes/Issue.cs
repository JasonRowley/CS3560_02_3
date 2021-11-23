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

        public void setIssueID(int issueID)
        {
            this.issueID = issueID;
        }

        public void setEmployeeID(int empID)
        {
            employeeID = empID;
        }
    
        public void setAdminID(int adminID)
        {
            this.adminID = adminID;
        }

        public void setIssueStr(string str)
        {
            issueStr = str;
        }
    
        public void setSolved(bool solved)
        {
            this.solved = solved;
        }
    }
}
