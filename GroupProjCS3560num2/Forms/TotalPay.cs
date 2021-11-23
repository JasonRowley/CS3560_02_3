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
    public partial class TotalPay : Form
    {
        public TotalPay()
        {
            InitializeComponent();
            for (int i = 0; i < TotalPayHandler.GetAllEmp().Count; i++)
            {
                employeeComboBox.Items.Add(
                    TimestampHandler.GetAllEmp()[i].getEmpName()
                    + " - ID: " +
                    TimestampHandler.GetAllEmp()[i].getEmployeeID()
                    );
            }
            warning.Hide();

            label2.ForeColor = Color.Gray;
            label3.ForeColor = Color.Gray;
            label4.ForeColor = Color.Gray;
            label6.ForeColor = Color.Gray;
            label8.ForeColor = Color.Gray;

            basePay.ForeColor = Color.Gray;
            adj.ForeColor = Color.Gray;
            hourlyRate.ForeColor = Color.Gray;
            totalH.ForeColor = Color.Gray;
            totalP.ForeColor = Color.Gray;

            basePay.Text = "$ ---";
            adj.Text = "$ ---";
            hourlyRate.Text = "--- Hrs";
            totalH.Text = "--- Hrs";
            totalP.Text = "$ ---";
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void TotalPay_Load(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void cancelTimestamp_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void confirmTimestamp_Click(object sender, EventArgs e)
        {
            string name = employeeComboBox.GetItemText(employeeComboBox.SelectedItem);
            for (int i = 0; i < TotalPayHandler.GetAllEmp().Count; i++)
            {
                if (name ==
                    TotalPayHandler.GetAllEmp()[i].getEmpName()
                    + " - ID: " +
                    TotalPayHandler.GetAllEmp()[i].getEmployeeID()
                    )
                {
                    Employee emp = TotalPayHandler.GetAllEmp()[i];
                    DateTime confirmStartTime = DateTime.Parse(startDate.Value.ToShortDateString());
                    DateTime confirmStopTime = DateTime.Parse(stopDate.Value.ToShortDateString());
                    confirmStopTime = confirmStopTime.AddHours(23.0);
                    confirmStopTime = confirmStopTime.AddMinutes(59.0);

                    if (confirmStopTime < confirmStartTime)
                    {
                        warning.Show();
                        label2.ForeColor = Color.Gray;
                        label3.ForeColor = Color.Gray;
                        label4.ForeColor = Color.Gray;
                        label6.ForeColor = Color.Gray;
                        label8.ForeColor = Color.Gray;

                        basePay.ForeColor = Color.Gray;
                        adj.ForeColor = Color.Gray;
                        hourlyRate.ForeColor = Color.Gray;
                        totalH.ForeColor = Color.Gray;
                        totalP.ForeColor = Color.Gray;

                        basePay.Text = "$ ---";
                        adj.Text = "$ ---";
                        hourlyRate.Text = "--- Hrs";
                        totalH.Text = "--- Hrs";
                        totalP.Text = "$ ---";
                    }
                    else
                    {
                        label2.ForeColor = Color.Black;
                        label3.ForeColor = Color.Black;
                        label4.ForeColor = Color.Black;
                        label6.ForeColor = Color.Black;
                        label8.ForeColor = Color.Black;

                        basePay.ForeColor = Color.Black;
                        adj.ForeColor = Color.Black;
                        hourlyRate.ForeColor = Color.Black;
                        totalH.ForeColor = Color.Black;
                        totalP.ForeColor = Color.Black;

                        double dBasePay = TotalPayHandler.GetBasePay(emp);
                        double dAdj = emp.getAdjustment();
                        double dHourlyRate = dBasePay + dAdj;
                        double dTotalH = TotalPayHandler.GetTotalHours
                            (confirmStartTime,confirmStopTime, emp);
                        double dtotalP = dHourlyRate * dTotalH;

                        basePay.Text = dBasePay.ToString();
                        adj.Text = dAdj.ToString();
                        hourlyRate.Text = dHourlyRate.ToString();
                        totalH.Text = dTotalH.ToString();
                        totalP.Text = dtotalP.ToString();
                    }
                }
            }
        }

        private void totalHrs_Click(object sender, EventArgs e)
        {

        }
    }
}
