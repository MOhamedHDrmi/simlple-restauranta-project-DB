namespace Restaurant
{
    partial class Meal
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
            this.Category = new System.Windows.Forms.TextBox();
            this.Price = new System.Windows.Forms.TextBox();
            this.MD = new System.Windows.Forms.TextBox();
            this.MealName = new System.Windows.Forms.TextBox();
            this.MealID = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button6 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.restaurantDataSet = new Restaurant.RestaurantDataSet();
            this.mealBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mealTableAdapter = new Restaurant.RestaurantDataSetTableAdapters.MealTableAdapter();
            this.mealIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mealNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.categoryDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mealDescriptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.restaurantDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mealBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(687, 311);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(97, 42);
            this.button5.TabIndex = 104;
            this.button5.Text = "Back";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.button4.Location = new System.Drawing.Point(583, 303);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(90, 59);
            this.button4.TabIndex = 103;
            this.button4.Text = "View";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.button3.Location = new System.Drawing.Point(489, 303);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(88, 59);
            this.button3.TabIndex = 102;
            this.button3.Text = "Update";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.button2.Location = new System.Drawing.Point(395, 303);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(84, 59);
            this.button2.TabIndex = 101;
            this.button2.Text = "Delete";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.button1.Location = new System.Drawing.Point(299, 303);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(80, 59);
            this.button1.TabIndex = 100;
            this.button1.Text = "Insert";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Category
            // 
            this.Category.Location = new System.Drawing.Point(157, 184);
            this.Category.Name = "Category";
            this.Category.Size = new System.Drawing.Size(100, 20);
            this.Category.TabIndex = 99;
            // 
            // Price
            // 
            this.Price.Location = new System.Drawing.Point(157, 149);
            this.Price.Name = "Price";
            this.Price.Size = new System.Drawing.Size(100, 20);
            this.Price.TabIndex = 98;
            // 
            // MD
            // 
            this.MD.Location = new System.Drawing.Point(157, 113);
            this.MD.Name = "MD";
            this.MD.Size = new System.Drawing.Size(100, 20);
            this.MD.TabIndex = 97;
            // 
            // MealName
            // 
            this.MealName.Location = new System.Drawing.Point(157, 81);
            this.MealName.Name = "MealName";
            this.MealName.Size = new System.Drawing.Size(100, 20);
            this.MealName.TabIndex = 96;
            // 
            // MealID
            // 
            this.MealID.Location = new System.Drawing.Point(157, 50);
            this.MealID.Name = "MealID";
            this.MealID.Size = new System.Drawing.Size(100, 20);
            this.MealID.TabIndex = 95;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(38, 191);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(49, 13);
            this.label9.TabIndex = 94;
            this.label9.Text = "Category";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(39, 156);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 13);
            this.label4.TabIndex = 93;
            this.label4.Text = "Price";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(37, 120);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 13);
            this.label3.TabIndex = 92;
            this.label3.Text = "Meal Description";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(38, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 91;
            this.label2.Text = "Meal Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(38, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 90;
            this.label1.Text = "Meal ID";
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(42, 322);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(138, 51);
            this.button6.TabIndex = 105;
            this.button6.Text = "Clear";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.mealIDDataGridViewTextBoxColumn,
            this.mealNameDataGridViewTextBoxColumn,
            this.categoryDataGridViewTextBoxColumn,
            this.priceDataGridViewTextBoxColumn,
            this.mealDescriptionDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.mealBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(299, 34);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(485, 263);
            this.dataGridView1.TabIndex = 106;
            // 
            // restaurantDataSet
            // 
            this.restaurantDataSet.DataSetName = "RestaurantDataSet";
            this.restaurantDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            // priceDataGridViewTextBoxColumn
            // 
            this.priceDataGridViewTextBoxColumn.DataPropertyName = "Price";
            this.priceDataGridViewTextBoxColumn.HeaderText = "Price";
            this.priceDataGridViewTextBoxColumn.Name = "priceDataGridViewTextBoxColumn";
            // 
            // mealDescriptionDataGridViewTextBoxColumn
            // 
            this.mealDescriptionDataGridViewTextBoxColumn.DataPropertyName = "MealDescription";
            this.mealDescriptionDataGridViewTextBoxColumn.HeaderText = "MealDescription";
            this.mealDescriptionDataGridViewTextBoxColumn.Name = "mealDescriptionDataGridViewTextBoxColumn";
            // 
            // Meal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(820, 409);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Category);
            this.Controls.Add(this.Price);
            this.Controls.Add(this.MD);
            this.Controls.Add(this.MealName);
            this.Controls.Add(this.MealID);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Meal";
            this.Text = "Meal";
            this.Load += new System.EventHandler(this.Meal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.restaurantDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mealBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox Category;
        private System.Windows.Forms.TextBox Price;
        private System.Windows.Forms.TextBox MD;
        private System.Windows.Forms.TextBox MealName;
        private System.Windows.Forms.TextBox MealID;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.DataGridView dataGridView1;
        private RestaurantDataSet restaurantDataSet;
        private System.Windows.Forms.BindingSource mealBindingSource;
        private RestaurantDataSetTableAdapters.MealTableAdapter mealTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn mealIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mealNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn categoryDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mealDescriptionDataGridViewTextBoxColumn;
    }
}