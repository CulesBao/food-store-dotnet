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
        private static readonly AdminForm adminForm = new AdminForm();
        public LoginForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string username = UserNameTextBox.Text;
            string password = PasswordTextBox.Text;
            ResponseDTO responseDTO = accountBLL.Login(username, password);
            MessageBox.Show(responseDTO.message);
            
            if (responseDTO.success)
            {
                this.Hide();
                if (Session.UserRole == "ADMIN")
                {
                    adminForm.FormClosed += (s, args) => Application.Exit();
                    adminForm.Show();
                }
            }
        }
    }
}
