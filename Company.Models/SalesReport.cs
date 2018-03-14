using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Company.Models
{
    public class SalesReport
    {
        //public int Id_sale_detail { get; set; }
        //public int Id_product { get; set; }
        //public int Id_sale { get; set; }
        public int Product_cuantity { get; set; }
        public float Unit_price { get; set; }
        public float Total_Cost { get; set; }
        //public int Id_sales { get; set; }
        //public int Id_client { get; set; }
        public DateTime Sale_date { get; set; }
        public bool Sale_status { get; set; }
        public string Product_name { get; set; }
        public string Client_name { get; set; }
        public string Client_lastname { get; set; }

    }
}
