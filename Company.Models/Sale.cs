using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Company.Models
{
    public class Sale
    {
        public int Id { get; set; }
        public int IdClient { get; set; }
        public DateTime SaleDate { get; set; }
        public bool Status { get; set; }
    }
}
