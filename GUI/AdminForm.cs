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
    public partial class AdminForm : Form
    {
        private static readonly AccountBLL accountBLL = new AccountBLL();
        private static readonly FoodBLL foodBLL = new FoodBLL();
        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            label1.Text = "Hi, " + Session.UserName;
        }
        public AdminForm()
        {
            InitializeComponent();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            Session.ClearSession();
            this.Hide();
            var loginForm = new LoginForm();
            loginForm.FormClosed += (s, args) => Application.Exit();
            loginForm.Show();
        }

        private void btnStaff_Click(object sender, EventArgs e)
        {
            panelManageStaff.BringToFront();
        }

        private void btnFood_Click(object sender, EventArgs e)
        {
            panelManageFood.BringToFront();
        }

        private void btnRevenue_Click(object sender, EventArgs e)
        {
            panelRevenue.BringToFront();
        }

        private void btnFilter_Click(object sender, EventArgs e)
        {
            string txtName = tbName.Text;
            string txtPhoneNumber = tbPhoneNumber.Text;

            ResponseDTO responseDTO = accountBLL.GetAccountByNameAndPhoneNumber(txtName, txtPhoneNumber);
            List<FilterAccountDTO> accounts = (List<FilterAccountDTO>)responseDTO.data;
            dgvStaff.DataSource = accounts;
        }

        private void btnAddNew_Click(object sender, EventArgs e)
        {
            new EditAccount(-1).Show();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (dgvStaff.SelectedRows.Count > 0)
            {
                int accountId = Convert.ToInt32(dgvStaff.SelectedRows[0].Cells[0].Value);
                new EditAccount(accountId).Show();
            }
            else
            {
                MessageBox.Show("Please select a row to edit");
            }
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

        private void btnAddFood_Click(object sender, EventArgs e)
        {
            string FoodName = tbAddFoodName.Text;
            int FoodPrice = Convert.ToInt32(tbAddFoodPrice.Text);
            int FoodQuantity = Convert.ToInt32(tbAddFoodQuantity.Text);
            ResponseDTO responseDTO = foodBLL.AddFood(new Food()
            {
                FoodName = FoodName,
                Price = FoodPrice,
                Quantity = FoodQuantity
            });
            if (!responseDTO.success)
            {
                MessageBox.Show(responseDTO.message);
            }
            else
            {
                MessageBox.Show("Add food successfully");
                tbAddFoodName.Text = string.Empty;
                tbAddFoodPrice.Text = string.Empty;
                tbAddFoodQuantity.Text = string.Empty;
                btnFoodFind_Click(sender, e);
            }
        }

        private void btnFoodUpdate_Click(object sender, EventArgs e)
        {
            int FoodId = Convert.ToInt32(tbFoodId.Text);
            string FoodName = tbFoodName.Text;
            int FoodPrice = Convert.ToInt32(tbFoodPrice.Text);
            int FoodQuantity = Convert.ToInt32(tbFoodQuantity.Text);

            ResponseDTO responseDTO = foodBLL.UpdateFood(new Food()
            {
                FoodId = FoodId,
                FoodName = FoodName,
                Price = FoodPrice,
                Quantity = FoodQuantity
            });
            if (!responseDTO.success)
            {
                MessageBox.Show(responseDTO.message);
            }
            else
            {
                MessageBox.Show("Update food successfully");
                tbFoodId.Text = string.Empty;
                tbFoodName.Text = string.Empty;
                tbFoodPrice.Text = string.Empty;
                tbFoodQuantity.Text = string.Empty;
                btnFoodFind_Click(sender, e);
            }
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
