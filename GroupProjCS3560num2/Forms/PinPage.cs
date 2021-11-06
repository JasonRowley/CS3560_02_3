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
            //Enter info into DB using maskedTextBox1 to INT
            //reference text field
            //query via pin QUERY ex 1234
            //exists = clockout complete entry via UPDATE
            //!exits = insert
            // perform a database INSERT
            int userPin = Int32.Parse(maskedTextBox1.Text);

        }

        private void button11_Click(object sender, EventArgs e)
        {
            maskedTextBox1.Clear();
        }
    }
}
