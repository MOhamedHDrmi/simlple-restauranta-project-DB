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
    public partial class Branch : Form
    {
        public Branch()
        {
            InitializeComponent();
        }

        private void Branch_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'restaurantDataSet.SUPPLIEDBY' table. You can move, or remove it, as needed.
            this.sUPPLIEDBYTableAdapter.Fill(this.restaurantDataSet.SUPPLIEDBY);
            // TODO: This line of code loads data into the 'restaurantDataSet.BRANCH' table. You can move, or remove it, as needed.
            this.bRANCHTableAdapter.Fill(this.restaurantDataSet.BRANCH);
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (this.BranchNO.Text != "" && this.Location.Text != "")
            {
                SqlConnection connection = new SqlConnection("Data Source=MOHAMED_HDRMI;Initial Catalog=Restaurant;Integrated Security=True");
                SqlCommand command = new SqlCommand("", connection);
                connection.Open();
                command.CommandText = "INSERT INTO BRANCH (BranchNO,Location) VALUES ('" + this.BranchNO.Text + "','"
                    + this.Location.Text + "')";
                command.ExecuteNonQuery();
                connection.Close();
            }
            else
                MessageBox.Show("Some Informtion Not Entering");

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'restaurantDataSet.SUPPLIEDBY' table. You can move, or remove it, as needed.
            this.sUPPLIEDBYTableAdapter.Fill(this.restaurantDataSet.SUPPLIEDBY);
            // TODO: This line of code loads data into the 'restaurantDataSet.BRANCH' table. You can move, or remove it, as needed.
            this.bRANCHTableAdapter.Fill(this.restaurantDataSet.BRANCH);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.BranchNO.Text = "";
            this.Location.Text = "";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (this.BranchNO.Text!="")
            {
                SqlConnection connection = new SqlConnection("Data Source=MOHAMED_HDRMI;Initial Catalog=Restaurant;Integrated Security=True");
                SqlCommand command = new SqlCommand("", connection);
                connection.Open();
                command.CommandText = "DELETE FROM BRANCH WHERE BranchNO=" + this.BranchNO.Text;
                command.ExecuteNonQuery();
                connection.Close();
            }
            else
                MessageBox.Show("Enter Branch NO");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection("Data Source=MOHAMED_HDRMI;Initial Catalog=Restaurant;Integrated Security=True");
            SqlCommand command = new SqlCommand("", connection);
            connection.Open();
            if (this.BranchNO.Text != "")
            {
                command.CommandText = "UPDATE BRANCH SET Location =" + "\'" + this.Location.Text + "\'" + "WHERE BranchNO=" + this.BranchNO.Text;
                command.ExecuteNonQuery();
            }
            connection.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Main main = new Main();
            main.Show();
            this.Hide();
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
