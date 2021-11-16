using GroupProjCS3560num2.Database;
using System;
using System.Collections.Generic;
using System.Text;
//using GroupProjCS3560num2.Classes;

namespace GroupProjCS3560num2.Classes.Handlers
{
    class DisplayEmployeeHandler
    {
        public static List<Employee> DispEmp()
        {
            return DatabaseHelper.SelectAllEmployees();
        }
    }
}
