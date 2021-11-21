using GroupProjCS3560num2.Database;
using System;
using System.Collections.Generic;
using System.Text;

namespace GroupProjCS3560num2.Classes.Handlers
{
    public class TimestampHandler
    {
        public static string GetEmpName(TimeLog timelog)
        {
            return DatabaseHelper.SelectEmployee(timelog.getEmployeeID()).getEmpName();
        }

        public static int GetEmpID(TimeLog timelog)
        {
            return DatabaseHelper.SelectEmployee(timelog.getEmployeeID()).getEmployeeID();
        }

        public static string GetEmpJob(TimeLog timelog)
        {
            string ret =
                DatabaseHelper.SelectJob(DatabaseHelper.SelectEmployee(timelog.getEmployeeID()).getJobID())
            + " (" +
                DatabaseHelper.SelectEmployee(timelog.getEmployeeID()).getJobID()
                + ")";

            return ret;
        }
        public static int getTimestampID(TimeLog timelog)
        {
            return timelog.getLogID();
        }


        public static DateTime GetCheckInTime(TimeLog timelog)
        {
            return DatabaseHelper.SelectTimeLog(timelog.getLogID()).getCheckIn();
        }

        public static DateTime GetCheckOutTime(TimeLog timelog)
        {
            return DatabaseHelper.SelectTimeLog(timelog.getLogID()).getCheckOut();
        }

        public static void UpdateTimestamp(int logID, int empID, DateTime newClockIn, DateTime newClockOut)
        {
            TimeLog newTimeLog = new TimeLog();
            newTimeLog.setLogID(logID);
            newTimeLog.setEmployeeID(empID);
            newTimeLog.setCheckIn(newClockIn);
            newTimeLog.setCheckOut(newClockOut);
            DatabaseHelper.UpdateTimeLog(newTimeLog);
        }
        public static void CreateTimestamp(int empID, DateTime newClockIn, DateTime newClockOut)
        {
            TimeLog newTimeLog = new TimeLog();
            newTimeLog.setLogID(-1);
            newTimeLog.setEmployeeID(empID);
            newTimeLog.setCheckIn(newClockIn);
            newTimeLog.setCheckOut(newClockOut);
            DatabaseHelper.InsertTimeLog(newTimeLog);
        }
        public static void DeleteTimestamp(int logID)
        {
            DatabaseHelper.DeleteTimeLog(logID);
        }

        public static List<Employee> GetAllEmp()
        {
            return DatabaseHelper.SelectAllEmployees();
        }

        

    }
}
