using System;
using System.Collections.Generic;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using GroupProjCS3560num2.Database;


namespace GroupProjCS3560num2.Classes.Handlers
{
   public static class IssueHandler
    {
        // adding issue to the Data base 

        // 1) DatabaseHelper


        public static int AddIssue(int employeeId, int adminID, string message)
        {
            Issue bob = new Issue(-1, employeeId, adminID, message, false);
            DatabaseHelper.InsertIssue(bob);
            
            return 0;
        }

        public static List<Employee> GetAllAdmin()
        {
            var adminJobID = DatabaseHelper.SelectAllJobs(" where jobTitle = 'admin';")[0].getJobID();
            return DatabaseHelper.SelectAllEmployees(string.Format(" where jobID = {0}", adminJobID));
        }
    }
}
