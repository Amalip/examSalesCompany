using Company.BusinessLogic.Tasks;
using Company.Models;
using Company.Models.Requests;
using Company.Models.Responses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web;
using System.Web.Http;
using System.Web.Http.Cors;

namespace Company.Services.Controllers
{
    [EnableCors("*", "*", "*")]
    [RoutePrefix("api/v1/sales")]
    public class SaleController : ApiController
    {
        [HttpPost]
        [Route("sell")]
        public HttpResponseMessage MakeNewSale([FromBody] RequestMakeSale request)
        {
            var response = new APIResponse<Sale>();

            try
            {
                var saleLogic = new SaleTask();
                var newSale = saleLogic.MakeNewSale(request.SaleData, request.SaleDetailData);
                response.Data = newSale;
                response.Message = "Sale made correctly";
                response.HttpStatusCode = HttpStatusCode.OK;
            }
            catch (Exception e)
            {
                response.HttpStatusCode = HttpStatusCode.InternalServerError;
                response.Message = "Error making sale";
                response.HasError = true;
            }

            return Request.CreateResponse(response.HttpStatusCode, response);
        }
    }
}