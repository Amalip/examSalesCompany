using Company.Models;
using Company.Models.Interfaces;
using System;
using System.Data;
using System.Collections.Generic;
using System.Configuration;
using Dapper;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Company.DataAccess
{
    public class ProductDAO : MProductDAO<Product>
    {
        readonly string ConnectionSting = ConfigurationManager.ConnectionStrings["bd_sales_company"].ToString();
        public Product AddToCart(Product entity)
        {
            throw new NotImplementedException();
        }


        public List<Product> GetAllByCategory()
        {
            using (var conn = new MySqlConnection(ConnectionSting))
            {
                var products = conn.Query<Product>("sp_product_get_by_category",
                     commandType: CommandType.StoredProcedure);

                return products.ToList();
            }
        }

        public Product MakeSale(Product entity)
        {
            throw new NotImplementedException();
        }

        public void RemoveFromCart(int id)
        {
            throw new NotImplementedException();
        }

        public Product UpdateCart(Product entity)
        {
            throw new NotImplementedException();
        }

        public List<Product> GetProductsByCategoryId(int id)
        {
            var parameters = new DynamicParameters();
            parameters.Add("p_category_id", id);

            using (var conn = new MySqlConnection(ConnectionSting))
            {
                var products = conn.Query<Product>("sp_product_get_by_category_id",
                    parameters, commandType: CommandType.StoredProcedure);

                return products.ToList();
            }
        }
    }
}
