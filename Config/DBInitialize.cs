using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FoodStore.DTO;

namespace FoodStore.Config
{
    public class DBInitialize: CreateDatabaseIfNotExists<FoodStoreDB>
    {
        protected override void Seed(FoodStoreDB context)
        {
            context.Accounts.Add(new Account()
            {
                AccountId = 1,
                UserName = "admin",
                Password = BCrypt.Net.BCrypt.EnhancedHashPassword("admin"),
                Role = "ADMIN",
                Name = "ADMIN",
                CreatedAt = DateTime.Now,
                Orders = new HashSet<Order>()
            });
            base.Seed(context);
        }
    }
}
