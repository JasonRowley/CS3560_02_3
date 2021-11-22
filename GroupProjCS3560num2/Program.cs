using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using GroupProjCS3560num2.Classes;
using GroupProjCS3560num2.Forms;
using GroupProjCS3560num2.Database;

namespace GroupProjCS3560num2
{
    static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            
            TimeLog testTS = new TimeLog();
            testTS.setLogID(DatabaseHelper.SelectTimeLog(2).getLogID());
            testTS.setEmployeeID(DatabaseHelper.SelectTimeLog(2).getEmployeeID());
            testTS.setCheckIn(DatabaseHelper.SelectTimeLog(2).getCheckIn());
            testTS.setCheckOut(DatabaseHelper.SelectTimeLog(2).getCheckOut());
            

            Application.Run(new AddTimestamp());
            //Application.Run(new AddTimestamp());
        }
    }
}
