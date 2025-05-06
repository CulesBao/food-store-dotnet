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
        private static readonly FoodDAL foodDAL = new FoodDAL();
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
    }
}
