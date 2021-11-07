using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Text;


namespace GroupProjCS3560num2.Classes
{
    class Employee
    {

        private int employeeID;
        private int jobID;
        private string pw;
        private string empName;
        private string physicalAddress;
        private string emailAddress;
        private int phoneNumber;
        private string dateOfBirth;
        private string bankAccNumber;
        private string sSN;
        private double adjustment;



        public Employee(int insertEmployeeID)
        {
            getEmployeeInformation(insertEmployeeID);
        }





        private void getEmployeeInformation(int insertEmployeeID)
        {
     
            string conn = "server=localhost; userid=root; password=  " + pw1 + "; database = employee_schema";    //<---- ask to make a class to replace this line for security
            using (var con = new MySqlConnection(conn))
            {
                string str = string.Format("select * from Employee where employeeID = " + insertEmployeeID);
                using (var cmd = new MySqlCommand(str, con))
                {
                    con.Open();

                    MySqlDataReader myReader = cmd.ExecuteReader();
                    try
                    {
                        // Always call Read before accessing data.
                        while (myReader.Read())
                        {
                            this.jobID = myReader.GetInt32("jobID");
                            this.pw = myReader.GetString("pw");
                            this.empName = myReader.GetString("empName");
                            this.physicalAddress = myReader.GetString("physicalAddress");
                            this.emailAddress = myReader.GetString("emailAddress");
                            this.phoneNumber = myReader.GetInt32("phoneNumber");
                            //this.dateOfBirth = myReader.GetString("dateOfBirth");    <--- adjust later            
                            this.bankAccNumber = myReader.GetString("bankAccNumber");
                            this.sSN = myReader.GetString("sSN");
                            this.adjustment = myReader.GetDouble("adjustment");
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

        //public getters
        public int getEmployeeID()
        {
            return employeeID;
        }

        public int getJobID()
        {
            return jobID;
        }

        public string getPassword()
        {
            return pw;
        }

        public string getEmpName()
        {
            return empName;
        }

        public string getPhysicalAddress()
        {
            return physicalAddress;
        }

        public string getEmailAddress()
        {
            return emailAddress;
        }
        public int getPhoneNumber()
        {
            return phoneNumber;
        }

        public string getDateOfBirth()
        {
            return dateOfBirth;
        }

        public string getBankAccNumber()
        {
            return bankAccNumber;
        }

        public string getSSN()
        {
            return sSN;
        }
        public double getAdjustment()
        {
            return adjustment;
        }




        private void setFunctionHelper<T>(int employeeID, string tableAttribute, T insertChange)
        {
            //ConnectSql sqlConnection = new ConnectSql();
            //string con = sqlConnection.open();

            string con = "server=localhost; userid=root; password=  " + pw1 + "; database = employee_schema";
            using var sqlCon = new MySqlConnection(con);
            sqlCon.Open();
            using var cmd = new MySqlCommand();
            cmd.Connection = sqlCon;
            cmd.CommandText = string.Format("update employee set " + tableAttribute + " = '{0}'  where employeeID = {1}", insertChange, employeeID);
            cmd.ExecuteNonQuery();

        }


        //public setters
        public void setEmployeeID(int employeeID, int newID)
        {
            setFunctionHelper(employeeID, "employeeID", newID);
        }

        public void setJobID(int employeeID, int newJobID)
        {
            setFunctionHelper(employeeID, "jobID", newJobID);
        }

        public void setPw(int employeeID, string newPW)
        {
            setFunctionHelper(employeeID, "pw", newPW);
        }

        public void setEmpName(int employeeID, string newName)
        {
            setFunctionHelper(employeeID, "empName", newName);
        }

        public void setPhysicalAddress(int employeeID, string newAddress)
        {
            setFunctionHelper(employeeID, "physicalAddress", newAddress);
        }

        public void setEmailAddress(int employeeID, string newEmail)
        {
            setFunctionHelper(employeeID, "emailAddress", newEmail);
        }

        public void setPhoneNumber(int employeeID, long newPhoneNumber)         // <======= phone may need to be set to long
        {
            setFunctionHelper(employeeID, "phoneNumber", newPhoneNumber);
        }

        public void setDateOfBirth(int employeeID, string newDateOFBirth)       // <==== adjust later 
        {
            setFunctionHelper(employeeID, "dateOfBirth", newDateOFBirth);
        }

        public void setBankAccNumber(int employeeID, string newBankNumber)
        {
            setFunctionHelper(employeeID, "bankAccNumber", newBankNumber);
        }

        public void setsSN(int employeeID, string newEmployeeID)
        {
            setFunctionHelper(employeeID, "sSN", newEmployeeID);
        }

        public void setAdjustment(int employeeID, double newAdjustment)
        {
            setFunctionHelper(employeeID, "adjustment", newAdjustment);
        }


    }





}
