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
    public partial class EditAccount : Form
    {
        private int accountId = -1;
        private static readonly AccountBLL accountBLL = new AccountBLL();
        public EditAccount()
        {
            InitializeComponent();
        }
        public EditAccount(int accountId)
        {
            InitializeComponent();
            this.accountId = accountId;
            if (this.accountId != -1)
            {
                tbUsername.Enabled = false;
                btnChangePassword.Visible = true;
                ResponseDTO responseDTO = accountBLL.GetAccountByAccountId(this.accountId);
                if (responseDTO.data == null)
                {
                    MessageBox.Show("Something went wrong, please close dialog");
                }
                SetInfomation((Account)responseDTO.data);
            }
            else
            {
                tbRole.Text = "STAFF";
            }
        }
        private void SetInfomation(Account account)
        {
            tbId.Text = account.AccountId.ToString();
            tbUsername.Text = account.UserName;
            tbName.Text = account.Name;
            tbRole.Text = account.Role.ToString();
            if (account.PhoneNumber != null)
            {
                tbPhoneNumber.Text = account.PhoneNumber;
            }
            else
            {
                tbPhoneNumber.Text = string.Empty;
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (this.accountId == -1)
            {
                ResponseDTO responseDTO = accountBLL.AddNewAccount(new Account()
                {
                    UserName = tbUsername.Text,
                    Password = tbPassword.Text,
                    Name = tbName.Text,
                    PhoneNumber = tbPhoneNumber.Text,
                    Role = tbRole.Text
                }, tbConfirmPassword.Text);
                if (responseDTO.success)
                {
                    MessageBox.Show("Add new account successfully");
                    this.Close();
                }
                else
                {
                    MessageBox.Show(responseDTO.message);
                }
            }
            else {
                ResponseDTO responseDTO = accountBLL.UpdateAccount(new Account()
                {
                    AccountId = this.accountId,
                    UserName = tbUsername.Text,
                    Name = tbName.Text,
                    PhoneNumber = tbPhoneNumber.Text,
                    Role = tbRole.Text
                });
                if (responseDTO.success)
                {
                    MessageBox.Show("Update account successfully");
                    this.Close();
                }
                else
                {
                    MessageBox.Show(responseDTO.message);
                }
            }
        }

        private void btnChangePassword_Click(object sender, EventArgs e)
        {
            ResponseDTO responseDTO = accountBLL.ChangePassword(new Account()
            {
                AccountId = this.accountId,
                Password = tbPassword.Text
            }, tbConfirmPassword.Text);
            if (responseDTO.success)
            {
                MessageBox.Show("Change password successfully");
                this.Close();
            }
            else
            {
                MessageBox.Show(responseDTO.message);
            }
        }
    }
}
