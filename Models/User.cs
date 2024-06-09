using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pet_mart_api.Models
{
    #nullable disable annotations
    public class User
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public bool IsActive { get; set; }
        public List<Product> ShoppingCart { get; set; }
        public ICollection<Pet> Pets { get; set; }
    }
}
