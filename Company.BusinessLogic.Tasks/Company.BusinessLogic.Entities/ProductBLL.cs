using Company.DataAccess;
using Company.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Company.BusinessLogic.Entities
{
    public class ProductsBLL
    {
        readonly ProductDAO _productDAO = new ProductDAO();

        public List<Product> GetProductsById(int id)
        {
            return _productDAO.GetProductsByCategoryId(id);
        }

        public List<Product> GetAllByCategory()
        {
            return _productDAO.GetAllByCategory();
        }
    }
}
