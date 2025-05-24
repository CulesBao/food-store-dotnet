using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FoodStore.DTO;

namespace FoodStore.BLL
{
    public class OrderItemBLL
    {
        private static OrderItemBLL orderItemBLL = new OrderItemBLL();
        public ResponseDTO GetOrderItemByOrderId(int OrderId)
        {
            try
            {
                var orderItemDAL = new DAL.OrderItemDAL();
                var orderItems = orderItemDAL.GetOrderItemByOrderId(OrderId);
                if (orderItems == null || orderItems.Count == 0)
                {
                    throw new Exception("No items found for this order.");
                }
                return new ResponseDTO
                {
                    success = true,
                    message = "Order items retrieved successfully.",
                    data = orderItems
                };
            }
            catch (Exception ex)
            {
                return new ResponseDTO
                {
                    success = false,
                    message = ex.Message,
                    data = null
                };
            }
        }
    }
}
