using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Company.Models.Interfaces
{
    public interface MSaleDAO<T>
    {
        //List<T> GetSalesReport();
        T MakeSale(T entity);
        T UpdateSale(T entity);
        
    }
}
