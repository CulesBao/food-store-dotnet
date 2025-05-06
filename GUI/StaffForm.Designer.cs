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
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnFoodFind = new System.Windows.Forms.Button();
            this.tbFoodFindByName = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.dgvFood = new System.Windows.Forms.DataGridView();
            this.panelHistory = new System.Windows.Forms.Panel();
            this.label13 = new System.Windows.Forms.Label();
            this.tbDetailCustomerName = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.tbDetailCustomPN = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvOrder = new System.Windows.Forms.DataGridView();
            this.btnCreateOrder = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.btnPrintBill = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.tbFoodQuantity = new System.Windows.Forms.TextBox();
            this.tbFoodPrice = new System.Windows.Forms.TextBox();
            this.tbFoodName = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tbOrders = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnAddOrderItem = new System.Windows.Forms.Button();
            this.tbTotal = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panelPlaceOrder.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFood)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrder)).BeginInit();
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
            this.panel4.Controls.Add(this.btnPrintBill);
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
            // panel3
            // 
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
            // btnFoodFind
            // 
            this.btnFoodFind.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.btnFoodFind.Location = new System.Drawing.Point(520, 22);
            this.btnFoodFind.Name = "btnFoodFind";
            this.btnFoodFind.Size = new System.Drawing.Size(107, 35);
            this.btnFoodFind.TabIndex = 8;
            this.btnFoodFind.Text = "Find";
            this.btnFoodFind.UseVisualStyleBackColor = true;
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
            // 
            // panelHistory
            // 
            this.panelHistory.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelHistory.Location = new System.Drawing.Point(237, 26);
            this.panelHistory.Name = "panelHistory";
            this.panelHistory.Size = new System.Drawing.Size(963, 574);
            this.panelHistory.TabIndex = 0;
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
            // dgvOrder
            // 
            this.dgvOrder.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOrder.Location = new System.Drawing.Point(3, 201);
            this.dgvOrder.Name = "dgvOrder";
            this.dgvOrder.RowHeadersWidth = 51;
            this.dgvOrder.RowTemplate.Height = 24;
            this.dgvOrder.Size = new System.Drawing.Size(309, 225);
            this.dgvOrder.TabIndex = 15;
            // 
            // btnCreateOrder
            // 
            this.btnCreateOrder.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.btnCreateOrder.Location = new System.Drawing.Point(3, 506);
            this.btnCreateOrder.Name = "btnCreateOrder";
            this.btnCreateOrder.Size = new System.Drawing.Size(107, 35);
            this.btnCreateOrder.TabIndex = 12;
            this.btnCreateOrder.Text = "Create";
            this.btnCreateOrder.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.button2.Location = new System.Drawing.Point(208, 506);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(107, 35);
            this.button2.TabIndex = 16;
            this.button2.Text = "Clear";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // btnPrintBill
            // 
            this.btnPrintBill.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.btnPrintBill.Location = new System.Drawing.Point(111, 506);
            this.btnPrintBill.Name = "btnPrintBill";
            this.btnPrintBill.Size = new System.Drawing.Size(107, 35);
            this.btnPrintBill.TabIndex = 17;
            this.btnPrintBill.Text = "Print";
            this.btnPrintBill.UseVisualStyleBackColor = true;
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
            // tbFoodQuantity
            // 
            this.tbFoodQuantity.Font = new System.Drawing.Font("Century Gothic", 10.2F);
            this.tbFoodQuantity.Location = new System.Drawing.Point(3, 260);
            this.tbFoodQuantity.Name = "tbFoodQuantity";
            this.tbFoodQuantity.ReadOnly = true;
            this.tbFoodQuantity.Size = new System.Drawing.Size(197, 28);
            this.tbFoodQuantity.TabIndex = 24;
            // 
            // tbFoodPrice
            // 
            this.tbFoodPrice.Font = new System.Drawing.Font("Century Gothic", 10.2F);
            this.tbFoodPrice.Location = new System.Drawing.Point(3, 187);
            this.tbFoodPrice.Name = "tbFoodPrice";
            this.tbFoodPrice.ReadOnly = true;
            this.tbFoodPrice.Size = new System.Drawing.Size(197, 28);
            this.tbFoodPrice.TabIndex = 22;
            // 
            // tbFoodName
            // 
            this.tbFoodName.Font = new System.Drawing.Font("Century Gothic", 10.2F);
            this.tbFoodName.Location = new System.Drawing.Point(3, 117);
            this.tbFoodName.Name = "tbFoodName";
            this.tbFoodName.ReadOnly = true;
            this.tbFoodName.Size = new System.Drawing.Size(197, 28);
            this.tbFoodName.TabIndex = 20;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(5, 231);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(87, 21);
            this.label8.TabIndex = 23;
            this.label8.Text = "Quantity:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(3, 164);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(55, 21);
            this.label7.TabIndex = 21;
            this.label7.Text = "Price:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(3, 93);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(66, 21);
            this.label6.TabIndex = 19;
            this.label6.Text = "Name:";
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
            // btnAddOrderItem
            // 
            this.btnAddOrderItem.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.btnAddOrderItem.Location = new System.Drawing.Point(25, 447);
            this.btnAddOrderItem.Name = "btnAddOrderItem";
            this.btnAddOrderItem.Size = new System.Drawing.Size(151, 37);
            this.btnAddOrderItem.TabIndex = 18;
            this.btnAddOrderItem.Text = "Add order";
            this.btnAddOrderItem.UseVisualStyleBackColor = true;
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
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFood)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrder)).EndInit();
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
        private System.Windows.Forms.Button btnPrintBill;
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
    }
}