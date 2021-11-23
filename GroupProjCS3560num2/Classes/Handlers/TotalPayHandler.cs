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
                Employee emp = TotalPayHandler.GetAllEmp()[i];
                DateTime confirmStartTime = DateTime.Parse(start.ToShortDateString());
                DateTime confirmStopTime = DateTime.Parse(end.ToShortDateString());
                confirmStopTime = confirmStopTime.AddHours(23.0);
                confirmStopTime = confirmStopTime.AddMinutes(59.0);
                confirmStopTime = confirmStopTime.AddSeconds(59.0);
                confirmStopTime = confirmStopTime.AddMilliseconds(59.0);

                double dBasePay = TotalPayHandler.GetBasePay(emp);
                double dAdj = emp.getAdjustment();
                double dHourlyRate = dBasePay + dAdj;
                double dTotalH = TotalPayHandler.GetTotalHours
                    (confirmStartTime, confirmStopTime, emp);
                double dtotalP = dHourlyRate * dTotalH;

                string[] attributes =
                {
                    employees[i].getEmpName().ToString(),
                    DatabaseHelper.SelectJob(employees[i].getJobID()).getJobTitle(),
                    "$ " + dBasePay.ToString(),
                    "$ " + dAdj.ToString(),
                    dHourlyRate.ToString() + " Hr",
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
                    timelogs[i].getCheckOut() < end) //cond A
                {
                    total = total + (timelogs[i].getCheckOut() - timelogs[i].getCheckIn()).TotalHours;
                }
                else if(timelogs[i].getCheckIn() <= start &&
                    timelogs[i].getCheckOut() > start &&
                    timelogs[i].getCheckOut() < end) //cond B
                {
                    total = total + (timelogs[i].getCheckOut() - start).TotalHours;
                }
                else if(timelogs[i].getCheckIn() < end &&
                    timelogs[i].getCheckOut() >= end &&
                    timelogs[i].getCheckIn() > start) //cond C
                {
                    total = total + (end - timelogs[i].getCheckIn()).TotalHours;
                }
                else if (timelogs[i].getCheckIn() <= start &&
                    timelogs[i].getCheckOut() >= end)
                {
                    total = total + 24.0;
                }

            }
            return total;
        }





    }
}