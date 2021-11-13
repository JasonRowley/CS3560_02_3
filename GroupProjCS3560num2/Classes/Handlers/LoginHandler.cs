using GroupProjCS3560num2.Database;
using GroupProjCS3560num2.Classes;
using System;
using System.Collections.Generic;
using System.Text;

namespace GroupProjCS3560num2.Classes.Handlers
{
    public static class LoginHandler
    {

        public static Employee Login(int empID, String pass)
        {
            Employee tempEmployee = DatabaseHelper.VerifyPassword(empID, pass);
            if(null == tempEmployee)
            {
                return null;
            }
           
            return tempEmployee;
        }
    }
}
