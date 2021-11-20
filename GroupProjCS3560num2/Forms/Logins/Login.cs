using GroupProjCS3560num2.Classes;
using GroupProjCS3560num2.Database;
using System;
using System.Windows.Forms;
using GroupProjCS3560num2.Classes.Handlers;

namespace GroupProjCS3560num2.Forms
{
    public partial class Login : Form
    {
        StartPage sp;

        public Login(StartPage sp)
        {
            InitializeComponent();
            this.sp = sp;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            int empID = 0;
            if (!Int32.TryParse(textBox1.Text, out empID))
            {
                label2.Show();
            }
            else
            {
                String pass = textBox2.Text;
                Employee tempEmployee = LoginHandler.Login(empID, pass);
                if (null == tempEmployee)
                {
                    label2.Show();
                }
                else
                {
                    AdminMain f0 = new AdminMain(sp, tempEmployee);
                    f0.Show();
                    Close();
                }
            }
            
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
