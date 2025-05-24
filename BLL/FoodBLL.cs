using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FoodStore.DAL;
using FoodStore.DTO;

namespace FoodStore.BLL
{
    public class FoodBLL
    {
        private static FoodDAL foodDAL = new FoodDAL();
        private void validateFood(Food food)
        {
            if (string.IsNullOrEmpty(food.FoodName))
                throw new Exception("Food name is required");
            if (food.Quantity <= 0)
                throw new Exception("Quantity must be greater than 0");
            if (food.Price <= 0)
                throw new Exception("Price must be greater than 0");
        }
        public ResponseDTO GetFoodsByName(string Name)
        {
            try
            {
                return new ResponseDTO()
                {
                    success = true,
                    message = "Get food successfully",
                    data = foodDAL.GetFoodsByName(Name)
                };
            }
            catch (Exception e)
            {
                return new ResponseDTO()
                {
                    success = false,
                    message = e.Message,
                    data = null
                };
            }
        }
        public ResponseDTO AddFood(Food food)
        {
            try
            {
                validateFood(food);
                if (foodDAL.AddFood(food) > 0)
                {
                    return new ResponseDTO()
                    {
                        success = true,
                        message = "Add food successfully",
                        data = null
                    };
                }
                else
                {
                    throw new Exception("Add food failed");
                }
            }
            catch (Exception e)
            {
                return new ResponseDTO()
                {
                    success = false,
                    message = e.Message,
                    data = null
                };
            }
        }
        public ResponseDTO UpdateFood(Food food)
        {
            try
            {
                validateFood(food);
                return new ResponseDTO()
                {
                    success = foodDAL.UpdateFood(food) > 0,
                    message = "Update food successfully",
                    data = null
                };
            }
            catch (Exception e)
            {
                return new ResponseDTO()
                {
                    success = false,
                    message = e.Message,
                    data = null
                };
            }
        }
        public ResponseDTO DeleteFoodById(int FoodId)
        {
            try
            {
                foodDAL.DeleteFood(FoodId);
                return new ResponseDTO()
                {
                    success = true,
                    message = "Delete food successfully",
                    data = null
                };
            }
            catch (Exception e)
            {
                return new ResponseDTO()
                {
                    success = false,
                    message = e.Message,
                    data = null
                };
            }
        }
    }
}
