using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Company.Models.Interfaces
{
    public interface MSalesDetailDAO<T>
    {
        T CreateSaleDetail(T entity);
    }
}
