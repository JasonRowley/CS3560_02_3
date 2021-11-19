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


        public Issue( int employeeID, string issueStr)    // added for convient 
        {
            this.adminID = 2;      // <--- place holder due to adminID being a forign key referencing employeeID
            this.solved = false ;
            this.employeeID = employeeID;
            this.issueStr = issueStr;
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

        public void setEmployeeID(int employeeId)
        {
            this.employeeID = employeeID;
        }

        public void setAdminID(int adminId)
        {
            this.adminID = adminId;
        }

        public void setIssueStr(string issueStr)
        {
            this.issueStr = issueStr;
        }

        public void setSolved(bool solved)
        {
            this.solved = solved;
        }


    }
}
