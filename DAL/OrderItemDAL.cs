using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FoodStore.Config;
using FoodStore.DTO;

namespace FoodStore.DAL
{
    public class OrderItemDAL
    {
        private static FoodStoreDB foodStoreDB = new FoodStoreDB();
        public List<DetailOrderItem> GetOrderItemByOrderId(int OrderId)
        {
            var orderItems = foodStoreDB.OrderItems
                .Include("Food")
                .Where(oi => oi.OrderId == OrderId)
                .Select(oi => new DetailOrderItem
                {
                    OrderItemId = oi.OrderItemId,
                    FoodId = oi.FoodId,
                    FoodName = oi.Food.FoodName,
                    Quantity = oi.Quantity,
                    TotalPrice = oi.Quantity * oi.Food.Price
                })
                .ToList();
            return orderItems;
        }
    }
}
