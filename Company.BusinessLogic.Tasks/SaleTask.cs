using Company.BusinessLogic.Entities;
using Company.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Company.BusinessLogic.Tasks
{
    public class SaleTask
    {
        public Sale MakeNewSale(Sale data, List<SaleDetail> saleDetails)
        {

            var salesBLL = new SalesBLL();
            var salesDetailBLL = new SalesDetailBLL();

            var newSale = salesBLL.MakeSale(data);

            foreach (var item in saleDetails)
            {
                item.Id_sale = newSale.Id_sales;
                salesDetailBLL.MakeSale(item);
            }

            return newSale;

        }
    }
}
