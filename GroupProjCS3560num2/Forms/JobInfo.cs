using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using GroupProjCS3560num2.Classes.Handlers;
using GroupProjCS3560num2.Database;

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
            basePayrateBox.Text = job.getBasePayrate().ToString();
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void confirmButton_Click(object sender, EventArgs e)
        {
            int jobID = Int32.Parse(jobIDBox.Text);
            string jobTitle = comboBox1.Text;
            double basePayrate = double.Parse(basePayrateBox.Text);

            JobHandler.updateJob(jobID, jobTitle, basePayrate);
            this.Close();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            List<Job> j = DatabaseHelper.SelectAllJobs();

            for (int i = 0; i < j.Count; i++)
            {
                if (j[i].getJobTitle() == comboBox1.SelectedItem.ToString())
                {
                    jobIDBox.Text = j[i].getJobID().ToString();
                    basePayrateBox.Text = j[i].getBasePayrate().ToString();
                }
            }
        }

        private void jobIDBox_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void basePayrateBox_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            int jobID = Int32.Parse(jobIDBox.Text);
            JobHandler.deleteJob(jobID);
            this.Close();
        }
    }
}