using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Company.Models
{
    public class Sale
    {
        public int Id_sales{ get; set; }
        public int Id_client { get; set; }
        public DateTime Sale_date { get; set; }
        public int Sale_status { get; set; }
    }
}
