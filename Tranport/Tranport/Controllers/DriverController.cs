using BLL.DTOs;
using BLL.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;
using Tranport.Auth;

namespace Tranport.Controllers
{

    [EnableCors("*", "*", "*")]
    public class DriverController : ApiController
    {
        [Logged]
        [Route("api/drivers")]
        public HttpResponseMessage Get()
        {
            try
            {
                var data = DriverServices.Get();
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.BadRequest, ex.Message);
            }
        }


        [Route("api/drivers/add")]
        [HttpPost]
        public HttpResponseMessage Add(DriverDTO driver)
        {
            try
            {
                var data = DriverServices.Add(driver);
                if (data != null)
                {
                    return Request.CreateResponse(HttpStatusCode.OK, data);
                }
                return Request.CreateResponse(HttpStatusCode.BadRequest, new { });
            }
            catch (Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.BadRequest, ex.Message);
            }
        }
        [Route("api/drivers/{Id}")]
        [HttpGet]
        public HttpResponseMessage Get(int Id)
        {
            try
            {
                return Request.CreateResponse(HttpStatusCode.OK, DriverServices.Get(Id));
            }
            catch (Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.BadRequest, ex.Message);
            }
        }


        [Route("api/drivers/{id}")]
        [HttpDelete]

        public HttpResponseMessage Delete(int id)
        {
            try
            {
                var data = DriverServices.Delete(id);

                return Request.CreateResponse(HttpStatusCode.OK, data);


            }
            catch (Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.BadRequest, ex.Message);
            }
        }
        [Route("api/drivers/update")]
        [HttpPost]
        public HttpResponseMessage Update(DriverDTO s)
        {
            DriverServices.Update(s);
            return Request.CreateResponse(HttpStatusCode.OK, "Updated");
        }


    }
}
