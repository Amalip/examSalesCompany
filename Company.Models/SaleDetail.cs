using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Company.Models
{
    public class SaleDetail
    {
        public int Id_sale_detail { get; set; }
        public int Id_product { get; set; }
        public int Id_sale { get; set; }
        public int Product_cuantity { get; set; }
        public float Unit_price { get; set; }
        public float Total_Cost { get; set; }
    }
}
