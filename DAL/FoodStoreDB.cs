using System;
using System.Data.Entity;
using System.Linq;

namespace FoodStore.Config
{
    public class FoodStoreDB : DbContext
    {
        public FoodStoreDB()
            : base("name=FoodStore")
        {
            Database.SetInitializer<FoodStoreDB>(new DBInitialize());
        }

        public virtual DbSet<DTO.Account> Accounts { get; set; }
        public virtual DbSet<DTO.Food> Foods { get; set; }
        public virtual DbSet<DTO.Order> Orders { get; set; }
        public virtual DbSet<DTO.OrderItem> OrderItems { get; set; }
    }

}