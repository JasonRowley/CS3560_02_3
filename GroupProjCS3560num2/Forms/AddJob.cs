﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using GroupProjCS3560num2.Classes.Handlers;
using System.Diagnostics;

namespace GroupProjCS3560num2.Forms
{
    public partial class AddJob : Form
    {
        public AddJob()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e) // job title
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e) // base payrate
        {

        }

        private void button2_Click(object sender, EventArgs e) // cancel
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e) // confirm
        {
            int jobID = 0;
            String jobTitle = textBox1.Text;
            double basePayrate = double.Parse(maskedTextBox1.Text);

            JobHandler.addJob(jobID, jobTitle, basePayrate);

            this.Close();
            //Debug.WriteLine(basePayrate);
        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }
    }
}
