using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Company.Models.Interfaces
{
    public interface MProductDAO<T>
    {
        List<T> GetProductsByCategoryId(int id);
        List<T> GetAllByCategory();
        T AddToCart(T entity);
        T UpdateCart(T entity);
        void RemoveFromCart(int id);
        
    }
}
