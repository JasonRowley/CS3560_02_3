using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace GroupProjCS3560num2.Forms
{
    public partial class StartPage : Form
    {
        public StartPage()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            PinPage f = new PinPage();
            f.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Login f = new Login();
            f.Show();
        }
    }
}
