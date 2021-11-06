using GroupProjCS3560num2.Classes;
using GroupProjCS3560num2.Forms;
using System;
using System.Collections.Generic;
using System.Text;

namespace GroupProjCS3560num2.Database
{
    static class DatabaseHelper
    {
        /*
         * String interpreter methods:
         * ---------------------------
           We need to implement toJSON -> Employee class
           We need to implement toJSON -> Jobs class
           We need to implement toJSON -> Issues class
           We need to implement toJSON -> TimeLog class

           We need to implement fromJSON -> Employee class
           We need to implement fromJSON -> Jobs class
           We need to implement fromJSON -> Issues class
           We need to implement fromJSON -> TimeLog class

            general inquary methods:
            ------------------------
            Delete
            Insert
            Update
            QueryAll
            QueryOne
            
         */
        private string server = "localhost";
        private string userId = "root";
        private string pw = "password1";
        private string schema = "employee_schema";

        static void ConnectMySql(string insert_Sql_cmd)      // <--- make sure to provide correct cmd string when calling this function
        {
            string con = "server=" + server + "; userid=" + userId + "; password=  " + pw + "; database = " + schema;  //<---- make sure password and schema is correct
            using var sqlCon = new MySqlConnection(con);
            sqlCon.Open();
            using var cmd = new MySqlCommand();
            cmd.Connection = sqlCon;
            cmd.CommandText = insert_Sql_cmd;
            cmd.ExecuteNonQuery();
            sqlCon.Close();
        }


        public static Employee VerifyPassword(int employeeID, string password)
        {
            
            Employee tempEmployee = new Employee();

            tempEmployee = SelectEmployee(employeeID);

            if (password != tempEmployee.getPassword())
            {
                return null;
                
            }
            return tempEmployee;
        }
        public static TimeLog VerifyTimeLog(int employeeID)
        {
            TimeLog tempTimeLog = new TimeLog();
            Employee tempEmployee = new Employee();

            tempEmployee = SelectEmployee(employeeID);
            tempTimeLog = SelectTimeLog()
            return null;
                       
        }



        static Employee[] SelectAllEmployees()
        {
            return null;
        }
        static Employee SelectEmployee(int employeeID)
        {
            string cmd = string.Format("select * from Employee where employeeID = {0};", employeeID);
            ConnectMySql(cmd);
            
            return null;
        }
        static int DeleteEmployee(int employeeID)
        {
            string cmd = string.Format("delete from Employee where employeeID = {0};", employeeID);
            ConnectMySql(cmd);

            return 0;
        }
        static int UpdateEmployee(Employee employee)
        {
            string cmd = string.Format("update Employee set employeeID = {0}, jobId = {1}, password = '{2}, empName = '{3}', physicalAddress = '{4}', " +
                "emailAddress = '{5}', phoneNumber = {6}, dateOfBirth = '{7}', bankAccNumber = '{8}', sSN = '{9}', adjustment = {10};", employee.getEmployeeID(),
                employee.getJobID(), employee.getPassword(), employee.getEmpName(), employee.getPhysicalAddress(), employee.getEmailAddress(), employee.getPhoneNumber(),
                employee.getDateOfBirth(), employee.getBankAccNumber(), employee.getSSN(), employee.getAdjustment());
            ConnectMySql(cmd);

            return 0;
        }
        static int InsertEmployee(Employee employee)
        {

           string cmd1 = string.Format("insert Employee(jobID, pw, empName, physicalAddress, emailAddress, phoneNumber, dateOfBirth, bankAccNumber, sSN, adjustment) value({0}, '{1}','{2}', '{3}', '{4}', {5}, '{6}', '{7}', '{8}', {9}) ", jobID, password, empName, physicalAddress, emailAddress, phoneNumber, dateOfBirth, bankAccNumber, sSN, adjustment);
           ConnectMySql(cmd1);

            return 0;
        }


        static Job[] SelectAllJobs()
        {
            return null;
        }
        static Job SelectJob(int jobID)
        {
            string cmd = string.Format("select * from Job where jobID = {0};", jobID);
            ConnectMySql(cmd);

            return null;
        }
        static int DeleteJob(int jobID)
        {
            string cmd = string.Format("delete from Job where jobID = {0};", jobID);
            ConnectMySql(cmd);

            return 0;
        }
        static int UpdateJob(Job job)
        {
            string cmd = string.Format("update Job set jobId = {0}, jobTitle = '{1}', basePayrate = {2};", job.getJobId(), job.getJobTitle(), job.getBasePayrate());
            ConnectMySql(cmd);

            return 0;
        }
        static int InsertJob(Job job)
        {
            string cmd = string.Format("insert into Job(jobTitle, basePayrate) value ('{0}', {1:C2});", job.getJobTitle(), job.getPayrate());
            ConnectMySql(cmd);

            return 0;
        }


        static TimeLog[] SelectAllTimeLogs()
        {
            string cmd = string.Format("select * from TimeLog where logId = {0};", logID);
            ConnectMySql(cmd);

            return null;
        }
        static TimeLog SelectTimeLog(int logID)
        {
            string cmd = string.Format("select * from TimeLog where logId = {0};", logID);
            ConnectMySql(cmd);

            return null;
        }
        static int DeleteTimeLog(int logID)
        {
            string cmd = string.Format("delete from TimeLog where logID = {0};", logID);
            ConnectMySql(cmd);

            return 0;
        }
        static int UpdateTimeLog(TimeLog log)
        {

            return 0;
        }
        static int InsertTimeLog(TimeLog log)
        {
            return 0;
        }


        static Issue[] SelectAllIssues()
        {
            string cmd = string.Format("select * from Issue;");
            ConnectMySql(cmd);

            return null;
        }
        static Issue SelectIssue(int issueID)
        {
            string cmd = string.Format("select * from Issue where issueId = {0};", issueID);
            ConnectMySql(cmd);

            return null;
        }
        static int DeleteIssue(int issueID)
        {
            string cmd = string.Format("delete from Issue where issueId = {0};", issueID);
            ConnectMySql(cmd);

            return 0;
        }
        static int UpdateIssue(Issue issue)
        {
            string cmd = string.Format("update Issue set employeeID = {0}, adminID = {1}, issueStr = {2}, solved = {3} where issueID = {4};", issue.getEmployeeID(), issue.getAdminID(), issue.getIssueStr(), issue.isSolved(), issue.getIssueID());
            ConnectMySql(cmd);

            return 0;
        }
        static int InsertIssue(Issue issue)
        {
            string cmd = string.Format("insert into Issue(employeeID, adminID, issueStr, solved) value ({0}, {1}, '{2}', {3});", issue.getEmployeeID, issue.getAdminID, issue.getIssueStr, issue.isSolved());
            ConnectMySql(cmd);

            return 0;
        }

    }
}