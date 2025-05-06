using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodStore.DTO
{
    public class FilterFoodDTO
    {
        public int FoodId { get; set; }
        public string FoodName { get; set; }
        public double Price { get; set; }
        public int Quantity { get; set; } = 1;
        public DateTime CreatedAt { get; set; }
    }
}
