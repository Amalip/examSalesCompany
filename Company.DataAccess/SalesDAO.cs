using Company.Models;
using Company.Models.Interfaces;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using Dapper;
using System.Text;
using System.Threading.Tasks;

namespace Company.DataAccess
{
    public class SalesDAO : MSaleDAO<Sale>
    {
        readonly string ConnectionSting = ConfigurationManager.ConnectionStrings["bd_sales_company"].ToString();

        public List<Sale> GetSalesReport()
        {
            throw new NotImplementedException();
        }

        public Sale MakeSale(Sale entity)
        {
            throw new NotImplementedException();
        }

        public Sale UpdateSale(Sale entity)
        {
            throw new NotImplementedException();
        }
    }
}
