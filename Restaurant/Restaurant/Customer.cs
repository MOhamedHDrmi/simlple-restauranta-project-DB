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
    public partial class Customer : Form
    {
        public Customer()
        {
            InitializeComponent();
        }

        private void Customer_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'restaurantDataSet.CUSTOMER' table. You can move, or remove it, as needed.
            this.cUSTOMERTableAdapter.Fill(this.restaurantDataSet.CUSTOMER);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Main main = new Main();
            main.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (this.CustomerID.Text != "" && this.CustomerName.Text != "" && this.Country.Text != ""
                && this.City.Text != "" && this.ZipCode.Text != "" && this.TelePhone.Text != "")
            {
                SqlConnection connection = new SqlConnection("Data Source=MOHAMED_HDRMI;Initial Catalog=Restaurant;Integrated Security=True");
                SqlCommand command = new SqlCommand("", connection);
                connection.Open();
                command.CommandText = "INSERT INTO CUSTOMER (CustomerID,CustomerName,City,Country,ZipCode,PhoneNumber) VALUES('"
                    + this.CustomerID.Text + "','" + this.CustomerName.Text + "','" + this.City.Text
                    + "','" + this.Country.Text + "','" + this.ZipCode.Text + "','" + this.TelePhone.Text + "')";
                command.ExecuteNonQuery();
                connection.Close();
            }
            else
                MessageBox.Show("Some Information Not Entering");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (this.CustomerID.Text!="")
            {
                SqlConnection connection = new SqlConnection("Data Source=MOHAMED_HDRMI;Initial Catalog=Restaurant;Integrated Security=True");
                SqlCommand command = new SqlCommand("", connection);
                connection.Open();
                command.CommandText = "DELETE FROM CUSTOMER WHERE CustomerID=" + this.CustomerID.Text;
                command.ExecuteNonQuery();
                connection.Close();
            }
            else
                MessageBox.Show("Please Enter ID For Supplier You Went Deleted");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'restaurantDataSet.CUSTOMER' table. You can move, or remove it, as needed.
            this.cUSTOMERTableAdapter.Fill(this.restaurantDataSet.CUSTOMER);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection("Data Source=MOHAMED_HDRMI;Initial Catalog=Restaurant;Integrated Security=True");
            SqlCommand command = new SqlCommand("", connection);
            connection.Open();
            if (this.CustomerID.Text != "")
            {
                if (this.City.Text != "")
                {
                    command.CommandText = "UPDATE CUSTOMER SET City=" + "\'" + this.City.Text + "\'" + " WHERE CustomerID=" + this.CustomerID.Text;
                    command.ExecuteNonQuery();
                }
                if (this.Country.Text != "")
                {
                    command.CommandText = "UPDATE CUSTOMER SET Country=" + "\'" + this.Country.Text + "\'" + " WHERE CustomerID=" + this.CustomerID.Text;
                    command.ExecuteNonQuery();
                }
                if (this.ZipCode.Text != "")
                {
                    command.CommandText = "UPDATE CUSTOMER SET ZipCode=" + "\'" + this.ZipCode.Text + "\'" + " WHERE CustomerID=" + this.CustomerID.Text;
                    command.ExecuteNonQuery();
                }
                if (this.TelePhone.Text != "")
                {
                    command.CommandText = "UPDATE CUSTOMER SET PhoneNumber=" + "\'" + this.TelePhone.Text + "\'" + " WHERE CustomerID=" + this.CustomerID.Text;
                    command.ExecuteNonQuery();
                }
            }
            connection.Close();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Order order = new Order();
            order.Show();
            this.Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.CustomerID.Text = "";
            this.CustomerName.Text = "";
            this.TelePhone.Text = "";
            this.City.Text = "";
            this.Country.Text = "";
            this.ZipCode.Text = "";
        }
    }
}
