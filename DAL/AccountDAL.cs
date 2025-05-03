using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FoodStore.Config;
using FoodStore.DTO;

namespace FoodStore.DAL
{
    public class AccountDAL
    {
        private static readonly FoodStoreDB db = new FoodStoreDB();
        public Account getAccountByUsername(string username)
        {
            return db.Accounts.Where(a => a.UserName == username).First();
        }
    }
}
