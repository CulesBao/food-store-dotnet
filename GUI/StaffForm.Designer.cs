namespace FoodStore.GUI
{
    partial class StaffForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtName = new System.Windows.Forms.Label();
            this.btnLogout = new System.Windows.Forms.Button();
            this.btnHistory = new System.Windows.Forms.Button();
            this.btnOrder = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panelPlaceOrder = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.tbTotal = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.btnCreateOrder = new System.Windows.Forms.Button();
            this.dgvOrder = new System.Windows.Forms.DataGridView();
            this.tbDetailCustomPN = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tbDetailCustomerName = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.tbFoodId = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnAddOrderItem = new System.Windows.Forms.Button();
            this.tbOrders = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbFoodQuantity = new System.Windows.Forms.TextBox();
            this.tbFoodPrice = new System.Windows.Forms.TextBox();
            this.tbFoodName = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnFoodFind = new System.Windows.Forms.Button();
            this.tbFoodFindByName = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.dgvFood = new System.Windows.Forms.DataGridView();
            this.panelHistory = new System.Windows.Forms.Panel();
            this.tbOrderQuantity = new System.Windows.Forms.TextBox();
            this.label21 = new System.Windows.Forms.Label();
            this.tbTotalRevenue = new System.Windows.Forms.TextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.btnDetailOrder = new System.Windows.Forms.Button();
            this.btnFindRevenue = new System.Windows.Forms.Button();
            this.btnUpdateOrder = new System.Windows.Forms.Button();
            this.cmbStatus = new System.Windows.Forms.ComboBox();
            this.label19 = new System.Windows.Forms.Label();
            this.tbOrderId = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.dgvRevenue = new System.Windows.Forms.DataGridView();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.dtpEnd = new System.Windows.Forms.DateTimePicker();
            this.dtpStart = new System.Windows.Forms.DateTimePicker();
            this.panel1.SuspendLayout();
            this.panelPlaceOrder.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrder)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFood)).BeginInit();
            this.panelHistory.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRevenue)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.panel1.Controls.Add(this.txtName);
            this.panel1.Controls.Add(this.btnLogout);
            this.panel1.Controls.Add(this.btnHistory);
            this.panel1.Controls.Add(this.btnOrder);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(237, 600);
            this.panel1.TabIndex = 1;
            // 
            // txtName
            // 
            this.txtName.AutoSize = true;
            this.txtName.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Bold);
            this.txtName.ForeColor = System.Drawing.Color.White;
            this.txtName.Location = new System.Drawing.Point(22, 57);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(99, 34);
            this.txtName.TabIndex = 4;
            this.txtName.Text = "label1";
            this.txtName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnLogout
            // 
            this.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogout.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.btnLogout.ForeColor = System.Drawing.Color.White;
            this.btnLogout.Location = new System.Drawing.Point(0, 376);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(237, 41);
            this.btnLogout.TabIndex = 2;
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // btnHistory
            // 
            this.btnHistory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHistory.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.btnHistory.ForeColor = System.Drawing.Color.White;
            this.btnHistory.Location = new System.Drawing.Point(0, 293);
            this.btnHistory.Name = "btnHistory";
            this.btnHistory.Size = new System.Drawing.Size(237, 41);
            this.btnHistory.TabIndex = 1;
            this.btnHistory.Text = "History";
            this.btnHistory.UseVisualStyleBackColor = true;
            this.btnHistory.Click += new System.EventHandler(this.btnHistory_Click);
            // 
            // btnOrder
            // 
            this.btnOrder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOrder.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.btnOrder.ForeColor = System.Drawing.Color.White;
            this.btnOrder.Location = new System.Drawing.Point(0, 204);
            this.btnOrder.Name = "btnOrder";
            this.btnOrder.Size = new System.Drawing.Size(237, 41);
            this.btnOrder.TabIndex = 0;
            this.btnOrder.Text = "Place order";
            this.btnOrder.UseVisualStyleBackColor = true;
            this.btnOrder.Click += new System.EventHandler(this.btnOrder_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(8)))), ((int)(((byte)(55)))));
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(237, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(963, 26);
            this.panel2.TabIndex = 2;
            // 
            // panelPlaceOrder
            // 
            this.panelPlaceOrder.Controls.Add(this.panel4);
            this.panelPlaceOrder.Controls.Add(this.panel3);
            this.panelPlaceOrder.Controls.Add(this.btnFoodFind);
            this.panelPlaceOrder.Controls.Add(this.tbFoodFindByName);
            this.panelPlaceOrder.Controls.Add(this.label9);
            this.panelPlaceOrder.Controls.Add(this.dgvFood);
            this.panelPlaceOrder.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelPlaceOrder.Location = new System.Drawing.Point(237, 26);
            this.panelPlaceOrder.Name = "panelPlaceOrder";
            this.panelPlaceOrder.Size = new System.Drawing.Size(963, 574);
            this.panelPlaceOrder.TabIndex = 3;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.tbTotal);
            this.panel4.Controls.Add(this.label4);
            this.panel4.Controls.Add(this.button2);
            this.panel4.Controls.Add(this.btnCreateOrder);
            this.panel4.Controls.Add(this.dgvOrder);
            this.panel4.Controls.Add(this.tbDetailCustomPN);
            this.panel4.Controls.Add(this.label1);
            this.panel4.Controls.Add(this.tbDetailCustomerName);
            this.panel4.Controls.Add(this.label12);
            this.panel4.Controls.Add(this.label13);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel4.Location = new System.Drawing.Point(648, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(315, 574);
            this.panel4.TabIndex = 11;
            // 
            // tbTotal
            // 
            this.tbTotal.Font = new System.Drawing.Font("Century Gothic", 10.2F);
            this.tbTotal.Location = new System.Drawing.Point(146, 444);
            this.tbTotal.Name = "tbTotal";
            this.tbTotal.ReadOnly = true;
            this.tbTotal.Size = new System.Drawing.Size(157, 28);
            this.tbTotal.TabIndex = 19;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(3, 447);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 21);
            this.label4.TabIndex = 18;
            this.label4.Text = "Total:";
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.button2.Location = new System.Drawing.Point(159, 509);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(144, 32);
            this.button2.TabIndex = 16;
            this.button2.Text = "Delete item";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnCreateOrder
            // 
            this.btnCreateOrder.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.btnCreateOrder.Location = new System.Drawing.Point(7, 506);
            this.btnCreateOrder.Name = "btnCreateOrder";
            this.btnCreateOrder.Size = new System.Drawing.Size(107, 35);
            this.btnCreateOrder.TabIndex = 12;
            this.btnCreateOrder.Text = "Create";
            this.btnCreateOrder.UseVisualStyleBackColor = true;
            this.btnCreateOrder.Click += new System.EventHandler(this.btnCreateOrder_Click);
            // 
            // dgvOrder
            // 
            this.dgvOrder.AllowUserToAddRows = false;
            this.dgvOrder.AllowUserToDeleteRows = false;
            this.dgvOrder.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOrder.Location = new System.Drawing.Point(3, 201);
            this.dgvOrder.MultiSelect = false;
            this.dgvOrder.Name = "dgvOrder";
            this.dgvOrder.RowHeadersWidth = 51;
            this.dgvOrder.RowTemplate.Height = 24;
            this.dgvOrder.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvOrder.Size = new System.Drawing.Size(309, 225);
            this.dgvOrder.TabIndex = 15;
            // 
            // tbDetailCustomPN
            // 
            this.tbDetailCustomPN.Font = new System.Drawing.Font("Century Gothic", 10.2F);
            this.tbDetailCustomPN.Location = new System.Drawing.Point(10, 167);
            this.tbDetailCustomPN.Name = "tbDetailCustomPN";
            this.tbDetailCustomPN.Size = new System.Drawing.Size(208, 28);
            this.tbDetailCustomPN.TabIndex = 14;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(14, 139);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(222, 21);
            this.label1.TabIndex = 13;
            this.label1.Text = "Customer phone number:";
            // 
            // tbDetailCustomerName
            // 
            this.tbDetailCustomerName.Font = new System.Drawing.Font("Century Gothic", 10.2F);
            this.tbDetailCustomerName.Location = new System.Drawing.Point(10, 93);
            this.tbDetailCustomerName.Name = "tbDetailCustomerName";
            this.tbDetailCustomerName.Size = new System.Drawing.Size(208, 28);
            this.tbDetailCustomerName.TabIndex = 12;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(14, 65);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(148, 21);
            this.label12.TabIndex = 11;
            this.label12.Text = "Customer name:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(14, 22);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(123, 23);
            this.label13.TabIndex = 10;
            this.label13.Text = "Detail order";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.tbFoodId);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.btnAddOrderItem);
            this.panel3.Controls.Add(this.tbOrders);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.tbFoodQuantity);
            this.panel3.Controls.Add(this.tbFoodPrice);
            this.panel3.Controls.Add(this.tbFoodName);
            this.panel3.Controls.Add(this.label8);
            this.panel3.Controls.Add(this.label7);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(211, 574);
            this.panel3.TabIndex = 10;
            // 
            // tbFoodId
            // 
            this.tbFoodId.Font = new System.Drawing.Font("Century Gothic", 10.2F);
            this.tbFoodId.Location = new System.Drawing.Point(3, 117);
            this.tbFoodId.Name = "tbFoodId";
            this.tbFoodId.ReadOnly = true;
            this.tbFoodId.Size = new System.Drawing.Size(208, 28);
            this.tbFoodId.TabIndex = 28;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(3, 93);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(32, 21);
            this.label5.TabIndex = 27;
            this.label5.Text = "Id:";
            // 
            // btnAddOrderItem
            // 
            this.btnAddOrderItem.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.btnAddOrderItem.Location = new System.Drawing.Point(25, 447);
            this.btnAddOrderItem.Name = "btnAddOrderItem";
            this.btnAddOrderItem.Size = new System.Drawing.Size(151, 37);
            this.btnAddOrderItem.TabIndex = 18;
            this.btnAddOrderItem.Text = "Add order";
            this.btnAddOrderItem.UseVisualStyleBackColor = true;
            this.btnAddOrderItem.Click += new System.EventHandler(this.btnAddOrderItem_Click);
            // 
            // tbOrders
            // 
            this.tbOrders.Font = new System.Drawing.Font("Century Gothic", 10.2F);
            this.tbOrders.Location = new System.Drawing.Point(4, 409);
            this.tbOrders.Name = "tbOrders";
            this.tbOrders.Size = new System.Drawing.Size(197, 28);
            this.tbOrders.TabIndex = 26;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(6, 380);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(151, 21);
            this.label3.TabIndex = 25;
            this.label3.Text = "Number of order:";
            // 
            // tbFoodQuantity
            // 
            this.tbFoodQuantity.Font = new System.Drawing.Font("Century Gothic", 10.2F);
            this.tbFoodQuantity.Location = new System.Drawing.Point(3, 324);
            this.tbFoodQuantity.Name = "tbFoodQuantity";
            this.tbFoodQuantity.ReadOnly = true;
            this.tbFoodQuantity.Size = new System.Drawing.Size(197, 28);
            this.tbFoodQuantity.TabIndex = 24;
            // 
            // tbFoodPrice
            // 
            this.tbFoodPrice.Font = new System.Drawing.Font("Century Gothic", 10.2F);
            this.tbFoodPrice.Location = new System.Drawing.Point(3, 251);
            this.tbFoodPrice.Name = "tbFoodPrice";
            this.tbFoodPrice.ReadOnly = true;
            this.tbFoodPrice.Size = new System.Drawing.Size(197, 28);
            this.tbFoodPrice.TabIndex = 22;
            // 
            // tbFoodName
            // 
            this.tbFoodName.Font = new System.Drawing.Font("Century Gothic", 10.2F);
            this.tbFoodName.Location = new System.Drawing.Point(3, 181);
            this.tbFoodName.Name = "tbFoodName";
            this.tbFoodName.ReadOnly = true;
            this.tbFoodName.Size = new System.Drawing.Size(197, 28);
            this.tbFoodName.TabIndex = 20;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(5, 295);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(87, 21);
            this.label8.TabIndex = 23;
            this.label8.Text = "Quantity:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(3, 228);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(55, 21);
            this.label7.TabIndex = 21;
            this.label7.Text = "Price:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(3, 157);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(66, 21);
            this.label6.TabIndex = 19;
            this.label6.Text = "Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 23);
            this.label2.TabIndex = 18;
            this.label2.Text = "Food info";
            // 
            // btnFoodFind
            // 
            this.btnFoodFind.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.btnFoodFind.Location = new System.Drawing.Point(520, 22);
            this.btnFoodFind.Name = "btnFoodFind";
            this.btnFoodFind.Size = new System.Drawing.Size(107, 35);
            this.btnFoodFind.TabIndex = 8;
            this.btnFoodFind.Text = "Find";
            this.btnFoodFind.UseVisualStyleBackColor = true;
            this.btnFoodFind.Click += new System.EventHandler(this.btnFoodFind_Click);
            // 
            // tbFoodFindByName
            // 
            this.tbFoodFindByName.Font = new System.Drawing.Font("Century Gothic", 10.2F);
            this.tbFoodFindByName.Location = new System.Drawing.Point(321, 27);
            this.tbFoodFindByName.Name = "tbFoodFindByName";
            this.tbFoodFindByName.Size = new System.Drawing.Size(161, 28);
            this.tbFoodFindByName.TabIndex = 7;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(232, 31);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(66, 21);
            this.label9.TabIndex = 9;
            this.label9.Text = "Name:";
            // 
            // dgvFood
            // 
            this.dgvFood.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFood.Location = new System.Drawing.Point(236, 65);
            this.dgvFood.Name = "dgvFood";
            this.dgvFood.RowHeadersWidth = 51;
            this.dgvFood.RowTemplate.Height = 24;
            this.dgvFood.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvFood.Size = new System.Drawing.Size(391, 476);
            this.dgvFood.TabIndex = 6;
            this.dgvFood.SelectionChanged += new System.EventHandler(this.dgvFood_SelectionChanged);
            // 
            // panelHistory
            // 
            this.panelHistory.Controls.Add(this.tbOrderQuantity);
            this.panelHistory.Controls.Add(this.label21);
            this.panelHistory.Controls.Add(this.tbTotalRevenue);
            this.panelHistory.Controls.Add(this.label20);
            this.panelHistory.Controls.Add(this.btnDetailOrder);
            this.panelHistory.Controls.Add(this.btnFindRevenue);
            this.panelHistory.Controls.Add(this.btnUpdateOrder);
            this.panelHistory.Controls.Add(this.cmbStatus);
            this.panelHistory.Controls.Add(this.label19);
            this.panelHistory.Controls.Add(this.tbOrderId);
            this.panelHistory.Controls.Add(this.label18);
            this.panelHistory.Controls.Add(this.textBox1);
            this.panelHistory.Controls.Add(this.label16);
            this.panelHistory.Controls.Add(this.textBox2);
            this.panelHistory.Controls.Add(this.label17);
            this.panelHistory.Controls.Add(this.dgvRevenue);
            this.panelHistory.Controls.Add(this.label15);
            this.panelHistory.Controls.Add(this.label14);
            this.panelHistory.Controls.Add(this.dtpEnd);
            this.panelHistory.Controls.Add(this.dtpStart);
            this.panelHistory.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelHistory.Location = new System.Drawing.Point(237, 26);
            this.panelHistory.Name = "panelHistory";
            this.panelHistory.Size = new System.Drawing.Size(963, 574);
            this.panelHistory.TabIndex = 0;
            // 
            // tbOrderQuantity
            // 
            this.tbOrderQuantity.Font = new System.Drawing.Font("Century Gothic", 10.2F);
            this.tbOrderQuantity.Location = new System.Drawing.Point(544, 503);
            this.tbOrderQuantity.Name = "tbOrderQuantity";
            this.tbOrderQuantity.ReadOnly = true;
            this.tbOrderQuantity.Size = new System.Drawing.Size(208, 28);
            this.tbOrderQuantity.TabIndex = 57;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.Location = new System.Drawing.Point(409, 506);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(80, 21);
            this.label21.TabIndex = 56;
            this.label21.Text = "Quantiy:";
            // 
            // tbTotalRevenue
            // 
            this.tbTotalRevenue.Font = new System.Drawing.Font("Century Gothic", 10.2F);
            this.tbTotalRevenue.Location = new System.Drawing.Point(160, 503);
            this.tbTotalRevenue.Name = "tbTotalRevenue";
            this.tbTotalRevenue.ReadOnly = true;
            this.tbTotalRevenue.Size = new System.Drawing.Size(208, 28);
            this.tbTotalRevenue.TabIndex = 55;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.Location = new System.Drawing.Point(25, 506);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(51, 21);
            this.label20.TabIndex = 54;
            this.label20.Text = "Earn:";
            // 
            // btnDetailOrder
            // 
            this.btnDetailOrder.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.btnDetailOrder.Location = new System.Drawing.Point(853, 428);
            this.btnDetailOrder.Name = "btnDetailOrder";
            this.btnDetailOrder.Size = new System.Drawing.Size(98, 35);
            this.btnDetailOrder.TabIndex = 52;
            this.btnDetailOrder.Text = "Detail";
            this.btnDetailOrder.UseVisualStyleBackColor = true;
            this.btnDetailOrder.Click += new System.EventHandler(this.btnDetailOrder_Click);
            // 
            // btnFindRevenue
            // 
            this.btnFindRevenue.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.btnFindRevenue.Location = new System.Drawing.Point(794, 20);
            this.btnFindRevenue.Name = "btnFindRevenue";
            this.btnFindRevenue.Size = new System.Drawing.Size(107, 35);
            this.btnFindRevenue.TabIndex = 51;
            this.btnFindRevenue.Text = "Find";
            this.btnFindRevenue.UseVisualStyleBackColor = true;
            this.btnFindRevenue.Click += new System.EventHandler(this.btnFindRevenue_Click);
            // 
            // btnUpdateOrder
            // 
            this.btnUpdateOrder.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.btnUpdateOrder.Location = new System.Drawing.Point(710, 428);
            this.btnUpdateOrder.Name = "btnUpdateOrder";
            this.btnUpdateOrder.Size = new System.Drawing.Size(98, 35);
            this.btnUpdateOrder.TabIndex = 50;
            this.btnUpdateOrder.Text = "Update";
            this.btnUpdateOrder.UseVisualStyleBackColor = true;
            this.btnUpdateOrder.Click += new System.EventHandler(this.btnUpdateOrder_Click);
            // 
            // cmbStatus
            // 
            this.cmbStatus.Font = new System.Drawing.Font("Century Gothic", 10.2F);
            this.cmbStatus.FormattingEnabled = true;
            this.cmbStatus.Items.AddRange(new object[] {
            "CANCEL",
            "PENDING",
            "PAID"});
            this.cmbStatus.Location = new System.Drawing.Point(719, 357);
            this.cmbStatus.Name = "cmbStatus";
            this.cmbStatus.Size = new System.Drawing.Size(199, 29);
            this.cmbStatus.TabIndex = 49;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(715, 321);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(61, 21);
            this.label19.TabIndex = 48;
            this.label19.Text = "Status";
            // 
            // tbOrderId
            // 
            this.tbOrderId.Font = new System.Drawing.Font("Century Gothic", 10.2F);
            this.tbOrderId.Location = new System.Drawing.Point(710, 147);
            this.tbOrderId.Name = "tbOrderId";
            this.tbOrderId.ReadOnly = true;
            this.tbOrderId.Size = new System.Drawing.Size(208, 28);
            this.tbOrderId.TabIndex = 47;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(714, 119);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(83, 21);
            this.label18.TabIndex = 46;
            this.label18.Text = "Order id:";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Century Gothic", 10.2F);
            this.textBox1.Location = new System.Drawing.Point(710, 282);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(208, 28);
            this.textBox1.TabIndex = 45;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(714, 254);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(222, 21);
            this.label16.TabIndex = 44;
            this.label16.Text = "Customer phone number:";
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Century Gothic", 10.2F);
            this.textBox2.Location = new System.Drawing.Point(710, 208);
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(208, 28);
            this.textBox2.TabIndex = 43;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(714, 180);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(148, 21);
            this.label17.TabIndex = 42;
            this.label17.Text = "Customer name:";
            // 
            // dgvRevenue
            // 
            this.dgvRevenue.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRevenue.Location = new System.Drawing.Point(29, 65);
            this.dgvRevenue.MultiSelect = false;
            this.dgvRevenue.Name = "dgvRevenue";
            this.dgvRevenue.RowHeadersWidth = 51;
            this.dgvRevenue.RowTemplate.Height = 24;
            this.dgvRevenue.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvRevenue.Size = new System.Drawing.Size(674, 409);
            this.dgvRevenue.TabIndex = 41;
            this.dgvRevenue.SelectionChanged += new System.EventHandler(this.dgvRevenue_SelectionChanged);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(368, 19);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(46, 21);
            this.label15.TabIndex = 40;
            this.label15.Text = "End:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(25, 19);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(54, 21);
            this.label14.TabIndex = 39;
            this.label14.Text = "Start:";
            // 
            // dtpEnd
            // 
            this.dtpEnd.Location = new System.Drawing.Point(458, 18);
            this.dtpEnd.Name = "dtpEnd";
            this.dtpEnd.Size = new System.Drawing.Size(249, 28);
            this.dtpEnd.TabIndex = 38;
            // 
            // dtpStart
            // 
            this.dtpStart.Location = new System.Drawing.Point(113, 18);
            this.dtpStart.Name = "dtpStart";
            this.dtpStart.Size = new System.Drawing.Size(249, 28);
            this.dtpStart.TabIndex = 37;
            // 
            // StaffForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1200, 600);
            this.Controls.Add(this.panelPlaceOrder);
            this.Controls.Add(this.panelHistory);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Century Gothic", 10.2F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "StaffForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "StaffForm";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panelPlaceOrder.ResumeLayout(false);
            this.panelPlaceOrder.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrder)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFood)).EndInit();
            this.panelHistory.ResumeLayout(false);
            this.panelHistory.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRevenue)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label txtName;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Button btnHistory;
        private System.Windows.Forms.Button btnOrder;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panelPlaceOrder;
        private System.Windows.Forms.Panel panelHistory;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnFoodFind;
        private System.Windows.Forms.TextBox tbFoodFindByName;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DataGridView dgvFood;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox tbDetailCustomerName;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnCreateOrder;
        private System.Windows.Forms.DataGridView dgvOrder;
        private System.Windows.Forms.TextBox tbDetailCustomPN;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbOrders;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbFoodQuantity;
        private System.Windows.Forms.TextBox tbFoodPrice;
        private System.Windows.Forms.TextBox tbFoodName;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbTotal;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnAddOrderItem;
        private System.Windows.Forms.TextBox tbFoodId;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnUpdateOrder;
        private System.Windows.Forms.ComboBox cmbStatus;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.TextBox tbOrderId;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.DataGridView dgvRevenue;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.DateTimePicker dtpEnd;
        private System.Windows.Forms.DateTimePicker dtpStart;
        private System.Windows.Forms.Button btnFindRevenue;
        private System.Windows.Forms.Button btnDetailOrder;
        private System.Windows.Forms.TextBox tbOrderQuantity;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.TextBox tbTotalRevenue;
        private System.Windows.Forms.Label label20;
    }
}