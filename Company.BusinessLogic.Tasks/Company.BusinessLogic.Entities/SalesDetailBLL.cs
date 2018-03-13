using Company.DataAccess;
using Company.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Company.BusinessLogic.Entities
{
    public class SalesDetailBLL
    {
        readonly SalesDetailDAO _salesDetailDAO = new SalesDetailDAO();
        public SaleDetail MakeSale(SaleDetail saleDetail)
        {
            return _salesDetailDAO.CreateSaleDetail(saleDetail);
        }
    }
}
