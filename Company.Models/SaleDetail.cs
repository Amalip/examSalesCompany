using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Company.Models
{
    public class SaleDetail
    {
        public int IdSaleDetail { get; set; }
        public int IdProduct { get; set; }
        public int ProductQuantity { get; set; }
        public float UnitCost { get; set; }
        public float Total { get; set; }
    }
}
