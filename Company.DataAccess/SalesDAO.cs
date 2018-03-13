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

        //public List<Sale> GetSalesReport()
        //{
        //    throw new NotImplementedException();
        //}

        public Sale MakeSale(Sale entity)
        {
            using (var conn = new MySqlConnection(ConnectionSting))
            {
                var parameters = new DynamicParameters();
                parameters.Add("p_id_client", entity.Id_client);
                parameters.Add("p_sale_date", entity.Sale_date);
                parameters.Add("p_sale_status", entity.Sale_status);
                parameters.Add("p_id", 0);

                conn.Execute("sp_sales_save", parameters, commandType: CommandType.StoredProcedure);

                entity.Id_sales = parameters.Get<int>("p_id");

                return entity;
            }
        }

        public Sale UpdateSale(Sale entity)
        {
            using (var conn = new MySqlConnection(ConnectionSting))
            {
                var parameters = new DynamicParameters();
                parameters.Add("p_sale_status", entity.Sale_status);

                conn.Execute("sp_sales_chance_status", parameters, commandType: CommandType.StoredProcedure);

               // entity.Id_sales = parameters.Get<int>("p_id_sale");

                return entity;
            }
        }
    }
}
