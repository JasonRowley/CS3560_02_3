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
        public string NextWindow { get; set; }
        public StartPage()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            NextWindow = button1.Text;
            using (PinPage f = new PinPage()) {

                //hide this form
                this.WindowState = FormWindowState.Minimized;
                this.ShowInTaskbar = false;

                //set up new form. 
                f.StartPosition = FormStartPosition.CenterScreen;
                int temp = (int)f.ShowDialog();
               
                this.WindowState = FormWindowState.Normal;
                this.ShowInTaskbar = true;

                

            }
                
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
            this.ShowInTaskbar = false;
            Login f = new Login();
            f.StartPosition = FormStartPosition.CenterScreen;
            int temp = (int)f.ShowDialog();
            this.WindowState = FormWindowState.Normal;
            this.ShowInTaskbar = true;
        }
    }
}
