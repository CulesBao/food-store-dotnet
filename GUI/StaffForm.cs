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
            ResponseDTO responseDTO = orderBLL.AddNewOrder(phoneNumber, CustomerName, orderItemDTOs);
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
    }
}
