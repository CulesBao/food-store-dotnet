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
    public partial class LoginForm : Form
    {
        private static readonly AccountBLL accountBLL = new AccountBLL();
        public LoginForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string username = UserNameTextBox.Text;
            string password = PasswordTextBox.Text;
            ResponseDTO responseDTO = accountBLL.Login(username, password);
            
            if (responseDTO.success)
            {
                this.Hide();
                if (Session.UserRole == "ADMIN")
                {
                    var adminForm = new AdminForm();
                    adminForm.FormClosed += (s, args) => Application.Exit();
                    adminForm.Show();
                }
                else if (Session.UserRole == "STAFF")
                {
                    var staffForm = new StaffForm();
                    staffForm.FormClosed += (s, args) => Application.Exit();
                    staffForm.Show();
                }
                else
                {
                    MessageBox.Show("Invalid role");
                }
            }
            else
            {
                MessageBox.Show(responseDTO.message);
            }
        }
    }
}
