using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EMPLOYEE_MANAGEMENT_SYSTEM
{
    public partial class home : Form
    {
        public home()
        {
            InitializeComponent();
        }

        private void crossbtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            salary obj1 = new salary();
            obj1.Show();
            this.Hide();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            employee nextpage = new employee();
            nextpage.Show();
            this.Hide();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            view e1= new view();
            e1.Show();
            this.Hide();
        }

       
    }
}
