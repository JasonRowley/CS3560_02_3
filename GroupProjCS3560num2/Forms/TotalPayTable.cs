using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using GroupProjCS3560num2.Classes;
using GroupProjCS3560num2.Classes.Handlers;
using System.Globalization;

namespace GroupProjCS3560num2.Forms
{
    public partial class TotalPayTable : Form
    {
        TotalPayHandler tph;
        public TotalPayTable()
        {
            InitializeComponent();
            tph = new TotalPayHandler(listView1);
            warning.Hide();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void startDate_ValueChanged(object sender, EventArgs e)
        {
            updateTable(startDate.Value, stopDate.Value);
        }

        private void updateTable(DateTime start, DateTime end)
        {
            if(end < start)
            {
                warning.Show();
                listView1.Items.Clear();
                listView1.ForeColor = Color.Gray;
                string[] blanks =
                {
                    "Name?",
                    "Job?",
                    "$ ---",
                    "$ ---",
                    "--- Hr",
                    "--- Hr",
                    "$ ---"
                };
                listView1.Items.Add("???").SubItems.AddRange(blanks);
            }
            else
            {
                warning.Hide();
                listView1.ForeColor = Color.Black;
                TotalPayHandler.updateTable(listView1, start, end);
            }
        }

        private void stopDate_ValueChanged(object sender, EventArgs e)
        {
            updateTable(startDate.Value, stopDate.Value);
        }
    }
}
