using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pet_mart_api.Models
{
    #nullable disable annotations
    public class OrderDetails
    {
        public string Id { get; set; }
        public string OrderId { get; set; }
        public int OrderedCount { get; set; }
        public ICollection<Product> Products { get; set; }
        public Order Order { get; set; }

    }
}
