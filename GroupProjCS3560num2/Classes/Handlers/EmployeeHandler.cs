using GroupProjCS3560num2.Database;
using System;
using System.Collections.Generic;
using System.Text;
using GroupProjCS3560num2.Classes.Handlers;
using GroupProjCS3560num2.Forms;


namespace GroupProjCS3560num2.Classes.Handlers
{
    class EmployeeHandler
    {
        public static int addEmployee(int employeeID, int jobID, String password, String empName, String physicalAddress, String email, string phoneNumber, DateTime dateOfBirth,  
            String bankAccNum, String sSN, double adjustment)
        {
            Employee emp = new Employee(employeeID, jobID, password, empName, physicalAddress, email, phoneNumber, dateOfBirth, bankAccNum, sSN, adjustment);
            DatabaseHelper.InsertEmployee(emp);

            return 0;
        }

        public static int updateEmployee(int employeeID, int jobID, String password, String empName, String physicalAddress, String email, string phoneNumber, DateTime dateOfBirth,
            String bankAccNum, String sSN, double adjustment)
        {
            Employee emp = new Employee(employeeID, jobID, password, empName, physicalAddress, email, phoneNumber, dateOfBirth, bankAccNum, sSN, adjustment);
            DatabaseHelper.UpdateEmployee(emp);

            return 0;
        }

        public static int deleteEmployee(int employeeID)
        {
            DatabaseHelper.DeleteEmployee(employeeID);

            return 0;
        }
    }
}
