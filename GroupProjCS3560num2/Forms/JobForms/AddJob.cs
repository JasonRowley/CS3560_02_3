using System;
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
            Label[] labels = { label1, label3 };
            double basePayrate;

            // verifies job title
            if (textBox1.Text == "")
                label1.ForeColor = System.Drawing.Color.Red;
            else
                label1.ForeColor = System.Drawing.Color.Black;

            // verifies base pay rate
            bool bpr = double.TryParse(textBox2.Text, out basePayrate);
            if (!bpr || basePayrate < 0)
                label3.ForeColor = System.Drawing.Color.Red;
            else
                label3.ForeColor = System.Drawing.Color.Black;

            // verifies that none is empty
            int countNotEmpty = 0;
            for (int i = 0; i < 2; i++)
            {
                if (labels[i].ForeColor == System.Drawing.Color.Black)
                    countNotEmpty += 1;
                if (countNotEmpty == 2)
                {
                    JobHandler.addJob(0, textBox1.Text, basePayrate);
                    this.Close();
                }
            }

            //Debug.WriteLine(basePayrate);
        }

        private void textBox2_TextChanged(object sender, EventArgs e) // base payrate
        {

        }
    }
}
