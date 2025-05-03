using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodStore.Config
{
    public static class Session
    {
        public static void SetSession(int userId, string userName, string userRole)
        {
            UserId = userId;
            UserName = userName;
            UserRole = userRole;
        }
        public static int UserId { get; set; }
        public static string UserName { get; set; }
        public static string UserRole { get; set; }
    }
}
