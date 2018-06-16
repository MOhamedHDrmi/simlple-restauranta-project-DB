using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Restaurant
{
    public partial class Employee : Form
    {
        public Employee()
        {
            InitializeComponent();
        }

        private void Phone1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Employee_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'restaurantDataSet.EMPLOYEE' table. You can move, or remove it, as needed.
            this.eMPLOYEETableAdapter.Fill(this.restaurantDataSet.EMPLOYEE);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (this.ID.Text != "" && this.BranchNO.Text != "" && this.Fname.Text != "" && this.Llast.Text != ""
                        && this.Salary.Text != "" && this.Gender.Text != "" && this.Role.Text != "" && this.City.Text != ""
                        && this.Country.Text != "" && this.ZipCode.Text != "" && this.Phone1.Text != "")
            {
                SqlConnection connection = new SqlConnection("Data Source=MOHAMED_HDRMI;Initial Catalog=Restaurant;Integrated Security=True");
                SqlCommand command = new SqlCommand("", connection);
                connection.Open();
                command.CommandText = "INSERT INTO EMPLOYEE (ID,BranchNO,FName,LName,Salary,Gender,Role,City,Country,ZipCode,PhoneNO) VALUES('"
                    + this.ID.Text + "','" + this.BranchNO.Text + "','" + this.Fname.Text + "','" + this.Llast.Text + "','"
                        + this.Salary.Text + "','" + this.Gender.Text + "','" + this.Role.Text + "','" + this.City.Text + "','"
                        + this.Country.Text + "','" + this.ZipCode.Text + "','" + this.Phone1.Text + "')";
                command.ExecuteNonQuery();
                connection.Close();
            }
            else
                MessageBox.Show("Some Information Not Entering");
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'restaurantDataSet.EMPLOYEE' table. You can move, or remove it, as needed.
            this.eMPLOYEETableAdapter.Fill(this.restaurantDataSet.EMPLOYEE);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Main main = new Main();
            main.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (this.ID.Text != "")
            {
                SqlConnection connection = new SqlConnection("Data Source=MOHAMED_HDRMI;Initial Catalog=Restaurant;Integrated Security=True");
                SqlCommand command = new SqlCommand("", connection);
                connection.Open();
                command.CommandText = "DELETE FROM EMPLOYEE WHERE ID=" + this.ID.Text;
                command.ExecuteNonQuery();
                connection.Close();
            }
            else
                MessageBox.Show("Please Enter ID For Employee You Went Deleted");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection("Data Source=MOHAMED_HDRMI;Initial Catalog=Restaurant;Integrated Security=True");
            SqlCommand command = new SqlCommand("", connection);
            connection.Open();
            if (this.ID.Text != "")
            {
                if (this.BranchNO.Text != "")
                {
                    command.CommandText = "UPDATE EMPLOYEE SET BranchNO=" + this.BranchNO.Text + "WHERE ID=" + this.ID.Text;
                    command.ExecuteNonQuery();
                }
                if (this.Salary.Text != "")
                {
                    command.CommandText = "UPDATE EMPLOYEE SET Salary=" + this.Salary.Text + "WHERE ID=" + this.ID.Text;
                    command.ExecuteNonQuery();
                }
                if (this.City.Text != "")
                {
                    command.CommandText = "UPDATE EMPLOYEE SET City=" + "\'" + this.City.Text + "\'" + "WHERE ID=" + this.ID.Text;
                    command.ExecuteNonQuery();
                }
                if (this.Phone1.Text != "")
                {
                    command.CommandText = "UPDATE EMPLOYEE SET PhoneNO=" + "\'" + this.Phone1.Text + "\'" + "WHERE ID=" + this.ID.Text;
                    command.ExecuteNonQuery();
                }
                if (this.Country.Text != "")
                {
                    command.CommandText = "UPDATE EMPLOYEE SET Country=" + "\'" + this.Country.Text + "\'" + "WHERE ID=" + this.ID.Text;
                    command.ExecuteNonQuery();
                }
            }

            connection.Close();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.ID.Text = "";
            this.Fname.Text = "";
            this.Llast.Text = "";
            this.Role.Text = "";
            this.City.Text = "";
            this.Country.Text = "";
            this.ZipCode.Text = "";
            this.Phone1.Text = "";
            this.Salary.Text = "";
            this.BranchNO.Text = "";
            this.Gender.Text = "";

        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
