﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodStore.DTO
{
    public class DetailOrderItem
    {
        public int OrderItemId { get; set; }
        public int FoodId { get; set; }
        public string FoodName { get; set; }
        public int Quantity { get; set; } = 1;
        public double TotalPrice { get; set; }
    }
}
