using System;
using System.Collections.Generic;
using System.Text;

namespace GroupProjCS3560num2.Classes
{
    class Employee
    {
        int employeeID;
        int jobID;
        string password;
        string empName;
        string physicalAddress;
        string emailAddress;
        int phoneNumber;
        DateTime dateOfBirth;
        string bankAccNumber;
        string sSN;
        double adjustment;

        public Employee() { }  

        public Employee(
        int employeeID,
        int jobID,
        int phoneNumber,
        double adjustment,
        DateTime dateOfBirth,
        String empName,
        String physicalAddress,
        String email,
        String bankAccNum,
        String sSN,
        String password )
        {
            this.employeeID = employeeID;  // <--- automatically generated
            this.jobID = jobID; 
            this.phoneNumber = phoneNumber;
            this.adjustment = adjustment;
            this.dateOfBirth = dateOfBirth;
            this.empName = empName;
            this.physicalAddress = physicalAddress;
            this.emailAddress = email;
            this.bankAccNumber = bankAccNum;
            this.sSN = sSN;
            this.password = password;


            // insert Employee( pw, empName, physicalAddress, emailAddress, phoneNumber, dateOfBirth, bankAccNumber, sSN, adjustment) value("stringPw", "sringName", "stringAddress", "stringAddress", "int-phoneNumber", "String-sSN", "double-adjustment");
                                                                                                                                                                                                                                                                                                    /// if error, check DOB (might need to use string instead )

            string cmd = string.Format("insert Employee(jobID,  pw, empName, physicalAddress, emailAddress, phoneNumber, dateOfBirth, bankAccNumber, sSN, adjustment) value({0}, '{1}','{2}', '{3}', '{4}', {5}, '{6}', '{7}', '{8}', {9}) ", jobID, password, empName, physicalAddress, emailAddress, phoneNumber, dateOfBirth, bankAccNumber, sSN, adjustment);



            DatabaseHerlp testy = new DatabaseHerlp();

            test.connectMySQL(cmd);



            
        }

        public Employee(int employeeID)
        {
            this.employeeID = employeeID;
        }

        // int jobID;
        // string password;
        // string empName;
        // string physicalAddress;
        // string emailAddress;
        // int phoneNumber;
        // DateTime dateOfBirth;
        // string backAccNumber;
        // string sSN;
        // double adjustmnet)  




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

        
            return password;
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

        public string getDateOfBirth() // public DateTime getDateOfBirth()
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

        public double getTotalHours(DateTime from, DateTime to)
        {
            //
            
        }


    }









        // MySql connection function
        private void connectSql(string insertCmdLine)
        {

             string conn = "server=localhost; userid=root; password=  " + pw + "; database = employee_schema";
            
            double amt;
            using (var con = new MySqlConnection(conn))
            {

                    string cmdLine  = string.Format("select adjustment from Employee where employeeID = ")

                using (var cmd = new MySqlCommand(, con))//change 2 for te parameter asked in the funcion call
                {

                    con.Open();
                    //amt = (cast)cmd.ExecuteScalar();
                    amt = (double)cmd.ExecuteScalar();
                    //textBox1.Text = amt.ToString();
                    con.Close();
                }
                
            }
        }






}
