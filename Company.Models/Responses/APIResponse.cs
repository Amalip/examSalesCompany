using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Company.Models.Responses
{
    public class APIResponse<T>
    {
        public bool HasError { get; set; }
        public HttpStatusCode HttpStatusCode { get; set; }
        public string Message { get; set; }
        public T Data { get; set; } 
    }
}
