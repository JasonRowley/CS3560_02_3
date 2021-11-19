using GroupProjCS3560num2.Database;
using System;
using System.Collections.Generic;
using System.Text;

namespace GroupProjCS3560num2.Classes.Handlers
{
    public static class ClockInClockOutHandler
    {
        public const int failed = -1;
        public const int clockIn = 1;
        public const int clockOut = 0;
        public static int EnterPin(int empID)
        {
            //check if employee ID maps to one in database
            if(null == DatabaseHelper.SelectEmployee(empID))
            {
                return failed;
            }

            TimeLog tempTimeLog = DatabaseHelper.VerifyTimeLog(empID);
            if (tempTimeLog.getCheckOut() == default(DateTime))
            {
                //set checkout time to current time
                DateTime localTime = DateTime.Now;
                tempTimeLog.setCheckOut(localTime);

                //update the timelog to complete it.
                DatabaseHelper.UpdateTimeLog(tempTimeLog);

                return clockOut;
            }

            else
            {
                //Insert a new TimeLog into database
                tempTimeLog = new TimeLog();
                DatabaseHelper.InsertTimeLog(tempTimeLog);

                return clockIn;
            }

          
        }
    }
}
