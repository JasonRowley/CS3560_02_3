using GroupProjCS3560num2.Classes.Handlers;
using GroupProjCS3560num2.Forms.PinPad;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GroupProjCS3560num2.Forms
{
    public partial class PinPage : Form
    {
        public PinPage()
        {
            InitializeComponent();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            maskedTextBox1.Text = maskedTextBox1.Text + 1;
        }
        private void button2_Click_1(object sender, EventArgs e)
        {
            maskedTextBox1.Text = maskedTextBox1.Text + 2;
        }
        private void button3_Click_1(object sender, EventArgs e)
        {
            maskedTextBox1.Text = maskedTextBox1.Text + 3;
        }
        private void button4_Click_1(object sender, EventArgs e)
        {
            maskedTextBox1.Text = maskedTextBox1.Text + 4;
        }
        private void button5_Click_1(object sender, EventArgs e)
        {
            maskedTextBox1.Text = maskedTextBox1.Text + 5;
        }
        private void button6_Click_1(object sender, EventArgs e)
        {
            maskedTextBox1.Text = maskedTextBox1.Text + 6;
        }
        private void button7_Click_1(object sender, EventArgs e)
        {
            maskedTextBox1.Text = maskedTextBox1.Text + 7;
        }
        private void button8_Click_1(object sender, EventArgs e)
        {
            maskedTextBox1.Text = maskedTextBox1.Text + 8;
        }
        private void button9_Click_1(object sender, EventArgs e)
        {
            maskedTextBox1.Text = maskedTextBox1.Text + 9;
        }
        private void button10_Click(object sender, EventArgs e)
        {
            maskedTextBox1.Text = maskedTextBox1.Text + 0;
        }

        private async void button12_Click(object sender, EventArgs e)
        {
            int userPin;
            if (Int32.TryParse(maskedTextBox1.Text, out userPin))
            {
                switch (ClockInClockOutHandler.EnterPin(userPin))
                {
                    case 0:
                        label2.Text = "Successfully checked out!";
                        label2.ForeColor = System.Drawing.Color.DodgerBlue;
                        label2.Show();
                        await Task.Delay(1000);
                        Close();
                        break;
                    case 1:
                        label2.Text = "Successfully checked in!";
                        label2.ForeColor = System.Drawing.Color.DodgerBlue;
                        label2.Show();
                        await Task.Delay(1000);
                        Close();
                        break;
                    default:
                        label2.Text = "* Incorrect PIN";
                        label2.ForeColor = System.Drawing.Color.Red;
                        label2.Show();
                        break;
                }
            }
            else
            {
                label2.Text = "* Incorrect PIN";
                label2.ForeColor = System.Drawing.Color.Red;
                label2.Show();
            }
            maskedTextBox1.Clear();            
        }

        private void button11_Click(object sender, EventArgs e)
        {
            maskedTextBox1.Clear();
        }

        private void PinPage_Load(object sender, EventArgs e)
        {

        }

        private void PinPage_FormClosing(object sender, FormClosingEventArgs e)
        {
            
        }
    }
}
