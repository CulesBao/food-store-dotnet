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
    }
}
