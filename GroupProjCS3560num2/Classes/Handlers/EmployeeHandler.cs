using GroupProjCS3560num2.Database;
using System;
using System.Collections.Generic;
using System.Text;

namespace GroupProjCS3560num2.Classes.Handlers
{
    class EmployeeHandler
    {
        public static int AddEmployee(int jobID, string phoneNumber, double adjustment, DateTime dateOfBirth, String empName, 
            String physicalAddress, String email, String bankAccNum, String sSN, String password)
        {
            Employee emp = new Employee(adjustment, dateOfBirth, empName, physicalAddress, email, bankAccNum, sSN, password);

            DatabaseHelper.InsertEmployee(emp);

            return 0;
        }
    }
}
