using System;
using System.Collections.Generic;
using System.Text;

namespace GroupProjCS3560num2.Classes
{
    class Employee
    {
        int employeeID;
        int jobID;
        string pw;
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
        String pw,
        String empName,
        String physicalAddress,
        String email,
        int phoneNumber,
        DateTime dateOfBirth,
        String bankAccNum,
        String sSN,
        double adjustment)
        {
            this.employeeID = employeeID;
            this.jobID = jobID;
            this.pw = pw;
            this.empName = empName;
            this.physicalAddress = physicalAddress;
            this.emailAddress = email;
            this.phoneNumber = phoneNumber;
            this.dateOfBirth = dateOfBirth;
            this.bankAccNumber = bankAccNum;
            this.sSN = sSN;
            this.adjustment = adjustment;
        }

        public Employee(int employeeID)
        {
            this.employeeID = employeeID;
        }

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

        public DateTime getDateOfBirth()
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

        public void setAdjustment(double adj)
        {
            this.adjustment = adj;
        }
    }









        // MySql connection function
        //private void connectSql(string insertCmdLine)
        //{

        //     string conn = "server=localhost; userid=root; password=  " + pw + "; database = employee_schema";
            
        //    double amt;
        //    using (var con = new MySqlConnection(conn))
        //    {

        //            string cmdLine  = string.Format("select adjustment from Employee where employeeID = ")

        //        using (var cmd = new MySqlCommand(, con))//change 2 for te parameter asked in the funcion call
        //        {

        //            con.Open();
        //            //amt = (cast)cmd.ExecuteScalar();
        //            amt = (double)cmd.ExecuteScalar();
        //            //textBox1.Text = amt.ToString();
        //            con.Close();
        //        }
                
        //    }
        //}






}
