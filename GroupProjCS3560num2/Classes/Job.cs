using System;
using System.Collections.Generic;
using System.Text;

namespace GroupProjCS3560num2.Forms
{
    class Job
    {
        int jobID;
        string jobTitle;
        double basePayrate;

        public Job(int jobID, string jobTitle, double basePayrate)
        {
            this.jobID = jobID;
            this.jobTitle = jobTitle;
            this.basePayrate = basePayrate;
        }

        public int getJobID()
        {
            return jobID;
        }

        public string getJobTitle()
        {
            return jobTitle;
        }


        public double getBasePayrate()
        {
            return basePayrate; 
        }



    }
}
