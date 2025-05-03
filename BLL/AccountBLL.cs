using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FoodStore.Config;
using FoodStore.DAL;
using FoodStore.DTO;

namespace FoodStore.BLL
{
    public class AccountBLL
    {
        private static readonly AccountDAL accountDAL = new AccountDAL();
        public ResponseDTO Login(string username, string password)
        {
            Account account = accountDAL.getAccountByUsername(username);
            if (account == null)
            {
                return new ResponseDTO
                {
                    success = false,
                    data = null,
                    message = "Wrong username or password"
                };
            }
            if (BCrypt.Net.BCrypt.EnhancedVerify(password, account.Password))
            {
                Session.SetSession(account.AccountId, account.Name, account.Role);
                return new ResponseDTO
                {
                    success = true,
                    data = null,
                    message = "Login successful"
                };
            }
            return new ResponseDTO
            {
                success = false,
                data = null,
                message = "Wrong username or password"
            };
        }
    }
}
