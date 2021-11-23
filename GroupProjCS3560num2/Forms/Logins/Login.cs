using GroupProjCS3560num2.Classes;
using GroupProjCS3560num2.Database;
using System;
using System.Windows.Forms;
using GroupProjCS3560num2.Classes.Handlers;

namespace GroupProjCS3560num2.Forms
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            int empID = 0;
            if (!Int32.TryParse(textBox1.Text, out empID))
            {
                hidelabels();
                label2.Show();
            }
            else
            {
                String pass = textBox2.Text;
                Employee tempEmployee = LoginHandler.Login(empID, pass);
                if (null == tempEmployee)
                {
                    hidelabels();
                    label2.Show();
                }
                else
                {
                    if(tempEmployee.getJobID() == 1)//for now just prevent any non Admin from gaining access.
                    {
                        using (AdminMain f0 = new AdminMain(tempEmployee))
                        {
                            this.WindowState = FormWindowState.Minimized;
                            this.ShowInTaskbar = false;
                            f0.StartPosition = FormStartPosition.CenterScreen;
                            f0.ShowDialog();
                            this.WindowState = FormWindowState.Normal;
                            this.ShowInTaskbar = true;

                        }
                    }
                    else
                    {
                        hidelabels();
                        label3.Show();
                    }
                    

                }
            }
            
        }
        private void hidelabels()
        {
            label1.Hide();
            label2.Hide();
            label3.Hide();
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void Login_FormClosing(object sender, FormClosingEventArgs e)
        {

        }
    }
}
