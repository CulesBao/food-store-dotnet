using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FoodStore.BLL;
using FoodStore.Config;
using FoodStore.DTO;

namespace FoodStore.GUI
{
    public partial class StaffForm : Form
    {
        private static readonly FoodBLL foodBLL = new FoodBLL();
        private List<OrderItemDTO> orderItemDTOs = new List<OrderItemDTO>();
        private static readonly OrderBLL orderBLL = new OrderBLL();
        private int TotalPrice()
        {
            int total = 0;
            foreach (var item in orderItemDTOs)
            {
                total += item.TotalPrice;
            }
            return total;
        }
        public StaffForm()
        {
            InitializeComponent();
            txtName.Text = "Hi, " + Session.UserName;
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            Session.ClearSession();
            this.Hide();
            var loginForm = new LoginForm();
            loginForm.FormClosed += (s, args) => Application.Exit();
            loginForm.Show();
        }

        private void btnFoodFind_Click(object sender, EventArgs e)
        {
            string txtName = tbFoodFindByName.Text;
            ResponseDTO responseDTO = foodBLL.GetFoodsByName(txtName);
            if (responseDTO.success)
            {
                List<FilterFoodDTO> foods = (List<FilterFoodDTO>)responseDTO.data;
                dgvFood.DataSource = foods;
            }
            else
            {
                MessageBox.Show(responseDTO.message);
            }
        }

        private void dgvFood_SelectionChanged(object sender, EventArgs e)
        {
            int rowIndex = dgvFood.CurrentCell.RowIndex;
            if (rowIndex >= 0)
            {
                DataGridViewRow selectedRow = dgvFood.Rows[rowIndex];
                tbFoodId.Text = selectedRow.Cells[0].Value.ToString();
                tbFoodName.Text = selectedRow.Cells[1].Value.ToString();
                tbFoodPrice.Text = selectedRow.Cells[2].Value.ToString();
                tbFoodQuantity.Text = selectedRow.Cells[3].Value.ToString();
            }
        }

        private void btnAddOrderItem_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tbFoodId.Text))
            {
                MessageBox.Show("Please select food item");
                return;
            }
            if (string.IsNullOrEmpty(tbOrders.Text))
            {
                MessageBox.Show("Please enter quantity");
                return;
            }
            if (Convert.ToInt32(tbOrders.Text) <= 0)
            {
                MessageBox.Show("Quantity order must be greater than 0");
                return;
            }
            if (Convert.ToInt32(tbOrders.Text) > Convert.ToInt32(tbFoodQuantity.Text))
            {
                var result = MessageBox.Show("Quantity order is greater than food quantity, do you want to continue?", "Warning", MessageBoxButtons.YesNo);
                if (result == DialogResult.No)
                {
                    return;
                }
            }
            orderItemDTOs.Add(new OrderItemDTO()
            {
                ID = Convert.ToInt32(tbFoodId.Text),
                Name = tbFoodName.Text,
                Price = Convert.ToInt32(tbFoodPrice.Text),
                Quantity = Convert.ToInt32(tbOrders.Text)
            });
            dgvOrder.DataSource = null;
            dgvOrder.DataSource = orderItemDTOs;
            tbTotal.Text = TotalPrice().ToString();
            tbOrders.Text = ""; 
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int Index = dgvOrder.CurrentCell.RowIndex;
            if (Index >= 0)
            {
                orderItemDTOs.RemoveAt(Index);
                dgvOrder.DataSource = null;
                dgvOrder.DataSource = orderItemDTOs;
                tbTotal.Text = TotalPrice().ToString();
            }
            else
            {
                MessageBox.Show("Please select food item");
            }
        }

        private void btnCreateOrder_Click(object sender, EventArgs e)
        {
            string phoneNumber = tbDetailCustomPN.Text;
            string CustomerName = tbDetailCustomerName.Text;
            ResponseDTO responseDTO = orderBLL.AddNewOrder(CustomerName, phoneNumber, orderItemDTOs);
            if (responseDTO.success)
            {
                MessageBox.Show("Order created successfully");
                orderItemDTOs.Clear();
                dgvOrder.DataSource = null;
                tbTotal.Text = "0";
                tbDetailCustomPN.Text = "";
                tbDetailCustomerName.Text = "";
            }
            else
            {
                MessageBox.Show(responseDTO.message);
            }
        }

        private void btnFindRevenue_Click(object sender, EventArgs e)
        {
            DateTime StartDate = dtpStart.Value.Date;
            DateTime EndDate = dtpEnd.Value.Date.AddDays(1);
            ResponseDTO responseDTO = orderBLL.GetOrderByDateTime(Session.UserId, StartDate, EndDate);
            if (!responseDTO.success)
            {
                MessageBox.Show(responseDTO.message);
            }
            else
            {
                List<FilterOrderDTO> orders = (List<FilterOrderDTO>)responseDTO.data;
                dgvRevenue.DataSource = null;
                dgvRevenue.DataSource = orders;
                tbOrderQuantity.Text = orders.Count.ToString();
                tbTotalRevenue.Text = orders.Sum(o => o.TotalPrice).ToString();
            }
        }

        private void btnUpdateOrder_Click(object sender, EventArgs e)
        {
            string Status = cmbStatus.Text;
            int OrderId = Convert.ToInt32(tbOrderId.Text);
            ResponseDTO responseDTO = orderBLL.UpdateOrderStatus(OrderId, Status);
            if (!responseDTO.success)
            {
                MessageBox.Show(responseDTO.message);
            }
            else
            {
                MessageBox.Show("Update order status successfully");
                tbOrderId.Text = string.Empty;
                tbDetailCustomerName.Text = string.Empty;
                tbDetailCustomPN.Text = string.Empty;
                cmbStatus.Text = string.Empty;
                btnFindRevenue_Click(sender, e);
            }
        }

        private void btnDetailOrder_Click(object sender, EventArgs e)
        {
            int index = dgvRevenue.CurrentCell.RowIndex;
            if (index >= 0)
            {
                int orderId = Convert.ToInt32(dgvRevenue.Rows[index].Cells[0].Value);
                string Name = dgvRevenue.Rows[index].Cells[2].Value.ToString();
                string PhoneNumber = dgvRevenue.Rows[index].Cells[3].Value.ToString();
                new DetailOrder(orderId, Name, PhoneNumber).Show();
            }
            else
            {
                MessageBox.Show("Please select a row to view detail");
            }
        }
        private void dgvRevenue_SelectionChanged(object sender, EventArgs e)
        {
            int index = dgvRevenue.CurrentCell.RowIndex;
            if (index >= 0)
            {
                DataGridViewRow selectedRow = dgvRevenue.Rows[index];
                tbOrderId.Text = selectedRow.Cells[0].Value.ToString();
                textBox2.Text = selectedRow.Cells[2].Value.ToString();
                textBox1.Text = selectedRow.Cells[3].Value.ToString();
                cmbStatus.Text = selectedRow.Cells[4].Value.ToString();
            }
        }

        private void btnOrder_Click(object sender, EventArgs e)
        {
            panelPlaceOrder.BringToFront();
        }

        private void btnHistory_Click(object sender, EventArgs e)
        {
            panelHistory.BringToFront();
        }
    }
}
