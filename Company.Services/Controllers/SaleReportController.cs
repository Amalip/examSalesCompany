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
    [RoutePrefix("api/v1/reports")]
    public class SaleReportController : ApiController
    {

        [HttpGet]
        [Route("getbysaleid/{id}")]
        public HttpResponseMessage GetReportBySaleId(int id)
        {
            //var response = new APIResponse<List<SalesReport>>();
            var response = new APIResponse<SalesReport>();

            try
            {
                var reportLogic = new SalesReportBLL();
                response.Message = reportLogic.GetReport(id);
                response.HttpStatusCode = HttpStatusCode.OK;

            }
            catch (Exception e)
            {
                response.HttpStatusCode = HttpStatusCode.InternalServerError;
                response.Message = "Error while fetching the report";
                response.HasError = true;
            }

            return Request.CreateResponse(response.HttpStatusCode, response.Message);
        }
    }
}