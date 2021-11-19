using System;
using System.Collections.Generic;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using GroupProjCS3560num2.Database;


namespace GroupProjCS3560num2.Classes.Handlers
{
   public static  class IssueHandler
    {



        // adding issue to the Data base 

        // 1) DatabaseHelper


        public static int AddIssue(int employeeId, string message)
        {

            Issue bob = new Issue(employeeId, message);
            DatabaseHelper.InsertIssue(bob);
            
            return 0;
        }


               





    }
}
