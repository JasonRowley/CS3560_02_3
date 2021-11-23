using GroupProjCS3560num2.Database;
using System;
using System.Collections.Generic;
using System.Text;

using GroupProjCS3560num2.Forms;

namespace GroupProjCS3560num2.Classes.Handlers
{
    public class TotalPayHandler
    {
        public static List<Employee> GetAllEmp()
        {
            return DatabaseHelper.SelectAllEmployees();
        }

        public static double GetBasePay(Employee emp)
        {
            return DatabaseHelper.SelectJob(emp.getJobID()).getBasePayrate();
        }

        public static double GetTotalHours(DateTime start, DateTime end, Employee emp)
        {
            List<TimeLog> timelogs =
                DatabaseHelper.SelectAllTimeLogs(string.Format(" where employeeID = {0}", emp.getEmployeeID()));

            double total = 0.0;
            for(int i = 0; i < timelogs.Count; i++)
            {
                if (timelogs[i].getCheckOut() == default(DateTime))
                {
                    continue;
                }
                else if(timelogs[i].getCheckIn() > start &&
                    timelogs[i].getCheckOut() < end) //timelog between start and end
                {
                    total = total + (timelogs[i].getCheckOut() - timelogs[i].getCheckIn()).TotalHours;
                }
                else if(timelogs[i].getCheckIn() < start &&
                    timelogs[i].getCheckOut() > start) //timelog overlapping start
                {
                    total = total + (timelogs[i].getCheckOut() - start).TotalHours;
                }
                else if(timelogs[i].getCheckIn() < end &&
                    timelogs[i].getCheckOut() > end) //timelog overlapping end
                {
                    total = total + (end - timelogs[i].getCheckIn()).TotalHours;
                }
            }
            return total;
        }





    }
}