using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EMPLOYEE_MANAGEMENT_SYSTEM
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
     
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void crossbtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void clearbtn_Click(object sender, EventArgs e)
        {
            admintb.Text = "";
            passtb.Text = " ";

        }
        //Data Source=DESKTOP-CNNOR6S;Integrated Security=True;Connect Timeout=30;Encrypt=False;Trust Server Certificate=False;Application
        //Intent=ReadWrite;Multi Subnet Failover=False
        private void loginbtn_Click(object sender, EventArgs e)
        {
            if(admintb.Text==" " && passtb.Text == " ")
            {
                MessageBox.Show("Missing username or password");

            }
            else if (admintb.Text == "admin" || passtb.Text == "123")
            {
                home nextpage= new home();
                nextpage.Show();
                this.Hide();

            }
            else
            {
                MessageBox.Show("Please enter correct information");
            }
        }
    }
}
