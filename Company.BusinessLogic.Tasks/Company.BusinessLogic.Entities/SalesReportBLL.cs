using Company.DataAccess;
using Company.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Company.BusinessLogic.Entities
{
    public class SalesReportBLL
    {

        readonly SalesReportDAO _saleReportDAO = new SalesReportDAO();
        //public List<SalesReport> GetReport(int id)
        //{
        //    return _saleReportDAO.GetReportBySaleId(id);
        //}
        public string GetReport(int id)
        {
            return _saleReportDAO.GetReportBySaleId(id);
        }
    }
}
