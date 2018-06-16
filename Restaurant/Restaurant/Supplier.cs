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
    public partial class Supplier : Form
    {
        public Supplier()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string var = "";
            if (this.SupplierID.Text != "")
            {
                SqlConnection connection = new SqlConnection("Data Source=MOHAMED_HDRMI;Initial Catalog=Restaurant;Integrated Security=True");
                SqlCommand command = new SqlCommand("", connection);
                connection.Open();
                command.CommandText = "SELECT CAST(COUNT(1) AS BIT) AS Expr1 FROM SUPPLIER WHERE SUPPLIER.SupplierID=" + this.SupplierID.Text;
                command.ExecuteNonQuery();
                DataTable dt = new DataTable();
                SqlDataAdapter reader = new SqlDataAdapter(command);
                reader.Fill(dt);
                var = dt.Rows[0][0].ToString();
                connection.Close();
            }
            if(var == "0")
            {
                if (this.SupplierID.Text != "" && this.SupplierName.Text != "" && this.Suppieditem.Text != ""
                   && this.ContactNO.Text != "" && this.City.Text != "" && this.Country.Text != ""
                   && this.ZipCode.Text != "" && this.BranchNO.Text != "")
                {
                    SqlConnection connection = new SqlConnection("Data Source=MOHAMED_HDRMI;Initial Catalog=Restaurant;Integrated Security=True");
                    SqlCommand command = new SqlCommand("", connection);
                    connection.Open();
                    command.CommandText = "INSERT INTO SUPPLIER (SupplierID,SupplierName,ContactNo,SuppliedItem,City,Country,ZipCode) VALUES ('"
                        + this.SupplierID.Text + "','" + this.SupplierName.Text + "','" + this.ContactNO.Text + "','"
                        + this.Suppieditem.Text + "','" + this.City.Text + "','" + this.Country.Text + "','"
                        + this.ZipCode.Text + "')";
                    command.ExecuteNonQuery();
                    connection.Close();
                }
                else
                {
                    MessageBox.Show("Some Information Not Entering");
                    return;
                }
            }
            {
                SqlConnection connection = new SqlConnection("Data Source=MOHAMED_HDRMI;Initial Catalog=Restaurant;Integrated Security=True");
                SqlCommand command = new SqlCommand("", connection);
                connection.Open();
                command.CommandText = "INSERT INTO SUPPLIEDBY (SupplierID,BranchNO) VALUES ('" + this.SupplierID.Text + "','"
                    + this.BranchNO.Text + "')";
                command.ExecuteNonQuery();
                connection.Close();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (this.SupplierID.Text != "")
            {
                SqlConnection connection = new SqlConnection("Data Source=MOHAMED_HDRMI;Initial Catalog=Restaurant;Integrated Security=True");
                SqlCommand command = new SqlCommand("", connection);
                connection.Open();
                command.CommandText = "DELETE FROM SUPPLIER WHERE SupplierID=" + this.SupplierID.Text;
                command.ExecuteNonQuery();
                connection.Close();
            }
            else
                MessageBox.Show("Please Enter ID For Supplier You Went Deleted");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection("Data Source=MOHAMED_HDRMI;Initial Catalog=Restaurant;Integrated Security=True");
            SqlCommand command = new SqlCommand("", connection);
            connection.Open();
            if (this.SupplierID.Text != "")
            {
                if (this.Suppieditem.Text != "")
                {
                    command.CommandText = "UPDATE SUPPLIER SET SuppiedItem=" + "\'" + this.Suppieditem.Text + "\'" + "WHERE SupplierID=" + this.SupplierID.Text;
                    command.ExecuteNonQuery();
                }
                if (this.ContactNO.Text != "")
                {
                    command.CommandText = "UPDATE SUPPLIER SET ContactNO=" + this.ContactNO.Text + "WHERE SupplierID=" + this.SupplierID.Text;
                    command.ExecuteNonQuery();
                }
                if (this.City.Text != "")
                {
                    command.CommandText = "UPDATE SUPPLIER SET City=" + "\'" + this.City.Text + "\'" + "WHERE SupplierID=" + this.SupplierID.Text;
                    command.ExecuteNonQuery();
                }
                if (this.Country.Text != "")
                {
                    command.CommandText = "UPDATE SUPPLIER SET Country=" + "\'" + this.Country.Text + "\'" + "WHERE SupplierID=" + this.SupplierID.Text;
                    command.ExecuteNonQuery();
                }
                if (this.ZipCode.Text != "")
                {
                    command.CommandText = "UPDATE SUPPLIER SET ZipCode=" + "\'" + this.ZipCode.Text + "\'" + "WHERE SupplierID=" + this.SupplierID.Text;
                    command.ExecuteNonQuery();
                }
            }

            connection.Close();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.SupplierID.Text = "";
            this.SupplierName.Text = "";
            this.Suppieditem.Text = "";
            this.City.Text = "";
            this.Country.Text = "";
            this.ContactNO.Text = "";
            this.ZipCode.Text = "";
            this.BranchNO.Text = "";
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Supplier_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'restaurantDataSet.SUPPLIER' table. You can move, or remove it, as needed.
            this.sUPPLIERTableAdapter.Fill(this.restaurantDataSet.SUPPLIER);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'restaurantDataSet.SUPPLIER' table. You can move, or remove it, as needed.
            this.sUPPLIERTableAdapter.Fill(this.restaurantDataSet.SUPPLIER);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Main main = new Main();
            main.Show();
            this.Hide();
        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
