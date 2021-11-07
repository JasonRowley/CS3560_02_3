using System;
using System.Collections.Generic;
using System.Text;
using MySqlConnector;

namespace GroupProjCS3560num2.Forms
{
    class Job
    {
        int jobID;
        string jobTitle;
        double basePayrate;




        // empty constructor 
        public Job()
        {

        }


        // this constructor is use with jobID and will grab all information about that job. 
        public Job(int jobID)
        {
            this.jobID = jobID;
            getJobInfo(jobID);
        }





        // function to add job to MySQL table 
        // be mindful that jobID must be unique, otherwise program will crash. 
        public void setNewJob_WITH_newID(int jobID, string jobTitle, double basePayrate)
        {
            //ConnectSql sqlConnection = new ConnectSql();
            //string con = sqlConnection.open();
            string con = "server=localhost; userid=root; password=  " + pw1 + "; database = employee_schema";
            using var sqlCon = new MySqlConnection(con);
            sqlCon.Open();
            using var cmd = new MySqlCommand();
            cmd.Connection = sqlCon;
            cmd.CommandText = string.Format("insert jobs(jobID, jobTitle, basePayrate) value ({0}, '{1}', {2})", jobID, jobTitle, basePayrate);
            cmd.ExecuteNonQuery();
        }





        // function to add job to MySQL table  without having to add jobID number
        public void setNewJob(string jobTitle, double basePayrate)
        {
            //ConnectSql sqlConnection = new ConnectSql();
            //string con = sqlConnection.open();
            string con = "server=localhost; userid=root; password=  " + pw1 + "; database = employee_schema";
            using var sqlCon = new MySqlConnection(con);
            sqlCon.Open();
            using var cmd = new MySqlCommand();
            cmd.Connection = sqlCon;
            cmd.CommandText = string.Format("insert jobs(jobTitle, basePayrate) value ( '{0}', {1})", jobTitle, basePayrate);
            cmd.ExecuteNonQuery();

        }










        private void getJobInfo(int insert_JobID)
        {
            //TimeLog tempTimeLog = new TimeLog();
            //Employee tempEmployee = new Employee();
            //tempEmployee = SelectEmployee(employeeID);
            //string cmd = string.Format("select * from TimeLog where logID in (select MAX(logID) from TimeLog group by employeeID) and employeeID = {0};", employeeID);
            //tempTimeLog = ConnectMySql(cmd);
            

            string conn = "server=localhost; userid=root; password=  " + pw1 + "; database = employee_schema";
            //ConnectSql sqlConnection = new ConnectSql();
            //string conn = sqlConnection.open();
            using (var con = new MySqlConnection(conn))
            {
                string str = string.Format("select * from jobs where jobID = " + insert_JobID);
                using (var cmd = new MySqlCommand(str, con))
                {
                    con.Open();
                    MySqlDataReader myReader = cmd.ExecuteReader();
                    try
                    {
                        // Always call Read before accessing data.
                        while (myReader.Read())
                        {
                            this.jobTitle = myReader.GetString("jobTitle");
                            this.basePayrate = myReader.GetDouble("basePayrate");
                        }
                    }
                    finally
                    {
                        // always call Close when done reading.
                        myReader.Close();

                        // Close the connection when done with it.
                        con.Close();
                    }
                }
            }
        }




        //getters
        public int getJobID()
        {
            return jobID;
        }


        public string getJobTitle()
        {
            return jobTitle;
        }

        public double getBasePayRate()
        {
            return basePayrate;
        }








        // helper function to update/edit jobTitle and/or basePay. Requires jobID 
        private void setFunctionHelper<T>(int jobID, string tableAttribute, T insertChange)
        {
            //ConnectSql sqlConnection = new ConnectSql();
            //string con = sqlConnection.open();
            string con = "server=localhost; userid=root; password=  " + pw1 + "; database = employee_schema";
            using var sqlCon = new MySqlConnection(con);
            sqlCon.Open();
            using var cmd = new MySqlCommand();
            cmd.Connection = sqlCon;
            cmd.CommandText = string.Format("update jobs set " + tableAttribute + " = '{0}'  where jobID = {1}", insertChange, jobID);
            cmd.ExecuteNonQuery();

        }




        public void setJobTitle(int jobID, string newJobTitle)
        {
            setFunctionHelper(jobID, "jobTitle", newJobTitle);
        }


        public void setBasePayRate(int jobID, double newBasePayRate)
        {
            setFunctionHelper(jobID, "basePayrate", newBasePayRate);
        }


        public void setJobID(int jobID, int newJobID)  // <---- this is to edit current jobID to something else. 
        {
            setFunctionHelper(jobID, "jobID", newJobID);

        }


    }
}
