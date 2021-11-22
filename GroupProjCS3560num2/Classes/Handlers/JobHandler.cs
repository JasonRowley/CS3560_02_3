using System;
using System.Collections.Generic;
using System.Text;
using GroupProjCS3560num2.Database;
using GroupProjCS3560num2.Forms;

namespace GroupProjCS3560num2.Classes.Handlers
{
    class JobHandler
    {
        public static void addJob(int jobID, String jobTitle, double basePayrate)
        {
            Job j = new Job(jobID, jobTitle, basePayrate);
            DatabaseHelper.InsertJob(j);
        }

        public static void deleteJob(int jobID)
        {
            DatabaseHelper.DeleteJob(jobID);
        }

        public static void updateJob(int jobID, String jobTitle, double basePayrate)
        {
            Job j = new Job(jobID, jobTitle, basePayrate);
            DatabaseHelper.UpdateJob(j);
        }

        public static int getJobID(string jobTitle)
        {
            List<Job> j = DatabaseHelper.SelectAllJobs();
            for (int i = 0; i < j.Count; i++)
            {
                if (jobTitle == j[i].getJobTitle())
                {
                    return j[i].getJobID();
                }
            }
            return 0;
        }
    }
}
