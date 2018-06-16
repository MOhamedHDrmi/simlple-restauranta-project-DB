namespace Restaurant
{
    partial class Order
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.Price = new System.Windows.Forms.TextBox();
            this.Quantity = new System.Windows.Forms.TextBox();
            this.TableNO = new System.Windows.Forms.TextBox();
            this.OrderName = new System.Windows.Forms.TextBox();
            this.OrderID = new System.Windows.Forms.TextBox();
            this.PRI = new System.Windows.Forms.Label();
            this.QUAN = new System.Windows.Forms.Label();
            this.TABLE_NO = new System.Windows.Forms.Label();
            this.ORDER_NAME = new System.Windows.Forms.Label();
            this.ORDER_ID = new System.Windows.Forms.Label();
            this.CUSTOMER_ID = new System.Windows.Forms.Label();
            this.CustomerID = new System.Windows.Forms.TextBox();
            this.EMPLOYEE_ID = new System.Windows.Forms.Label();
            this.EMPID = new System.Windows.Forms.TextBox();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.Back = new System.Windows.Forms.Button();
            this.Insert_Meals = new System.Windows.Forms.Button();
            this.MealID = new System.Windows.Forms.TextBox();
            this.MEAL_ID = new System.Windows.Forms.Label();
            this.Takeaway = new System.Windows.Forms.CheckBox();
            this.OrderList = new System.Windows.Forms.DataGridView();
            this.orderIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customerIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.orderNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.takeawayDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.tableNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.oRDERBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.restaurantDataSet = new Restaurant.RestaurantDataSet();
            this.oRDERTableAdapter = new Restaurant.RestaurantDataSetTableAdapters.ORDERTableAdapter();
            this.MEALS = new System.Windows.Forms.DataGridView();
            this.mealIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mealNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.categoryDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mealDescriptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mealBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mealTableAdapter = new Restaurant.RestaurantDataSetTableAdapters.MealTableAdapter();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.orderIDDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mealIDDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iNCLUDEBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.iNCLUDETableAdapter = new Restaurant.RestaurantDataSetTableAdapters.INCLUDETableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.OrderList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.oRDERBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.restaurantDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MEALS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mealBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iNCLUDEBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(602, 457);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(90, 52);
            this.button5.TabIndex = 103;
            this.button5.Text = "Back";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.button4.Location = new System.Drawing.Point(673, 370);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(90, 59);
            this.button4.TabIndex = 102;
            this.button4.Text = "View";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.button3.Location = new System.Drawing.Point(568, 370);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(88, 59);
            this.button3.TabIndex = 101;
            this.button3.Text = "Update";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.button2.Location = new System.Drawing.Point(467, 370);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(84, 59);
            this.button2.TabIndex = 100;
            this.button2.Text = "Delete";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.button1.Location = new System.Drawing.Point(370, 370);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(80, 59);
            this.button1.TabIndex = 99;
            this.button1.Text = "Insert";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Price
            // 
            this.Price.Location = new System.Drawing.Point(97, 200);
            this.Price.Name = "Price";
            this.Price.Size = new System.Drawing.Size(100, 20);
            this.Price.TabIndex = 97;
            // 
            // Quantity
            // 
            this.Quantity.Location = new System.Drawing.Point(97, 104);
            this.Quantity.Name = "Quantity";
            this.Quantity.Size = new System.Drawing.Size(100, 20);
            this.Quantity.TabIndex = 96;
            // 
            // TableNO
            // 
            this.TableNO.Location = new System.Drawing.Point(97, 174);
            this.TableNO.Name = "TableNO";
            this.TableNO.Size = new System.Drawing.Size(100, 20);
            this.TableNO.TabIndex = 95;
            // 
            // OrderName
            // 
            this.OrderName.Location = new System.Drawing.Point(97, 53);
            this.OrderName.Name = "OrderName";
            this.OrderName.Size = new System.Drawing.Size(100, 20);
            this.OrderName.TabIndex = 93;
            // 
            // OrderID
            // 
            this.OrderID.Location = new System.Drawing.Point(97, 22);
            this.OrderID.Name = "OrderID";
            this.OrderID.Size = new System.Drawing.Size(100, 20);
            this.OrderID.TabIndex = 92;
            // 
            // PRI
            // 
            this.PRI.AutoSize = true;
            this.PRI.Location = new System.Drawing.Point(23, 200);
            this.PRI.Name = "PRI";
            this.PRI.Size = new System.Drawing.Size(31, 13);
            this.PRI.TabIndex = 90;
            this.PRI.Text = "Price";
            // 
            // QUAN
            // 
            this.QUAN.AutoSize = true;
            this.QUAN.Location = new System.Drawing.Point(23, 104);
            this.QUAN.Name = "QUAN";
            this.QUAN.Size = new System.Drawing.Size(46, 13);
            this.QUAN.TabIndex = 89;
            this.QUAN.Text = "Quantity";
            // 
            // TABLE_NO
            // 
            this.TABLE_NO.AutoSize = true;
            this.TABLE_NO.Location = new System.Drawing.Point(23, 174);
            this.TABLE_NO.Name = "TABLE_NO";
            this.TABLE_NO.Size = new System.Drawing.Size(53, 13);
            this.TABLE_NO.TabIndex = 88;
            this.TABLE_NO.Text = "Table NO";
            // 
            // ORDER_NAME
            // 
            this.ORDER_NAME.AutoSize = true;
            this.ORDER_NAME.Location = new System.Drawing.Point(23, 53);
            this.ORDER_NAME.Name = "ORDER_NAME";
            this.ORDER_NAME.Size = new System.Drawing.Size(64, 13);
            this.ORDER_NAME.TabIndex = 86;
            this.ORDER_NAME.Text = "Order Name";
            // 
            // ORDER_ID
            // 
            this.ORDER_ID.AutoSize = true;
            this.ORDER_ID.Location = new System.Drawing.Point(23, 22);
            this.ORDER_ID.Name = "ORDER_ID";
            this.ORDER_ID.Size = new System.Drawing.Size(47, 13);
            this.ORDER_ID.TabIndex = 85;
            this.ORDER_ID.Text = "Order ID";
            // 
            // CUSTOMER_ID
            // 
            this.CUSTOMER_ID.AutoSize = true;
            this.CUSTOMER_ID.Location = new System.Drawing.Point(23, 82);
            this.CUSTOMER_ID.Name = "CUSTOMER_ID";
            this.CUSTOMER_ID.Size = new System.Drawing.Size(65, 13);
            this.CUSTOMER_ID.TabIndex = 86;
            this.CUSTOMER_ID.Text = "Customer ID";
            this.CUSTOMER_ID.Click += new System.EventHandler(this.label7_Click);
            // 
            // CustomerID
            // 
            this.CustomerID.Location = new System.Drawing.Point(97, 82);
            this.CustomerID.Name = "CustomerID";
            this.CustomerID.Size = new System.Drawing.Size(100, 20);
            this.CustomerID.TabIndex = 93;
            this.CustomerID.TextChanged += new System.EventHandler(this.CustomerID_TextChanged);
            // 
            // EMPLOYEE_ID
            // 
            this.EMPLOYEE_ID.AutoSize = true;
            this.EMPLOYEE_ID.Location = new System.Drawing.Point(23, 111);
            this.EMPLOYEE_ID.Name = "EMPLOYEE_ID";
            this.EMPLOYEE_ID.Size = new System.Drawing.Size(67, 13);
            this.EMPLOYEE_ID.TabIndex = 86;
            this.EMPLOYEE_ID.Text = "Employee ID";
            this.EMPLOYEE_ID.Click += new System.EventHandler(this.label7_Click);
            // 
            // EMPID
            // 
            this.EMPID.Location = new System.Drawing.Point(97, 111);
            this.EMPID.Name = "EMPID";
            this.EMPID.Size = new System.Drawing.Size(100, 20);
            this.EMPID.TabIndex = 93;
            this.EMPID.TextChanged += new System.EventHandler(this.CustomerID_TextChanged);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(454, 457);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(142, 52);
            this.button6.TabIndex = 104;
            this.button6.Text = "Clear";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(12, 276);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(114, 43);
            this.button7.TabIndex = 106;
            this.button7.Text = "Choose Your Meals";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // Back
            // 
            this.Back.Location = new System.Drawing.Point(145, 276);
            this.Back.Name = "Back";
            this.Back.Size = new System.Drawing.Size(109, 43);
            this.Back.TabIndex = 108;
            this.Back.Text = "Order";
            this.Back.UseVisualStyleBackColor = true;
            this.Back.Click += new System.EventHandler(this.Back_Click);
            // 
            // Insert_Meals
            // 
            this.Insert_Meals.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.Insert_Meals.Location = new System.Drawing.Point(89, 223);
            this.Insert_Meals.Name = "Insert_Meals";
            this.Insert_Meals.Size = new System.Drawing.Size(108, 47);
            this.Insert_Meals.TabIndex = 109;
            this.Insert_Meals.Text = "Insert";
            this.Insert_Meals.UseVisualStyleBackColor = false;
            this.Insert_Meals.Click += new System.EventHandler(this.Insert_Meals_Click);
            // 
            // MealID
            // 
            this.MealID.Location = new System.Drawing.Point(97, 66);
            this.MealID.Name = "MealID";
            this.MealID.ReadOnly = true;
            this.MealID.Size = new System.Drawing.Size(100, 20);
            this.MealID.TabIndex = 111;
            // 
            // MEAL_ID
            // 
            this.MEAL_ID.AutoSize = true;
            this.MEAL_ID.Location = new System.Drawing.Point(23, 69);
            this.MEAL_ID.Name = "MEAL_ID";
            this.MEAL_ID.Size = new System.Drawing.Size(75, 13);
            this.MEAL_ID.TabIndex = 110;
            this.MEAL_ID.Text = "Enter Meal ID ";
            // 
            // Takeaway
            // 
            this.Takeaway.AutoSize = true;
            this.Takeaway.Location = new System.Drawing.Point(97, 145);
            this.Takeaway.Name = "Takeaway";
            this.Takeaway.Size = new System.Drawing.Size(77, 17);
            this.Takeaway.TabIndex = 112;
            this.Takeaway.Text = "TakeAway";
            this.Takeaway.UseVisualStyleBackColor = true;
            this.Takeaway.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // OrderList
            // 
            this.OrderList.AutoGenerateColumns = false;
            this.OrderList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.OrderList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.orderIDDataGridViewTextBoxColumn,
            this.customerIDDataGridViewTextBoxColumn,
            this.iDDataGridViewTextBoxColumn,
            this.orderNameDataGridViewTextBoxColumn,
            this.priceDataGridViewTextBoxColumn,
            this.takeawayDataGridViewCheckBoxColumn,
            this.tableNoDataGridViewTextBoxColumn});
            this.OrderList.DataSource = this.oRDERBindingSource;
            this.OrderList.Location = new System.Drawing.Point(317, 22);
            this.OrderList.Name = "OrderList";
            this.OrderList.Size = new System.Drawing.Size(456, 322);
            this.OrderList.TabIndex = 113;
            // 
            // orderIDDataGridViewTextBoxColumn
            // 
            this.orderIDDataGridViewTextBoxColumn.DataPropertyName = "OrderID";
            this.orderIDDataGridViewTextBoxColumn.HeaderText = "OrderID";
            this.orderIDDataGridViewTextBoxColumn.Name = "orderIDDataGridViewTextBoxColumn";
            // 
            // customerIDDataGridViewTextBoxColumn
            // 
            this.customerIDDataGridViewTextBoxColumn.DataPropertyName = "CustomerID";
            this.customerIDDataGridViewTextBoxColumn.HeaderText = "CustomerID";
            this.customerIDDataGridViewTextBoxColumn.Name = "customerIDDataGridViewTextBoxColumn";
            // 
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            // 
            // orderNameDataGridViewTextBoxColumn
            // 
            this.orderNameDataGridViewTextBoxColumn.DataPropertyName = "OrderName";
            this.orderNameDataGridViewTextBoxColumn.HeaderText = "OrderName";
            this.orderNameDataGridViewTextBoxColumn.Name = "orderNameDataGridViewTextBoxColumn";
            // 
            // priceDataGridViewTextBoxColumn
            // 
            this.priceDataGridViewTextBoxColumn.DataPropertyName = "Price";
            this.priceDataGridViewTextBoxColumn.HeaderText = "Price";
            this.priceDataGridViewTextBoxColumn.Name = "priceDataGridViewTextBoxColumn";
            // 
            // takeawayDataGridViewCheckBoxColumn
            // 
            this.takeawayDataGridViewCheckBoxColumn.DataPropertyName = "Takeaway";
            this.takeawayDataGridViewCheckBoxColumn.HeaderText = "Takeaway";
            this.takeawayDataGridViewCheckBoxColumn.Name = "takeawayDataGridViewCheckBoxColumn";
            // 
            // tableNoDataGridViewTextBoxColumn
            // 
            this.tableNoDataGridViewTextBoxColumn.DataPropertyName = "TableNo";
            this.tableNoDataGridViewTextBoxColumn.HeaderText = "TableNo";
            this.tableNoDataGridViewTextBoxColumn.Name = "tableNoDataGridViewTextBoxColumn";
            // 
            // oRDERBindingSource
            // 
            this.oRDERBindingSource.DataMember = "ORDER";
            this.oRDERBindingSource.DataSource = this.restaurantDataSet;
            // 
            // restaurantDataSet
            // 
            this.restaurantDataSet.DataSetName = "RestaurantDataSet";
            this.restaurantDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // oRDERTableAdapter
            // 
            this.oRDERTableAdapter.ClearBeforeFill = true;
            // 
            // MEALS
            // 
            this.MEALS.AutoGenerateColumns = false;
            this.MEALS.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.MEALS.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.mealIDDataGridViewTextBoxColumn,
            this.mealNameDataGridViewTextBoxColumn,
            this.categoryDataGridViewTextBoxColumn,
            this.priceDataGridViewTextBoxColumn1,
            this.mealDescriptionDataGridViewTextBoxColumn});
            this.MEALS.DataSource = this.mealBindingSource;
            this.MEALS.Location = new System.Drawing.Point(317, 22);
            this.MEALS.Name = "MEALS";
            this.MEALS.Size = new System.Drawing.Size(456, 322);
            this.MEALS.TabIndex = 114;
            this.MEALS.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.MEALS_CellContentClick_1);
            // 
            // mealIDDataGridViewTextBoxColumn
            // 
            this.mealIDDataGridViewTextBoxColumn.DataPropertyName = "MealID";
            this.mealIDDataGridViewTextBoxColumn.HeaderText = "MealID";
            this.mealIDDataGridViewTextBoxColumn.Name = "mealIDDataGridViewTextBoxColumn";
            // 
            // mealNameDataGridViewTextBoxColumn
            // 
            this.mealNameDataGridViewTextBoxColumn.DataPropertyName = "MealName";
            this.mealNameDataGridViewTextBoxColumn.HeaderText = "MealName";
            this.mealNameDataGridViewTextBoxColumn.Name = "mealNameDataGridViewTextBoxColumn";
            // 
            // categoryDataGridViewTextBoxColumn
            // 
            this.categoryDataGridViewTextBoxColumn.DataPropertyName = "Category";
            this.categoryDataGridViewTextBoxColumn.HeaderText = "Category";
            this.categoryDataGridViewTextBoxColumn.Name = "categoryDataGridViewTextBoxColumn";
            // 
            // priceDataGridViewTextBoxColumn1
            // 
            this.priceDataGridViewTextBoxColumn1.DataPropertyName = "Price";
            this.priceDataGridViewTextBoxColumn1.HeaderText = "Price";
            this.priceDataGridViewTextBoxColumn1.Name = "priceDataGridViewTextBoxColumn1";
            // 
            // mealDescriptionDataGridViewTextBoxColumn
            // 
            this.mealDescriptionDataGridViewTextBoxColumn.DataPropertyName = "MealDescription";
            this.mealDescriptionDataGridViewTextBoxColumn.HeaderText = "MealDescription";
            this.mealDescriptionDataGridViewTextBoxColumn.Name = "mealDescriptionDataGridViewTextBoxColumn";
            // 
            // mealBindingSource
            // 
            this.mealBindingSource.DataMember = "Meal";
            this.mealBindingSource.DataSource = this.restaurantDataSet;
            // 
            // mealTableAdapter
            // 
            this.mealTableAdapter.ClearBeforeFill = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.orderIDDataGridViewTextBoxColumn1,
            this.mealIDDataGridViewTextBoxColumn1,
            this.quantityDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.iNCLUDEBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 359);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(344, 150);
            this.dataGridView1.TabIndex = 115;
            // 
            // orderIDDataGridViewTextBoxColumn1
            // 
            this.orderIDDataGridViewTextBoxColumn1.DataPropertyName = "OrderID";
            this.orderIDDataGridViewTextBoxColumn1.HeaderText = "OrderID";
            this.orderIDDataGridViewTextBoxColumn1.Name = "orderIDDataGridViewTextBoxColumn1";
            // 
            // mealIDDataGridViewTextBoxColumn1
            // 
            this.mealIDDataGridViewTextBoxColumn1.DataPropertyName = "MealID";
            this.mealIDDataGridViewTextBoxColumn1.HeaderText = "MealID";
            this.mealIDDataGridViewTextBoxColumn1.Name = "mealIDDataGridViewTextBoxColumn1";
            // 
            // quantityDataGridViewTextBoxColumn
            // 
            this.quantityDataGridViewTextBoxColumn.DataPropertyName = "Quantity";
            this.quantityDataGridViewTextBoxColumn.HeaderText = "Quantity";
            this.quantityDataGridViewTextBoxColumn.Name = "quantityDataGridViewTextBoxColumn";
            // 
            // iNCLUDEBindingSource
            // 
            this.iNCLUDEBindingSource.DataMember = "INCLUDE";
            this.iNCLUDEBindingSource.DataSource = this.restaurantDataSet;
            // 
            // iNCLUDETableAdapter
            // 
            this.iNCLUDETableAdapter.ClearBeforeFill = true;
            // 
            // Order
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(795, 535);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.MEALS);
            this.Controls.Add(this.OrderList);
            this.Controls.Add(this.Takeaway);
            this.Controls.Add(this.MealID);
            this.Controls.Add(this.MEAL_ID);
            this.Controls.Add(this.Insert_Meals);
            this.Controls.Add(this.Back);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Price);
            this.Controls.Add(this.Quantity);
            this.Controls.Add(this.TableNO);
            this.Controls.Add(this.EMPID);
            this.Controls.Add(this.CustomerID);
            this.Controls.Add(this.OrderName);
            this.Controls.Add(this.OrderID);
            this.Controls.Add(this.PRI);
            this.Controls.Add(this.QUAN);
            this.Controls.Add(this.EMPLOYEE_ID);
            this.Controls.Add(this.TABLE_NO);
            this.Controls.Add(this.CUSTOMER_ID);
            this.Controls.Add(this.ORDER_NAME);
            this.Controls.Add(this.ORDER_ID);
            this.Name = "Order";
            this.Text = "Order";
            this.Load += new System.EventHandler(this.Order_Load);
            ((System.ComponentModel.ISupportInitialize)(this.OrderList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.oRDERBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.restaurantDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MEALS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mealBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iNCLUDEBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox Price;
        private System.Windows.Forms.TextBox Quantity;
        private System.Windows.Forms.TextBox TableNO;
        private System.Windows.Forms.TextBox OrderName;
        private System.Windows.Forms.TextBox OrderID;
        private System.Windows.Forms.Label PRI;
        private System.Windows.Forms.Label QUAN;
        private System.Windows.Forms.Label TABLE_NO;
        private System.Windows.Forms.Label ORDER_NAME;
        private System.Windows.Forms.Label ORDER_ID;
        //OrderList-MEALS
        private System.Windows.Forms.Label CUSTOMER_ID;
        private System.Windows.Forms.TextBox CustomerID;
        private System.Windows.Forms.Label EMPLOYEE_ID;
        private System.Windows.Forms.TextBox EMPID; 
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button Back;
        private System.Windows.Forms.Button Insert_Meals;
        private System.Windows.Forms.TextBox MealID;
        private System.Windows.Forms.Label MEAL_ID;
        private System.Windows.Forms.CheckBox Takeaway;
        private System.Windows.Forms.DataGridView OrderList;
        private RestaurantDataSet restaurantDataSet;
        private System.Windows.Forms.BindingSource oRDERBindingSource;
        private RestaurantDataSetTableAdapters.ORDERTableAdapter oRDERTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn orderIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn customerIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn orderNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn takeawayDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tableNoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridView MEALS;
        private System.Windows.Forms.BindingSource mealBindingSource;
        private RestaurantDataSetTableAdapters.MealTableAdapter mealTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn mealIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mealNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn categoryDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn mealDescriptionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource iNCLUDEBindingSource;
        private RestaurantDataSetTableAdapters.INCLUDETableAdapter iNCLUDETableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn orderIDDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn mealIDDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantityDataGridViewTextBoxColumn;
    }
}