using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using GroupProjCS3560num2.Forms;
using GroupProjCS3560num2.Classes;

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
            //DateTime d = new DateTime(2011, 11, 11);
            //Employee emp = new Employee(0, 1, "132password", "name1", "555 mian street", "email@cpp.edu", "111-555-2715", d, "00000000000", "111-11-1111", 0);
            Application.Run(new JobInfo(DatabaseHelper.SelectJob(1)));
            //Application.Run(new AddJob());
        }
    }
}
