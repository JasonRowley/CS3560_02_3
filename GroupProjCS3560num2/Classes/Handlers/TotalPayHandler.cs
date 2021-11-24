using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using GroupProjCS3560num2.Database;
using GroupProjCS3560num2.Forms;

namespace GroupProjCS3560num2.Classes.Handlers
{
    public class TotalPayHandler
    {
        ListView lv;
        public TotalPayHandler(ListView lv)
        {
            this.lv = lv;
            lv.Columns.Clear();
            for (int i = 0; i < 8; i++)
            {
                lv.Columns.Add(new ColumnHeader());
            }
            lv.Columns[0].Name = "employeeID";
            lv.Columns[0].Text = "ID";
            lv.Columns[0].Width = 30;

            lv.Columns[1].Name = "employeeName";
            lv.Columns[1].Text = "Name";
            lv.Columns[1].Width = 100;

            lv.Columns[2].Name = "job";
            lv.Columns[2].Text = "Job";
            lv.Columns[2].Width = 75;

            lv.Columns[3].Name = "basePay";
            lv.Columns[3].Text = "Base";
            lv.Columns[3].Width = 50;

            lv.Columns[4].Name = "ajd";
            lv.Columns[4].Text = "Adj";
            lv.Columns[4].Width = 50;

            lv.Columns[5].Name = "hourlyRate";
            lv.Columns[5].Text = "Hr Rate";
            lv.Columns[5].Width = 50;

            lv.Columns[6].Name = "totalH";
            lv.Columns[6].Text = "Total Hr";
            lv.Columns[6].Width = 75;

            lv.Columns[7].Name = "totalP";
            lv.Columns[7].Text = "Total Pay";
            lv.Columns[7].Width = 75;

        }
        public static void updateTable(ListView lv, DateTime start, DateTime end)
        {
            List<Employee> employees = GetAllEmp();
            lv.Items.Clear();
            for(int i = 0; i < employees.Count; i++)
            {
                Employee emp = employees[i];
                DateTime confirmStartTime = DateTime.Parse(start.ToShortDateString());
                DateTime confirmStopTime = DateTime.Parse(end.ToShortDateString());
                confirmStopTime = confirmStopTime.AddHours(23.0);
                confirmStopTime = confirmStopTime.AddMinutes(59.0);
                confirmStopTime = confirmStopTime.AddSeconds(59.0);
                confirmStopTime = confirmStopTime.AddMilliseconds(59.0);

                double dBasePay = GetBasePay(emp);
                double dAdj = emp.getAdjustment();
                double dHourlyRate = dBasePay + dAdj;
                double dTotalH = GetTotalHours(confirmStartTime, confirmStopTime, emp);
                double dtotalP = dHourlyRate * dTotalH;

                string[] attributes =
                {
                    employees[i].getEmpName().ToString(),
                    DatabaseHelper.SelectJob(employees[i].getJobID()).getJobTitle(),
                    "$ " + dBasePay.ToString(),
                    "$ " + dAdj.ToString(),
                    "$ " + dHourlyRate.ToString(),
                    dTotalH.ToString("0.00") + " Hr",
                    "$ " + dtotalP.ToString("0.00")
                };
                lv.Items.Add(emp.getEmployeeID().ToString()).SubItems.AddRange(attributes);
            }
        }




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
            // Local Variables
            double total = 0.0;
            long elapsedTicks = end.Ticks - start.Ticks;
            TimeSpan elapsedSpan = new TimeSpan(elapsedTicks);
            long timeStep = TimeSpan.TicksPerSecond;
            double dblStep = timeStep * 1.0;
            double ticksPerHr = TimeSpan.TicksPerHour * 1.0;

            // Get all time logs that overlap with the passed interval
            string startStr = start.ToString("yyyy-MM-dd HH:mm:ss");
            string endStr = end.ToString("yyyy-MM-dd HH:mm:ss");
            string cond = string.Format(" where employeeID = {0} and checkIn <= '{1}' and checkOut >= '{2}'", emp.getEmployeeID(), endStr, startStr);
            List<TimeLog> timelogs = DatabaseHelper.SelectAllTimeLogs(cond);

            // Calculate total hours
            long ticks = 0;
            while (ticks < elapsedTicks)
            {
                // Check each TimeLog to see if current date is within the log's interval
                foreach (var log in timelogs)
                {
                    if ((log.getCheckIn().Ticks <= (ticks + start.Ticks)) && (log.getCheckOut().Ticks >= (ticks + start.Ticks)))
                    {
                        total += dblStep / ticksPerHr;
                    }
                }
                
                ticks += timeStep;
            }
            return total;
        }





    }
}