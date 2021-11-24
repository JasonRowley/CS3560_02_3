using System;
using System.Collections.Generic;
using System.Text;

namespace GroupProjCS3560num2.Classes
{
    public class TimeLog
    {
        int logID;
        int employeeID;
        DateTime checkIn;
        DateTime checkOut;

        public TimeLog(int logID, int employeeID, DateTime checkIn, DateTime checkOut = default(DateTime))
        {
            this.logID = logID;
            this.employeeID = employeeID;
            this.checkIn = checkIn;
            this.checkOut = checkOut;
        }
        public TimeLog() { }

        public int getLogID()
        {
            return logID;
        }

        
        public int getEmployeeID()
        {
            return employeeID;
        }

        public DateTime getCheckIn()
        {
            return checkIn;
        }


        public DateTime getCheckOut()
        {
            return checkOut;
        }

        public void setLogID(int logID)
        {
            this.logID = logID;
        }

        public void setEmployeeID(int employeeID)
        {
            this.employeeID = employeeID;
        }

        public void setCheckIn(DateTime checkIn)
        {
            this.checkIn = checkIn;
        }
        public void setCheckOut(DateTime checkOut)
        {
            this.checkOut = checkOut;
        }

        //public double getSessionTime()
        //{
        //    DateTime diff = checkOut.Subtract(checkIn);
        //    return diff.Hour + (diff.Minute) / 60.0;
        //}

    }
}
