using Company.Models;
using Company.Models.Responses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Web;
using System.Web.Http;
using System.Web.Http.Cors;
using Company.BusinessLogic.Entities;
using Company.BusinessLogic.Tasks;
using System.Net;

namespace Company.Services.Controllers
{
    [EnableCors("*", "*", "*")]
    [RoutePrefix("api/v1/products")]
    public class ProductsController : ApiController
    {
        [HttpGet]
        [Route("getall")]
        public HttpResponseMessage GetAllByCategory()
        {
            var response = new APIResponse<List<Product>>();

            try
            {
                var productLogic = new ProductsBLL();
                response.Data = productLogic.GetAllByCategory();
                response.HttpStatusCode = HttpStatusCode.OK;

            }
            catch (Exception e)
            {
                response.HttpStatusCode = HttpStatusCode.InternalServerError;
                response.Message = "Error while fetching products";
                response.HasError = true;
            }

            return Request.CreateResponse(response.HttpStatusCode, response);
        }


        [HttpGet]
        [Route("getbycatid/{id}")]
        public HttpResponseMessage GetProductsById(int id)
        {
            var response = new APIResponse<List<Product>>();

            try
            {
                var productLogic = new ProductsBLL();
                response.Data = productLogic.GetProductsById(id);
                response.HttpStatusCode = HttpStatusCode.OK;

            }
            catch (Exception e)
            {
                response.HttpStatusCode = HttpStatusCode.InternalServerError;
                response.Message = "Error while fetching products by category id";
                response.HasError = true;
            }

            return Request.CreateResponse(response.HttpStatusCode, response);
        }
    }
}