using GroupProjCS3560num2.Database;
using System;
using System.Collections.Generic;
using System.Text;

namespace GroupProjCS3560num2.Classes.Handlers
{
    class EmployeeHandler
    {
        public static int AddEmployee(int employeeID, int jobID, String password, String empName, String physicalAddress, String email, string phoneNumber, DateTime dateOfBirth,  
            String bankAccNum, String sSN, double adjustment)
        {
            Employee emp = new Employee(employeeID, jobID, password, empName, physicalAddress, email, phoneNumber, dateOfBirth, bankAccNum, sSN, adjustment);

            DatabaseHelper.InsertEmployee(emp);

            return 0;
        }
    }
}