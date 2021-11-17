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
            this.Close();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            int empID = Int32.Parse(textBox1.Text);    //TODO: account for if no text is entered
            String pass = textBox2.Text;
            Employee tempEmployee = LoginHandler.Login(empID, pass);
            if (null == tempEmployee)
            {
                Forms.Logins.IncorrectCredentials f1 = new Forms.Logins.IncorrectCredentials();
                f1.Show();
            }
            else
            {
                AdminMain f0 = new AdminMain();
                f0.Show();
            } 
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
