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
        private static readonly FoodStoreDB Instance = new FoodStoreDB();

        public int AddNewAccount(Account account)
        {
            Instance.Accounts.Add(account);
            return Instance.SaveChanges();
        }
        public Account GetAccountByUsername(string username)
        {
            return Instance.Accounts.Where(a => a.UserName == username).FirstOrDefault();
        }
        public List<FilterAccountDTO> GetAccountsByNameAndPhoneNumber(string Name, string PhoneNumber)
        {
            return Instance.Accounts.Where(a => (string.IsNullOrEmpty(Name) 
            || a.Name.Contains(Name)) && (string.IsNullOrEmpty(PhoneNumber) 
            || a.PhoneNumber.Contains(PhoneNumber)))
            .Select(a => new FilterAccountDTO
            {
                AccountId = a.AccountId,
                UserName = a.UserName,
                Name = a.Name,
                PhoneNumber = a.PhoneNumber,
                CreatedAt = a.CreatedAt,
                Role = a.Role
            }).ToList();
        }

        public Account GetAccountById(int accountId)
        {
            return Instance.Accounts.Where(a => a.AccountId == accountId).FirstOrDefault();
        }
        public bool IsExistUsername(string username)
        {
            return Instance.Accounts.Where(a => a.UserName == username).FirstOrDefault() != null;
        }
        public int UpdateAccount(Account account)
        {
            Account oldAccount = Instance.Accounts.Where(a => a.AccountId == account.AccountId).FirstOrDefault();
            if (oldAccount != null)
            {
                oldAccount.Name = account.Name;
                oldAccount.PhoneNumber = account.PhoneNumber;
                return Instance.SaveChanges();
            }
            return 0;
        }
        public int ChangePassword(Account account)
        {
            Account oldAccount = Instance.Accounts.Where(a => a.AccountId == account.AccountId).FirstOrDefault();
            if (oldAccount != null)
            {
                oldAccount.Password = account.Password;
                return Instance.SaveChanges();
            }
            return 0;
        }
    }
}
