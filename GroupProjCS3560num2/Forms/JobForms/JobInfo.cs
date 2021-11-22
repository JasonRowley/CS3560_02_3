using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using GroupProjCS3560num2.Classes.Handlers;
using GroupProjCS3560num2.Database;
using GroupProjCS3560num2.Classes;

namespace GroupProjCS3560num2.Forms
{
    public partial class JobInfo : Form
    {
        public JobInfo(Job job)
        {
            InitializeComponent();

            List<Job> j = DatabaseHelper.SelectAllJobs();
            for (int i = 0; i < j.Count; i++)
            {
                comboBox1.Items.Add(j[i].getJobTitle());
            }

            // display texts at the start of the form
            comboBox1.Text = job.getJobTitle();
            jobIDBox.Text = job.getJobID().ToString();
            textBox1.Text = job.getBasePayrate().ToString();
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void confirmButton_Click(object sender, EventArgs e)
        {
            Label[] labels = { jobTitleLabel, basePayrateLabel };
            double basePayrate;

            // verifies job
            if (string.IsNullOrEmpty(comboBox1.Text)) // comboBox1.SelectedIndex == -1 && 
                jobTitleLabel.ForeColor = System.Drawing.Color.Red;
            else
                jobTitleLabel.ForeColor = System.Drawing.Color.Black;

            // verifies base pay rate
            bool bpr = double.TryParse(textBox1.Text, out basePayrate);
            if (!bpr || basePayrate < 1)
                basePayrateLabel.ForeColor = System.Drawing.Color.Red;
            else
                basePayrateLabel.ForeColor = System.Drawing.Color.Black;

            // verifies that none is empty
            int countNotEmpty = 0;
            for (int i = 0; i < 2; i++)
            {
                if (labels[i].ForeColor == System.Drawing.Color.Black)
                    countNotEmpty += 1;
                if (countNotEmpty == 2)
                {
                    JobHandler.updateJob(Int32.Parse(jobIDBox.Text), comboBox1.Text, basePayrate);
                    this.Close();
                }
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e) // job comboBox
        {
            // jobID and basePayrate get updated along with the selected job
            List<Job> j = DatabaseHelper.SelectAllJobs();
            for (int i = 0; i < j.Count; i++)
            {
                if (j[i].getJobTitle() == comboBox1.SelectedItem.ToString())
                {
                    jobIDBox.Text = j[i].getJobID().ToString();
                    textBox1.Text = j[i].getBasePayrate().ToString();
                }
            }
        }

        private void jobIDBox_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            // FIX THE DELETE JOB WHEN IS ASSIGNED TO AN EMPLOYEE ---> USE TRY CATCH AND GIVE THE RED LABEL TAG NOTIFYING THAT THE JOB CANT BE DELETED
            int jobID = Int32.Parse(jobIDBox.Text);

            List<Employee> emp = DatabaseHelper.SelectAllEmployees();
            for (int i = 0; i < emp.Count; i++)
            {
                if (jobID == emp[i].getJobID())
                {
                    label1.Show();
                    break;
                }
                else
                {
                    if (i == emp.Count - 1)
                    {
                        JobHandler.deleteJob(jobID);
                        this.Close();
                    }
                }
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e) // base payrate
        {

        }
    }
}