using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FoodStore.Config;
using FoodStore.DAL;
using FoodStore.DTO;

namespace FoodStore.BLL
{
    public class AccountBLL
    {
        private static readonly AccountDAL accountDAL = new AccountDAL();
        private void CheckPassword(string Password, string ConfirmPassword)
        {
            if (Password.Trim() == string.Empty || ConfirmPassword.Trim() == string.Empty)
            {
                throw new Exception("Password and Confirm password cannot be empty");
            }
            if (!Password.Equals(ConfirmPassword))
            {
                throw new Exception("Confirm password must be equal password");
            }
            if (Password.Trim().Length < 4)
            {
                throw new Exception("Password must be more than 4 characters");
            }
            foreach(char c in Password)
            {
                if (char.IsWhiteSpace(c))
                {
                    throw new Exception("Password cannot contain space");
                }
            } 
        }
        private void CheckAccount(Account account)
        {
            foreach (char c in account.UserName)
            {
                if (char.IsWhiteSpace(c))
                {
                    throw new Exception("Username cannot contain space");
                }
            }
            if (account.UserName.Trim().Length < 4)
            {
                throw new Exception("Username must be more than 4 characters");
            }
            if (!account.Role.Equals("STAFF") && !account.Role.Equals("ADMIN"))
            {
                throw new Exception("Role must be STAFF or ADMIN");
            }
        }
        public ResponseDTO Login(string username, string password)
        {
            try
            {
                Account account = accountDAL.GetAccountByUsername(username);
                if (account == null)
                {
                    throw new Exception("Wrong username or password");
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
            catch (Exception e)
            {
                return new ResponseDTO
                {
                    success = false,
                    data = null,
                    message = e.Message
                };
            }
        }
        public ResponseDTO GetAccountByNameAndPhoneNumber(string Name, string PhoneNumber)
        {
            try
            {
                return new ResponseDTO()
                {
                    success = true,
                    data = accountDAL.GetAccountsByNameAndPhoneNumber(Name, PhoneNumber),
                    message = "Get account successfully"
                };
            }
            catch (Exception e)
            {
                return new ResponseDTO()
                {
                    success = false,
                    data = null,
                    message = e.Message
                };
            }
        }
        public ResponseDTO GetAccountByAccountId(int AccountId)
        {
            try
            {
                return new ResponseDTO()
                {
                    success = true,
                    data = accountDAL.GetAccountById(AccountId),
                    message = "Get account successfully"
                };
            }
            catch(Exception e)
            {
                return new ResponseDTO()
                {
                    success = false,
                    data = null,
                    message = e.Message
                };
            }
        }
        public ResponseDTO AddNewAccount(Account account, string ConfirmPassword)
        {
            try
            {
                CheckPassword(account.Password, ConfirmPassword);
                if (accountDAL.IsExistUsername(account.UserName))
                {
                    throw new Exception("Username is already existed");
                }
                CheckAccount(account);
                account.Password = BCrypt.Net.BCrypt.EnhancedHashPassword(account.Password);
                int rowAffected = accountDAL.AddNewAccount(account);
                if (rowAffected == 0)
                {
                    throw new Exception("Add account failed");
                }
                return new ResponseDTO()
                {
                    success = true,
                    data = null,
                    message = "Add account successfully"
                };
            }
            catch (Exception e)
            {
                return new ResponseDTO()
                {
                    success = false,
                    data = null,
                    message = e.Message
                };
            }
        }
        public ResponseDTO UpdateAccount(Account account)
        {
            try
            {
                CheckAccount(account);
                accountDAL.UpdateAccount(account);
                return new ResponseDTO()
                {
                    success = true,
                    data = null,
                    message = "Update account successfully"
                };
            }
            catch (Exception e)
            {
                return new ResponseDTO()
                {
                    success = false,
                    data = null,
                    message = e.Message
                };
            }
        }
        public ResponseDTO ChangePassword(Account account, string confirmPassword)
        {
            try
            {
                CheckPassword(account.Password, confirmPassword);
                account.Password = BCrypt.Net.BCrypt.EnhancedHashPassword(account.Password);
                accountDAL.ChangePassword(account);
                return new ResponseDTO()
                {
                    success = true,
                    data = null,
                    message = "Change password successfully"
                };
            }
            catch (Exception e)
            {
                return new ResponseDTO()
                {
                    success = false,
                    data = null,
                    message = e.Message
                };
            }
        }
        public ResponseDTO DeleteAccount(int accountId)
        {
            try
            {
                accountDAL.DeleteAccount(accountId);
                return new ResponseDTO()
                {
                    success = true,
                    data = null,
                    message = "Delete account successfully"
                };
            }
            catch (Exception e)
            {
                return new ResponseDTO()
                {
                    success = false,
                    data = null,
                    message = e.Message
                };
            }
        }
    }
}
