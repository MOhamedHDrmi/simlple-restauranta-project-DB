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
    public partial class Meal : Form
    {
        public Meal()
        {
            InitializeComponent();
        }

        private void Meal_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'restaurantDataSet.Meal' table. You can move, or remove it, as needed.
            this.mealTableAdapter.Fill(this.restaurantDataSet.Meal);


        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (this.MealID.Text != "" && this.MealName.Text != "" && this.Price.Text != "" && this.MD.Text != "" && this.Category.Text != "")
            {
                SqlConnection connection = new SqlConnection("Data Source=MOHAMED_HDRMI;Initial Catalog=Restaurant;Integrated Security=True");
                SqlCommand command = new SqlCommand("", connection);
                connection.Open();
                command.CommandText = "INSERT INTO Meal (MealID,MealName,Category,Price,MealDescription) VALUES ('"
                    + this.MealID.Text + "','" + this.MealName.Text + "','" + this.Category.Text + "','" +
                    this.Price.Text + "','" + this.MD.Text + "')";
                command.ExecuteNonQuery();
                connection.Close();
            }
            else
                MessageBox.Show("Some Informtion Not Entering");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'restaurantDataSet.Meal' table. You can move, or remove it, as needed.
            this.mealTableAdapter.Fill(this.restaurantDataSet.Meal);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (this.MealID.Text != "")
            {
                SqlConnection connection = new SqlConnection("Data Source=MOHAMED_HDRMI;Initial Catalog=Restaurant;Integrated Security=True");
                SqlCommand command = new SqlCommand("", connection);
                connection.Open();
                command.CommandText = "DELETE FROM Meal WHERE MealID=" + this.MealID.Text;
                command.ExecuteNonQuery();
                connection.Close();
            }
            else
                MessageBox.Show("Please Enter ID For Meal You Went Deleted");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection("Data Source=MOHAMED_HDRMI;Initial Catalog=Restaurant;Integrated Security=True");
            SqlCommand command = new SqlCommand("", connection);
            connection.Open();
            if (this.MealID.Text != "")
            {
                if (this.Price.Text != "")
                {
                    command.CommandText = "UPDATE Meal SET Price=" + this.Price.Text + "WHERE MealID=" + this.MealID.Text;
                    command.ExecuteNonQuery();
                }
                if (this.MD.Text != "")
                {
                    command.CommandText = "UPDATE Meal SET MealDescription=" + "\'" + this.MD.Text + "\'" + "WHERE MealID=" + this.MealID.Text;
                    command.ExecuteNonQuery();
                }
            }
            connection.Close();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.MealID.Text = "";
            this.MealName.Text = "";
            this.MD.Text = "";
            this.Category.Text = "";
            this.Price.Text = "";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Main main = new Main();
            main.Show();
            this.Hide();
        }
    }
}
