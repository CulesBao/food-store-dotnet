using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodStore.DTO
{
    public class Food
    {
        public Food()
        {
            OrderItems = new HashSet<OrderItem>();
            CreatedAt = DateTime.Now;
        }
        [Key]
        public int FoodId { get; set; }
        [Required(ErrorMessage = "FoodName is required")]
        public string FoodName { get; set; }
        [Required(ErrorMessage = "Price is required")]
        [Range(0, double.MaxValue, ErrorMessage = "Price must be a positive number")]
        public double Price { get; set; }
        [DefaultValue(true)]
        public bool Available { get; set; }
        public DateTime CreatedAt { get; set; }
        public ICollection<OrderItem> OrderItems { get; set; }
    }
}
