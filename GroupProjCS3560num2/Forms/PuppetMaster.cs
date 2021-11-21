using GroupProjCS3560num2.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace GroupProjCS3560num2.Forms
{
    public partial class PuppetMaster : Form
    {
        public PuppetMaster()
        {
            Employee currentEmployee;
            Login lg;
            AdminMain aM;
            
            InitializeComponent();
            //this.WindowState = FormWindowState.Minimized;
            //this.ShowInTaskbar = false;

            using(StartPage sP = new StartPage())
            {
                if(sP.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    this.Text = sP.NextWindow;
                }
            }
            
        }

        private void PuppetMaster_Load(object sender, EventArgs e)
        {

        }
    }
}
