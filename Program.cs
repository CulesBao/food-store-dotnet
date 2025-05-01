using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using FoodStore.Config;

namespace FoodStore
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            using (var context = new FoodStoreDB())
            {
                var list = context.Accounts.ToList(); // Phải có truy vấn hoặc thao tác
            }
            Application.Run(new Form1());
        }
    }
}
