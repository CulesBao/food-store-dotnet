namespace FoodStore.GUI
{
    partial class DetailOrder
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
            this.label2 = new System.Windows.Forms.Label();
            this.lbName = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lbPhoneNumber = new System.Windows.Forms.Label();
            this.dgvOrderItem = new System.Windows.Forms.DataGridView();
            this.tbOrderQuantity = new System.Windows.Forms.TextBox();
            this.label21 = new System.Windows.Forms.Label();
            this.tbTotalRevenue = new System.Windows.Forms.TextBox();
            this.label20 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrderItem)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(214, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(202, 34);
            this.label2.TabIndex = 1;
            this.label2.Text = "DETAIL ORDER";
            // 
            // lbName
            // 
            this.lbName.AutoSize = true;
            this.lbName.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbName.Location = new System.Drawing.Point(321, 89);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(177, 23);
            this.lbName.TabIndex = 2;
            this.lbName.Text = "Detail Infomation";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(34, 89);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(148, 21);
            this.label5.TabIndex = 3;
            this.label5.Text = "Customer name:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(34, 146);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(222, 21);
            this.label3.TabIndex = 4;
            this.label3.Text = "Customer phone number:";
            // 
            // lbPhoneNumber
            // 
            this.lbPhoneNumber.AutoSize = true;
            this.lbPhoneNumber.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPhoneNumber.Location = new System.Drawing.Point(321, 144);
            this.lbPhoneNumber.Name = "lbPhoneNumber";
            this.lbPhoneNumber.Size = new System.Drawing.Size(177, 23);
            this.lbPhoneNumber.TabIndex = 5;
            this.lbPhoneNumber.Text = "Detail Infomation";
            // 
            // dgvOrderItem
            // 
            this.dgvOrderItem.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOrderItem.Location = new System.Drawing.Point(38, 185);
            this.dgvOrderItem.Name = "dgvOrderItem";
            this.dgvOrderItem.RowHeadersWidth = 51;
            this.dgvOrderItem.RowTemplate.Height = 24;
            this.dgvOrderItem.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvOrderItem.Size = new System.Drawing.Size(588, 270);
            this.dgvOrderItem.TabIndex = 6;
            // 
            // tbOrderQuantity
            // 
            this.tbOrderQuantity.Font = new System.Drawing.Font("Century Gothic", 10.2F);
            this.tbOrderQuantity.Location = new System.Drawing.Point(472, 470);
            this.tbOrderQuantity.Name = "tbOrderQuantity";
            this.tbOrderQuantity.ReadOnly = true;
            this.tbOrderQuantity.Size = new System.Drawing.Size(154, 28);
            this.tbOrderQuantity.TabIndex = 46;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.Location = new System.Drawing.Point(352, 473);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(80, 21);
            this.label21.TabIndex = 45;
            this.label21.Text = "Quantiy:";
            // 
            // tbTotalRevenue
            // 
            this.tbTotalRevenue.Font = new System.Drawing.Font("Century Gothic", 10.2F);
            this.tbTotalRevenue.Location = new System.Drawing.Point(118, 470);
            this.tbTotalRevenue.Name = "tbTotalRevenue";
            this.tbTotalRevenue.ReadOnly = true;
            this.tbTotalRevenue.Size = new System.Drawing.Size(123, 28);
            this.tbTotalRevenue.TabIndex = 44;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.Location = new System.Drawing.Point(11, 473);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(56, 21);
            this.label20.TabIndex = 43;
            this.label20.Text = "Total:";
            // 
            // DetailOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(663, 520);
            this.Controls.Add(this.tbOrderQuantity);
            this.Controls.Add(this.label21);
            this.Controls.Add(this.tbTotalRevenue);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.dgvOrderItem);
            this.Controls.Add(this.lbPhoneNumber);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lbName);
            this.Controls.Add(this.label2);
            this.Name = "DetailOrder";
            this.Text = "DetailOrder";
            this.Load += new System.EventHandler(this.DetailOrder_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrderItem)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbPhoneNumber;
        private System.Windows.Forms.DataGridView dgvOrderItem;
        private System.Windows.Forms.TextBox tbOrderQuantity;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.TextBox tbTotalRevenue;
        private System.Windows.Forms.Label label20;
    }
}