using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using GroupProjCS3560num2.Classes;
using GroupProjCS3560num2.Classes.Handlers;


namespace GroupProjCS3560num2.Forms
{

    public partial class AddTimestamp : Form
    {
        public AddTimestamp()
        {
            InitializeComponent();
            for (int i = 0; i < TimestampHandler.GetAllEmp().Count; i++)
            {
                employeeComboBox.Items.Add(
                    TimestampHandler.GetAllEmp()[i].getEmpName()
                    + " - ID: " +
                    TimestampHandler.GetAllEmp()[i].getEmployeeID()
                    );
            }
            warning.Hide();
        }

        private void clockInDate_ValueChanged(object sender, EventArgs e)
        {

        }

        private void clockInTime_ValueChanged(object sender, EventArgs e)
        {

        }

        private void clockOutDate_ValueChanged(object sender, EventArgs e)
        {

        }

        private void clockOutTime_ValueChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void confirmTimestamp_Click(object sender, EventArgs e)
        {
            DateTime newClockIn = DateTime.Parse(clockInDate.Value.ToShortDateString());
            string clockInTimeStr = clockInTime.Value.ToString("HH:mm");
            newClockIn += TimeSpan.Parse(clockInTimeStr);

            DateTime newClockOut = DateTime.Parse(clockOutDate.Value.ToShortDateString());
            string clockOutTimeStr = clockOutTime.Value.ToString("HH:mm");
            newClockOut += TimeSpan.Parse(clockOutTimeStr);

            if (employeeComboBox.GetItemText(employeeComboBox.SelectedItem) == string.Empty)
            {
                warning.Hide();
                employeeComboBox.ForeColor = Color.Red;
            }

            else if (newClockOut <= newClockIn)
            {
                warning.Show();
                employeeComboBox.ForeColor = Color.Black;
            }
            else
            {
                warning.Hide();
                employeeComboBox.ForeColor = Color.Black;

                string name = employeeComboBox.GetItemText(employeeComboBox.SelectedItem);
                for (int i = 0; i < TimestampHandler.GetAllEmp().Count; i++)
                {
                    if (name ==
                        TimestampHandler.GetAllEmp()[i].getEmpName()
                        + " - ID: " +
                        TimestampHandler.GetAllEmp()[i].getEmployeeID()
                        )
                    {
                        TimestampHandler.CreateTimestamp(
                            TimestampHandler.GetAllEmp()[i].getEmployeeID(),
                            newClockIn,
                            newClockOut
                            );
                        break;
                    }
                }
                this.Close();
            }
        }
        private void cancelTimestamp_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
