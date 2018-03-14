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
    
    public class SalesReportDAO : MSalesReportDAO<SalesReport>
    {
        readonly string ConnectionSting = ConfigurationManager.ConnectionStrings["bd_sales_company"].ToString();

        //public List<SalesReport> GetReportBySaleId(int id)
        //{
        //    var parameters = new DynamicParameters();
        //    parameters.Add("p_sale_id", id);

        //    using (var conn = new MySqlConnection(ConnectionSting))
        //    {
        //        var report = conn.Query<SalesReport>("sp_sales_get_report",
        //            parameters, commandType: CommandType.StoredProcedure);

        //        string client = "";
        //        string clientLastname = "";
        //        int totalSales = 0;
        //        float totalEarned = 0;
        //        foreach (var item in report)
        //        {
        //            totalSales += item.Product_cuantity;
        //            totalEarned += item.Total_Cost;
        //            client = item.Client_name;
        //            clientLastname = item.Client_lastname;
        //        }

        //        string report2 = $"{client} {clientLastname} has bought {totalSales} products for a total of {totalEarned}";
        //        return report.ToList();
        //    }
        //}

        public string GetReportBySaleId(int id)
        {
            var parameters = new DynamicParameters();
            parameters.Add("p_sale_id", id);

            using (var conn = new MySqlConnection(ConnectionSting))
            {
                var report = conn.Query<SalesReport>("sp_sales_get_report",
                    parameters, commandType: CommandType.StoredProcedure);

                string client = "";
                string clientLastname = "";
                int totalSales = 0;
                float totalEarned = 0;
                foreach (var item in report)
                {
                    totalSales += item.Product_cuantity;
                    totalEarned += item.Total_Cost;
                    client = item.Client_name;
                    clientLastname = item.Client_lastname;
                }

                string report2 = $"{client} {clientLastname} has bought {totalSales} products for a total of ${totalEarned}";
                return report2;
            }
        }

    }
}
