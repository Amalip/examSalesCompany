using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Company.Models
{
    public class Product
    {
        public int Id_product { get; set; }
        public string Product_Name { get; set; }
        public float Product_cost { get; set; }
        public string Product_category { get; set; }
        public int Product_stoke { get; set; }
    }
}
