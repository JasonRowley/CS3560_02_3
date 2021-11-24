using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using GroupProjCS3560num2.Database;
using GroupProjCS3560num2.Forms;

namespace GroupProjCS3560num2.Classes.Handlers
{

    class EmployeeMainHandler
    {
        // Currently logged in employee
        Employee emp;

        // Managed components in AdminMain form
        ListView lv;
        public EmployeeMainHandler(Employee emp, ListView lv)
        {
            this.emp = emp;
            this.lv = lv;
            
        }
        public void changeTbl()
        {
            var cols = lv.Columns;
            cols.Clear();
                    // Replace the removed columns
                    for (int i = 0; i < 3; i++)
                    {
                        cols.Add(new ColumnHeader());
                    }

                    // Set visible properties for each column
                    cols[0].Name = "logID";
                    cols[0].Text = "ID";
                    cols[0].Width = 30;

                    cols[1].Name = "checkIn";
                    cols[1].Text = "Check-In Time";
                    cols[1].Width = 180;

                    cols[2].Name = "checkOut";
                    cols[2].Text = "Check-Out Time";
                    cols[2].Width = 180;
                   
           
         populateColumns();
        }
        public void populateColumns()
        {
            string where = string.Format(" where employeeID = {0}", emp.getEmployeeID());
            lv.Items.Clear();
                    var logs = DatabaseHelper.SelectAllTimeLogs(where);

                    // Display all returned rows
                    foreach (var log in logs)
                    {
                        string[] attributes = {
                            log.getCheckIn() == default(DateTime) ? "" : log.getCheckIn().ToString(),
                            log.getCheckOut() == default(DateTime) ? "" : log.getCheckOut().ToString()
                        };
                        lv.Items.Add(log.getLogID().ToString()).SubItems.AddRange(attributes);
                    }

                
          
        }

    }
}
