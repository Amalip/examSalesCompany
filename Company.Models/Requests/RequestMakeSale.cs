using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Company.Models.Requests
{
    public class RequestUpdateStatus
    {
        public Sale SaleData { get; set; }
        public List<SaleDetail> SaleDetailData { get; set; }
    }
}
