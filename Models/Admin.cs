using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pet_mart_api.Models
{
    #nullable disable annotations
    public class Admin : User
    {
        public string UserId { get; set; }
        public string JobTitle { get; set; }
        public DateTime HireDate { get; set; }
        public User User { get; set; }
    }
}
