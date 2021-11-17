using GroupProjCS3560num2.Classes.Handlers;
using GroupProjCS3560num2.Forms.PinPad;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
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
        private void button2_Click(object sender, EventArgs e)
        {
            maskedTextBox1.Text = maskedTextBox1.Text + 2;
        }
        private void button3_Click(object sender, EventArgs e)
        {
            maskedTextBox1.Text = maskedTextBox1.Text + 3;
        }
        private void button4_Click(object sender, EventArgs e)
        {
            maskedTextBox1.Text = maskedTextBox1.Text + 4;
        }
        private void button5_Click(object sender, EventArgs e)
        {
            maskedTextBox1.Text = maskedTextBox1.Text + 5;
        }
        private void button6_Click(object sender, EventArgs e)
        {
            maskedTextBox1.Text = maskedTextBox1.Text + 6;
        }
        private void button7_Click(object sender, EventArgs e)
        {
            maskedTextBox1.Text = maskedTextBox1.Text + 7;
        }
        private void button8_Click(object sender, EventArgs e)
        {
            maskedTextBox1.Text = maskedTextBox1.Text + 8;
        }
        private void button9_Click(object sender, EventArgs e)
        {
            maskedTextBox1.Text = maskedTextBox1.Text + 9;
        }
        private void button10_Click(object sender, EventArgs e)
        {
            maskedTextBox1.Text = maskedTextBox1.Text + 0;
        }

        private void button12_Click(object sender, EventArgs e)
        {
            int userPin = Int32.Parse(maskedTextBox1.Text);
            switch (ClockInClockOutHandler.EnterPin(userPin))
            {
                case  0:
                    ClockedOut f0 = new ClockedOut();
                    f0.Show();
                    break;
                case  1:
                    ClockedIn f1 = new ClockedIn();
                    f1.Show();
                    break;
                default:
                    PinPadFailed f2 = new PinPadFailed();
                    f2.Show();
                    break;
            }
            
        }

        private void button11_Click(object sender, EventArgs e)
        {
            maskedTextBox1.Clear();
        }
    }
}
