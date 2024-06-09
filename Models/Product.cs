using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pet_mart_api.Models
{
    #nullable disable annotations
    public class Product
    {
        public int Id { get; set; }
        public string NameEn { get; set; }
        public string NameAr { get; set; }
        public decimal UnitPrice { get; set; }
        public decimal StockQuantity { get; set; }
        public string CategoryId { get; set; }
        public Category Category { get; set; }
    }
}
