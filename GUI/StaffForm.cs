using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FoodStore.Config;

namespace FoodStore.GUI
{
    public partial class StaffForm : Form
    {
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
    }
}
