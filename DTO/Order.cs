using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodStore.DTO
{
    public class Order
    {
        public Order()
        {
            OrderItems = new HashSet<OrderItem>();
            CreatedAt = DateTime.Now;
        }
        [Key]
        public int OrderId { get; set; }
        public int AccountId { get; set; }
        [DefaultValue("PENDING")]
        public string Status { get; set; }
        public DateTime CreatedAt { get; set; }
        [ForeignKey("AccountId")]
        public Account Account { get; set; }
        public ICollection<OrderItem> OrderItems { get; set; }
    }
}
