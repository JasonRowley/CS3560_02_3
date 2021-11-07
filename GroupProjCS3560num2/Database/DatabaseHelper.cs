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
        static string server = "localhost";
        static string userId = "root";
        static string pw1 = "password1";
        static string schema = "employee_schema";

        static void ConnectMySql(string insert_Sql_cmd)
        {
            string con = "server=" + server + "; userid=" + userId + "; password=  " + pw1 + "; database = " + schema;
            using (var sqlCon = new MySqlConnector.MySqlConnection(con))
            {
                using (var cmd = new MySqlConnector.MySqlCommand(insert_Sql_cmd, sqlCon))
                {
                    sqlCon.Open();
                    cmd.ExecuteNonQuery();
                    sqlCon.Close();
                }
            }
        }

        static T ConnectMySql<T>(string insert_Sql_cmd, Func<MySqlConnector.MySqlDataReader, T> setter)
        {
            T toReturn = default(T);
            string con = "server=" + server + "; userid=" + userId + "; password=  " + pw1 + "; database = " + schema;
            using (var sqlCon = new MySqlConnector.MySqlConnection(con))
            {
                using (var cmd = new MySqlConnector.MySqlCommand(insert_Sql_cmd, sqlCon))
                {
                    sqlCon.Open();
                   
                    MySqlConnector.MySqlDataReader myReader = cmd.ExecuteReader();
                    try
                    {
                        // Loop through each queried row
                        while (myReader.Read())
                        {
                            toReturn = setter(myReader);
                        }
                    }
                    finally
                    {
                        myReader.Close();
                        sqlCon.Close();
                    }
                }
            }
            return toReturn;
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
            string str = string.Format("select * from TimeLog where logID in (select MAX(logID) from TimeLog group by employeeID) and employeeID = {0};", employeeID);
            return ConnectMySql<TimeLog>(str, (myReader) =>
            {
                return myReader.IsDBNull(3) ? null : new TimeLog(
                                myReader.GetInt32("logID"), 
                                myReader.GetInt32("employeeID"), 
                                myReader.GetDateTime("checkIn"), 
                                myReader.GetDateTime("checkOut"));
            });
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

           string cmd1 = string.Format("insert Employee(jobID, pw, empName, physicalAddress, emailAddress, phoneNumber, dateOfBirth, bankAccNumber, sSN, adjustment) value({0}, '{1}','{2}', '{3}', '{4}', {5}, '{6}', '{7}', '{8}', {9}) ", employee.getJobID(), employee.getPassword(), employee.getEmpName(), employee.getPhysicalAddress(), employee.getEmailAddress(), employee.getPhoneNumber(), employee.getDateOfBirth(), employee.getBankAccNumber(), employee.getSSN(), employee.getAdjustment());
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
            string cmd = string.Format("insert into Job(jobTitle, basePayrate) value ('{0}', {1:C2});", job.getJobTitle(), job.getBasePayrate());
            ConnectMySql(cmd);

            return 0;
        }

        static TimeLog[] SelectAllTimeLogs()
        {
            string cmd = string.Format("select * from TimeLog;");
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
            string cmd = string.Format("insert into Issue(employeeID, adminID, issueStr, solved) value ({0}, {1}, '{2}', {3});", issue.getEmployeeID(), issue.getAdminID(), issue.getIssueStr(), issue.isSolved());
            ConnectMySql(cmd);

            return 0;
        }
    }
}