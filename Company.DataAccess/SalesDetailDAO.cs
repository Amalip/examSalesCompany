using Company.Models;
using Company.Models.Interfaces;
using Dapper;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Company.DataAccess
{
    public class SalesDetailDAO : MSalesDetailDAO<SaleDetail>
    {
        readonly string ConnectionSting = ConfigurationManager.ConnectionStrings["bd_sales_company"].ToString();

        public SaleDetail CreateSaleDetail(SaleDetail entity)
        {
            using (var conn = new MySqlConnection(ConnectionSting))
            {
                var parameters = new DynamicParameters();
                parameters.Add("p_product_id", entity.Id_product);
                parameters.Add("p_sale_id", entity.Id_sale);
                parameters.Add("p_product_cuantity", entity.Product_cuantity);
                parameters.Add("p_unit_price", entity.Unit_price);
                parameters.Add("p_total_cost", entity.Total_Cost);


                conn.Execute("sp_sale_detail_save", parameters, commandType: CommandType.StoredProcedure);

                entity.Id_sale_detail = parameters.Get<int>("p_id_sale_detail");

                return entity;
            }
        }
    }
}
