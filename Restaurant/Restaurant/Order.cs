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
    public partial class Order : Form
    {
        public Order()
        {
            InitializeComponent();
        }

        private void CustomerID_TextChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void Order_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'restaurantDataSet.INCLUDE' table. You can move, or remove it, as needed.
            this.iNCLUDETableAdapter.Fill(this.restaurantDataSet.INCLUDE);
            // TODO: This line of code loads data into the 'restaurantDataSet.Meal' table. You can move, or remove it, as needed.
            this.mealTableAdapter.Fill(this.restaurantDataSet.Meal);
            // TODO: This line of code loads data into the 'restaurantDataSet.ORDER' table. You can move, or remove it, as needed.
            this.oRDERTableAdapter.Fill(this.restaurantDataSet.ORDER);

            this.MEALS.Hide();
            this.Back.Visible = false;
            this.Insert_Meals.Visible = false;
            this.MealID.Hide();
            this.MEAL_ID.Hide();
            this.Quantity.Hide();
            this.QUAN.Hide();
            this.Price.Hide();
            this.PRI.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(this.EMPID.Text == "" && this.CustomerID.Text == "" && this.OrderID.Text != "" && this.OrderName.Text != "")
            {
                SqlConnection connection = new SqlConnection("Data Source=MOHAMED_HDRMI;Initial Catalog=Restaurant;Integrated Security=True");
                SqlCommand command = new SqlCommand("", connection);
                connection.Open();
                command.CommandText = "INSERT INTO [ORDER] (OrderID,OrderName,Price,Takeaway,TableNO) VALUES('"
                    + this.OrderID.Text + "','" + this.OrderName.Text + "','" 
                    + this.Price.Text + "','" + this.Takeaway.Checked + "','" + this.TableNO.Text + "')";
                command.ExecuteNonQuery();
                connection.Close();
            }
            else if (this.OrderID.Text != "" && this.OrderName.Text != "" && this.EMPID.Text != "" && this.CustomerID.Text != "")
            {
                SqlConnection connection = new SqlConnection("Data Source=MOHAMED_HDRMI;Initial Catalog=Restaurant;Integrated Security=True");
                SqlCommand command = new SqlCommand("", connection);
                connection.Open();
                command.CommandText = "INSERT INTO [ORDER] (OrderID,OrderName,CustomerID,ID,Price,Takeaway,TableNO) VALUES('"
                    + this.OrderID.Text + "','" + this.OrderName.Text + "','" + this.CustomerID.Text + "','" + this.EMPID.Text + "','"
                    + this.Price.Text + "','" + this.Takeaway.Checked + "','" + this.TableNO.Text + "')";
                command.ExecuteNonQuery();
                connection.Close();
            }
            else
                MessageBox.Show("Some Information Not Entering");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (this.OrderID.Text != "")
            {
                SqlConnection connection = new SqlConnection("Data Source=MOHAMED_HDRMI;Initial Catalog=Restaurant;Integrated Security=True");
                SqlCommand command = new SqlCommand("", connection);
                connection.Open();
                command.CommandText = "DELETE FROM [ORDER] WHERE OrderID=" + this.OrderID.Text;
                command.ExecuteNonQuery();
                connection.Close();
            }
            else
                MessageBox.Show("Please Enter ID For Order You Want Deleted");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection("Data Source=MOHAMED_HDRMI;Initial Catalog=Restaurant;Integrated Security=True");
            SqlCommand command = new SqlCommand("", connection);
            connection.Open();
            if (this.OrderID.Text != "")
            {
                if (this.OrderName.Text != "")
                {
                    command.CommandText = "UPDATE [ORDER] SET OrderName=" + "\'" + this.OrderName.Text + "\'" + " WHERE OrderID=" + this.OrderID.Text;
                    command.ExecuteNonQuery();
                }
            }
            connection.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'restaurantDataSet.INCLUDE' table. You can move, or remove it, as needed.
            this.iNCLUDETableAdapter.Fill(this.restaurantDataSet.INCLUDE);
            // TODO: This line of code loads data into the 'restaurantDataSet.Meal' table. You can move, or remove it, as needed.
            this.mealTableAdapter.Fill(this.restaurantDataSet.Meal);
            // TODO: This line of code loads data into the 'restaurantDataSet.ORDER' table. You can move, or remove it, as needed.
            this.oRDERTableAdapter.Fill(this.restaurantDataSet.ORDER);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Main main = new Main();
            main.Show();
            this.Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.OrderID.Text = "";
            this.OrderName.Text = "";
            this.Quantity.Text = "";
            this.CustomerID.Text = "";
            this.EMPID.Text = "";
            this.Price.Text = "";
            this.Takeaway.Text = "";
            this.TableNO.Text = "";
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        public string getOrderID()
        {
            return this.OrderID.Text;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.OrderList.Hide();
            this.MEALS.Show();
            this.EMPID.Hide();
            this.OrderName.Hide();
            this.CustomerID.Hide();
            this.Quantity.Show();
            this.Price.Hide();
            this.Takeaway.Hide();
            this.TableNO.Hide();
            this.ORDER_NAME.Hide();
            this.CUSTOMER_ID.Hide();
            this.EMPLOYEE_ID.Hide();
            this.QUAN.Show();
            this.PRI.Hide();
            this.TABLE_NO.Hide();
            this.Takeaway.Visible = false;
            this.button1.Visible = false;
            this.button2.Visible = false;
            this.button3.Visible = false;
            this.button4.Visible = false;
            this.button5.Visible = false;
            this.button6.Visible = false;
            this.Back.Visible = true;
            this.Insert_Meals.Visible = true;
            this.MealID.Show();
            this.MEAL_ID.Show();


            // TODO: This line of code loads data into the 'restaurantDataSet.Meal' table. You can move, or remove it, as needed.
            this.mealTableAdapter.Fill(this.restaurantDataSet.Meal);

            /*Choose_Meals choose = new Choose_Meals();
            choose.Show();*/
        }

        private void Insert_Meals_Click(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection("Data Source=MOHAMED_HDRMI;Initial Catalog=Restaurant;Integrated Security=True");
            SqlCommand command = new SqlCommand("", connection);
            if(this.OrderID.Text!="")
            {                
                connection.Open();
                command.CommandText = "SELECT CAST(COUNT(1) AS BIT) AS Expr1 FROM [ORDER] WHERE [ORDER].OrderID =" + this.OrderID.Text;
                command.ExecuteNonQuery();
                DataTable dt = new DataTable();
                SqlDataAdapter reader = new SqlDataAdapter(command);
                reader.Fill(dt);
                string var = dt.Rows[0][0].ToString();
                connection.Close();
                if(var=="0")
                {
                    return;
                }
            }  
            if (this.Quantity.Text != "" && this.OrderID.Text != "" && this.MealID.Text != "")
            {
                connection.Open();
                command.CommandText = "INSERT INTO INCLUDE (OrderID,MealID,Quantity) VALUES('"
                    + this.OrderID.Text + "','" + this.MealID.Text + "','" + this.Quantity.Text + "')";
                command.ExecuteNonQuery();
                connection.Close();
            }
            // TODO: This line of code loads data into the 'restaurantDataSet.INCLUDE' table. You can move, or remove it, as needed.
            this.iNCLUDETableAdapter.Fill(this.restaurantDataSet.INCLUDE);
        }

        private void Back_Click(object sender, EventArgs e)
        {
            if (this.Quantity.Text != "" && this.OrderID.Text != "" && this.MealID.Text != "")
            {
                SqlConnection connection = new SqlConnection("Data Source=MOHAMED_HDRMI;Initial Catalog=Restaurant;Integrated Security=True");
                SqlCommand command = new SqlCommand("", connection);
                connection.Open();
                command.CommandText = "Select sum(Meal.Price*[INCLUDE].Quantity) as TotalPrice From Meal ,[INCLUDE] Where Meal.MealID=[INCLUDE].MealID AND [INCLUDE].OrderID=" + this.OrderID.Text;
                command.ExecuteNonQuery();
                DataTable dt = new DataTable();
                SqlDataAdapter reader = new SqlDataAdapter(command);
                reader.Fill(dt);
                this.Price.Text = dt.Rows[0][0].ToString();
                command.CommandText = "UPDATE [ORDER] SET Price=" + this.Price.Text + " WHERE OrderID=" + this.OrderID.Text;
                command.ExecuteNonQuery();
                connection.Close();
                MessageBox.Show(this.Price.Text);
            }
            this.OrderList.Show();
            this.MEALS.Hide();
            this.EMPID.Show();
            this.OrderName.Show();
            this.CustomerID.Show();
            this.Quantity.Hide();
            //this.Price.Show();
            this.Takeaway.Show();
            this.TableNO.Show();
            this.ORDER_NAME.Show();
            this.CUSTOMER_ID.Show();
            this.EMPLOYEE_ID.Show();
            this.QUAN.Hide();
            //this.PRI.Show();
            this.TABLE_NO.Show();
            this.Takeaway.Visible = true;
            this.button1.Visible = true;
            this.button2.Visible = true;
            this.button3.Visible = true;
            this.button4.Visible = true;
            this.button5.Visible = true;
            this.button6.Visible = true;
            this.Back.Visible = false;
            this.Insert_Meals.Visible = false;
            this.MealID.Hide();
            this.MEAL_ID.Hide();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (this.Takeaway.Checked)
            {
                this.TableNO.Hide();
            }
            else
                this.TableNO.Show();

        }

        private void MEALS_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void OrderList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void MEALS_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.MEALS.Rows[e.RowIndex];
                this.MealID.Text = row.Cells["mealIDDataGridViewTextBoxColumn"].Value.ToString();
            }
        }
    }
}
