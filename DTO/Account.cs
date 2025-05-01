using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodStore.DTO
{
    public class Account
    {
        public Account()
        {
            Orders = new HashSet<Order>();
            CreatedAt = DateTime.Now;
        }
        [Key]
        public int AccountId { get; set; }
        [Required(ErrorMessage = "UserName is required")]
        [MinLength(3, ErrorMessage = "UserName must be at least 3 characters long")]
        public string UserName { get; set; }

        [Required(ErrorMessage = "Password is required")]
        [MinLength(3, ErrorMessage = "Password must be at least 3 characters long")]
        public string Password { get; set; }
        [Required(ErrorMessage = "Name is required")]
        [MinLength(2, ErrorMessage = "Name must be at least 2 characters long")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Role is required")]
        [DefaultValue("STAFF")]
        public string Role { get; set; }
        public DateTime CreatedAt { get; set; }

        public ICollection<Order> Orders { get; set; }
    }
}
