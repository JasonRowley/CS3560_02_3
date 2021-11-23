using GroupProjCS3560num2.Classes;
using GroupProjCS3560num2.Classes.Handlers;
using System;
using System.Windows.Forms;

namespace GroupProjCS3560num2.Forms
{
    public partial class AdminMain : Form
    {
        AdminMainHandler amh;


        public AdminMain(Employee emp)
        {
            InitializeComponent();
            // Create handler and display employee table
            amh = new AdminMainHandler(emp, listView1, button5);
            amh.changeTbl(Tables.EMPLOYEE);

            // Make displayed rows clickable
            listView1.Activation = ItemActivation.OneClick;
            listView1.ItemActivate += new System.EventHandler(this.listView1_ItemActivate);
            listView1.FullRowSelect = true;

            // Search and display specific rows on Enter key press
            textBox1.KeyUp += textBox1_KeyUp;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            amh.changeTbl(Tables.EMPLOYEE);
        }
        
        private void button2_Click(object sender, EventArgs e)
        {
            amh.changeTbl(Tables.JOB);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            amh.changeTbl(Tables.ISSUE);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            amh.changeTbl(Tables.TIMELOG);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            amh.AddNewEntity();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            //logout
            Close();
        }

        private void textBox1_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                try
                {
                    amh.populateColumns(amh.getSearchQuery(textBox1.Text));
                }
                catch (NoEmployeesException) { /* do nothing */ }
                finally
                {
                    e.Handled = true;
                }
            }
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listView1_ItemActivate(object sender, EventArgs e)
        {
            // ListView.SelectedListViewItemCollection entity = this.listView1.SelectedItems;
            // access table from row
            if (amh.getCurrTbl() == Tables.ISSUE)
            {
                amh.EditNewEntity(Int32.Parse(this.listView1.SelectedItems[0].SubItems[1].Text));
            }
            else
            { 
                amh.EditNewEntity(Int32.Parse(this.listView1.SelectedItems[0].Text));
            }
        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void AdminMain_FomClosing(object sender, FormClosingEventArgs e)
        {
            //logout
        }
    }
}
