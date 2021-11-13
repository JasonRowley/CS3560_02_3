using System;
using System.Collections.Generic;
using System.Text;


namespace GroupProjCS3560num2.Classes
{
    class Employee
    {

        int employeeID;
        int jobID;
        String pw;
        String empName;
        String physicalAddress;
        String email;
        int phoneNumber;
        DateTime dateOfBirth;
        String bankAccNum;
        String sSN;
        double adjustment;




        public Employee(){}  


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
            this.email = email;
            this.phoneNumber = phoneNumber;
            this.dateOfBirth = dateOfBirth;
            this.bankAccNum = bankAccNum;
            this.sSN = sSN;
            this.adjustment = adjustment;
        }


   


        public int getEmployeeID()
        {
            return employeeID;
        }

        public void setEmployeeID(int employeeID)
        {
            this.employeeID = employeeID;
        }

        public int getJobID()
        {
            return jobID;
        }

        public void setJobID(int jobID)
        {
            this.jobID = jobID;
        }

        public String getPw()
        {
            return pw;
        }

        public void setPw(String pw)
        {
            this.pw = pw;
        }

        public String getEmpName()
        {
            return empName;
        }

        public void setEmpName(String empName)
        {
            this.empName = empName;
        }

        public String getPhysicalAddress()
        {
            return physicalAddress;
        }

        public void setPhysicalAddress(String physicalAddress)
        {
            this.physicalAddress = physicalAddress;
        }

        public String getEmail()
        {
            return email;
        }

        public void setEmail(String email)
        {
            this.email = email;
        }

        public int getPhoneNumber()
        {
            return phoneNumber;
        }

        public void setPhoneNumber(int phoneNumber)
        {
            this.phoneNumber = phoneNumber;
        }

        public String getBankAccNum()
        {
            return bankAccNum;
        }

        public void setBankAccNum(String bankAccNum)
        {
            this.bankAccNum = bankAccNum;
        }

        public String getSSN()
        {
            return sSN;
        }

        public void setSSN(String sSN)
        {
            this.sSN = sSN;
        }

        public double getAdjustment()
        {
            return adjustment;
        }

        public void setAdjustment(double adjustment)
        {
            this.adjustment = adjustment;
        }


        public DateTime getDateOfBirth()
        {

            return dateOfBirth;
        }

        public void setDateOfBirth(DateTime dateOfBirth)
        {
            this.dateOfBirth = dateOfBirth;
        
        }


    }





}
