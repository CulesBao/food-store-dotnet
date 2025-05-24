using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FoodStore.Config;
using FoodStore.DTO;

namespace FoodStore.DAL
{
    public class OrderDAL
    {
        private static FoodStoreDB foodStoreDB = new FoodStoreDB();
        public void CreateOrder(Order order, List<OrderItemDTO> orderItemDTO)
        {
            Account account = foodStoreDB.Accounts.Where(a => a.AccountId == Session.UserId).FirstOrDefault();
            if (account == null)
            {
                throw new Exception("Account not found");
            }
            order.Account = account;
            foodStoreDB.Orders.Add(order);
            foodStoreDB.SaveChanges();
            foreach (var item in orderItemDTO)
            {
                Food food = foodStoreDB.Foods.Where(f => f.FoodId == item.ID).FirstOrDefault();
                OrderItem orderItem = new OrderItem
                {
                    Food = food,
                    Quantity = item.Quantity,
                    Order = order
                };
                foodStoreDB.OrderItems.Add(orderItem);
                food.Quantity -= item.Quantity;
            }
            foodStoreDB.SaveChanges();
        }
        public List<FilterOrderDTO> GetOrdersByDateTime(int StaffId, DateTime StartDate, DateTime EndDate)
        {
            var orders = foodStoreDB.Orders
                .Include("Account")
                .Include("OrderItems.Food")
                .Where(o =>
                    o.CreatedAt >= StartDate &&
                    o.CreatedAt <= EndDate &&
                    (StaffId == -1 || o.AccountId == StaffId) 
                )
                .ToList()
                .Select(o => new FilterOrderDTO
                {
                    OrderId = o.OrderId,
                    StaffName = o.Account.Name,
                    CustomerName = o.CustomerName,
                    CustomerPhoneNumber = o.CustomerPhoneNumber,
                    OrderDate = o.CreatedAt,
                    Status = o.Status,
                    TotalPrice = o.OrderItems.Sum(oi => oi.TotalPrice)
                }).ToList();

            return orders;
        }
        public int UpdateOrderStatus(int OrderId, string Status)
        {
            var order = foodStoreDB.Orders.Where(o => o.OrderId == OrderId).FirstOrDefault();
            if (order == null)
            {
                throw new Exception("Order not found");
            }
            order.Status = Status;
            return foodStoreDB.SaveChanges();
        }
        public void DeleteOrder(int OrderId) {
            Order order = foodStoreDB.Orders.Where(o => o.OrderId == OrderId).FirstOrDefault();
            if (order != null)
            {
                foodStoreDB.Orders.Remove(order);
                foodStoreDB.SaveChanges();
            }
            else
            {
                throw new Exception("Order not found");
            }
        }
    }
}
