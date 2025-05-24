using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FoodStore.DAL;
using FoodStore.DTO;

namespace FoodStore.BLL
{
    public class OrderBLL
    {
        private static OrderDAL orderDAL = new OrderDAL();
        public ResponseDTO AddNewOrder(string name, string phoneNumber, List<OrderItemDTO> items)
        {
            try
            {
                if (items == null || items.Count == 0)
                {
                    throw new Exception("No item orders!");
                }
                orderDAL.CreateOrder(new Order()
                {
                    CustomerName = string.IsNullOrEmpty(name) ? "Unknown" : name,
                    CustomerPhoneNumber = string.IsNullOrEmpty(phoneNumber) ? "Unknown" : phoneNumber,
                }, items);
                return new ResponseDTO()
                {
                    success = true,
                    message = "Order created successfully",
                    data = null
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
        public ResponseDTO GetOrderByDateTime(int StaffId, DateTime StartDate, DateTime EndDate)
        {
            try
            {
                List<FilterOrderDTO> orders = orderDAL.GetOrdersByDateTime(StaffId, StartDate, EndDate);
                return new ResponseDTO()
                {
                    success = true,
                    message = "Get orders successfully",
                    data = orders
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
        public ResponseDTO UpdateOrderStatus(int OrderId, string Status)
        {
            try
            {
                int result = orderDAL.UpdateOrderStatus(OrderId, Status);
                if (result == 0)
                {
                    throw new Exception("Update order failed");
                }
                return new ResponseDTO()
                {
                    success = true,
                    message = "Update order status successfully",
                    data = null
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
        public ResponseDTO DeleteOrderById(int OrderId)
        {
            try
            {
                orderDAL.DeleteOrder(OrderId);
                return new ResponseDTO()
                {
                    success = true,
                    message = "Delete order successfully",
                    data = null
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
