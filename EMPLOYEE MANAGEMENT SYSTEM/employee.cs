using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;
using System;

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
    public partial class employee : Form
    {
        public employee()
        {
            InitializeComponent();
        }
        SqlConnection conn = new SqlConnection("Data Source=localhost;Initial Catalog=managementsys; User ID=sa;Password=123"); // Update with your connection string
        int id = 0;
        private void crossbtn_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void homebtn_Click(object sender, EventArgs e)
        {
            home h = new home();
            h.Show();
            this.Hide();
        }
        private void data()
        {
            conn.Open();
            DataTable dt = new DataTable();
            SqlDataAdapter sda = new SqlDataAdapter("select * from employees", conn);
            sda.Fill(dt);
            dataGridView1.DataSource = dt;
            conn.Close();
        }
        private void addbtn_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("INSERT INTO employees(emp_name,emp_position,emp_phone,emp_education) " +
                                             "VALUES (@en, @epo, @eph,@edu)", conn);

            string en = EmpName.Text;
            conn.Open();

            cmd.Parameters.AddWithValue("@en", EmpName.Text);
            cmd.Parameters.AddWithValue("@epo", Emp_Position.SelectedItem.ToString());
            cmd.Parameters.AddWithValue("@eph", Emp_Phone.Text);
            cmd.Parameters.AddWithValue("@edu", Emp_Edu.SelectedItem.ToString());

            cmd.ExecuteNonQuery();
            conn.Close();

            MessageBox.Show($"{en} Added Successfully");
            data();
            clear();
        }
        private void clear()
        {
            Emp_Id.Text = "";
            EmpName.Text = "";
            Emp_Position.Text = "";
            Emp_Phone.Text = "";
            Emp_Edu.Text = "";
        }

        private void employee_Load(object sender, EventArgs e)
        {
            data();
        }

        private void rebtn_Click(object sender, EventArgs e)
        {
            Emp_Id.Text = "";
            EmpName.Text = "";
            Emp_Position.Text = "";
            Emp_Phone.Text = "";
            Emp_Edu.Text = "";
        }

        private void delbtn_Click(object sender, EventArgs e)
        {
            if (id != 0)
            {
                SqlCommand cmd = new SqlCommand("delete from employees where empId = @id", conn);
                conn.Open();
                cmd.Parameters.AddWithValue("@id", id);
                cmd.ExecuteNonQuery();
                conn.Close();
                MessageBox.Show("Delete Successfully");
                data();
                clear();
            }
            else
            {
                MessageBox.Show("select any data to delete");
            }
        }

        private void updatebtn_Click(object sender, EventArgs e)

        {
            if (EmpName.Text != "" && Emp_Position.Text != "" && Emp_Phone.Text != "" && Emp_Edu.Text != "")
            {
                SqlCommand cmd = new SqlCommand("UPDATE employees SET emp_name = @en, emp_position = @epo, " +
                                                 "emp_phone = @eph, emp_education = @edu WHERE empId = @id", conn);

                string en = EmpName.Text;
                conn.Open();

                cmd.Parameters.AddWithValue("@en", EmpName.Text);
                cmd.Parameters.AddWithValue("@epo", Emp_Position.SelectedItem.ToString());
                cmd.Parameters.AddWithValue("@eph", Emp_Phone.Text);
                cmd.Parameters.AddWithValue("@edu", Emp_Edu.SelectedItem.ToString());


                cmd.Parameters.AddWithValue("@id", id);

                cmd.ExecuteNonQuery();
                conn.Close();

                MessageBox.Show($"{en} Updated Successfully");
                data();
                clear();
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            id = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());

            EmpName.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();

            // Set the selected item of Emp_Position ComboBox
            string position = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            Emp_Position.SelectedItem = position;

            Emp_Phone.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();

            // Set the selected item of Emp_Edu ComboBox
            string education = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
            Emp_Edu.SelectedItem = education;
        }

       
    }
}
