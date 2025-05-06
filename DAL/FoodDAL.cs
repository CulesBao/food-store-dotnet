using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FoodStore.Config;
using FoodStore.DTO;

namespace FoodStore.DAL
{
    public class FoodDAL
    {
        private FoodStoreDB Instance = new FoodStoreDB();
        public List<FilterFoodDTO> GetFoodsByName(string Name)
        {
            return Instance.Foods.Where(f => (string.IsNullOrEmpty(Name) || f.FoodName.Contains(Name))).Select(f => new FilterFoodDTO()
            {
                FoodId = f.FoodId,
                FoodName = f.FoodName,
                Price = f.Price,
                Quantity = f.Quantity,
                CreatedAt = f.CreatedAt
            }).ToList();
        }
        public int AddFood(Food food)
        {
            Instance.Foods.Add(food);
            return Instance.SaveChanges();
        }
        public int UpdateFood(Food food)
        {
            Food oldFood = Instance.Foods.Where(f => f.FoodId == food.FoodId).FirstOrDefault();
            if (oldFood == null)
            {
                throw new Exception("Food not found");
            }
            oldFood.FoodName = food.FoodName;
            oldFood.Price = food.Price;
            oldFood.Quantity = food.Quantity;
            return Instance.SaveChanges();
        }
    }
}
