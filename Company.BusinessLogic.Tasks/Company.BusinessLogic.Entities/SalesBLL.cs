using Company.DataAccess;
using Company.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Company.BusinessLogic.Entities
{
    public class SalesBLL
    {
        readonly SalesDAO _salesDAO = new SalesDAO();

        public List<Sale> GetSalesReport()
        {
            return _salesDAO.GetSalesReport();
        }

        public Sale MakeSale (Sale sale)
        {
            return _salesDAO.MakeSale(sale);
        }

        public Sale UpdateSale(Sale sale)
        {
            return _salesDAO.UpdateSale(sale);
        }

    }
}
