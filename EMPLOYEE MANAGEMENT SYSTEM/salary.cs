using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EMPLOYEE_MANAGEMENT_SYSTEM
{
    public partial class salary : Form
    {
        public salary()
        {
            InitializeComponent();
        }
        SqlConnection conn = new SqlConnection("Data Source=localhost;Initial Catalog=managementsys; User ID=sa;Password=123");


        private void fetchemp()
        {
            //try
            //{
            //    conn.Open();
            //    string query = "SELECT * FROM employees WHERE empId = '" + textBox1.Text + "'";

            //    SqlCommand cmd = new SqlCommand(query, conn);
            //    DataTable dt = new DataTable();
            //    SqlDataAdapter sda = new SqlDataAdapter(cmd);
            //    sda.Fill(dt);
            //    foreach (DataRow dr in dt.Rows)
            //    {
            //       // label2.Text = dr["empId"].ToString();
            //        //label4.Text = dr["emp_name"].ToString();
            //        //label6.Text = dr["emp_position"].ToString();
            //        //label8.Text = dr["emp_phone"].ToString();
            //        //label10.Text = dr["emp_education"].ToString();


            //    }
            }/*}*/







                    private void crossbtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            home obj = new home();
            obj.Show();
            this.Hide();
        }
    }
}
