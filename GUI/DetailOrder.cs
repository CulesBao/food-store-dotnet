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
using FoodStore.DTO;

namespace FoodStore.GUI
{
    public partial class DetailOrder : Form
    {
        private int OrderId;
        private OrderItemBLL orderItemBLL = new OrderItemBLL();
        public DetailOrder()
        {
            InitializeComponent();
        }
        public DetailOrder(int orderId, string Name, string PhoneNumber)
        {
            InitializeComponent();
            OrderId = orderId;
            ResponseDTO responseDTO = orderItemBLL.GetOrderItemByOrderId(orderId);
            if (responseDTO.success)
            {
                List<DetailOrderItem> orderItems = (List<DetailOrderItem>)responseDTO.data;
                dgvOrderItem.DataSource = orderItems;
                lbName.Text = Name;
                lbPhoneNumber.Text = PhoneNumber;
                tbTotalRevenue.Text = orderItems.Sum(x => x.TotalPrice).ToString();
                tbOrderQuantity.Text = orderItems.Sum(x => x.Quantity).ToString();
            }
            else
            {
                MessageBox.Show(responseDTO.message);
            }
        }

        private void DetailOrder_Load(object sender, EventArgs e)
        {

        }
    }
}
