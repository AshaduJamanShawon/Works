using BLL.DTOs;
using BLL.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Tranport.Auth;

namespace Tranport.Controllers
{
    public class BusDetailController : ApiController
    {

       
       [Route("api/buss")]
        public HttpResponseMessage Get()
        {
            try
            {
                var data = BusDetailsServices.Get();
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.BadRequest, ex.Message);
            }
        }

        [Route("api/buss/add")]
        [HttpPost]
        public HttpResponseMessage Add(BusDetailsDTO buss)
        {
            try
            {
                var data = BusDetailsServices.Add(buss);
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
        [Route("api/buss/{Id}")]
        [HttpGet]
        public HttpResponseMessage Get(int Id)
        {
            try
            {
                return Request.CreateResponse(HttpStatusCode.OK, BusDetailsServices.Get(Id));
            }
            catch (Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.BadRequest, ex.Message);
            }
        }

        [Route("api/buss/{id}")]
        [HttpDelete]

        public HttpResponseMessage Delete(int id)
        {
            try
            {
                var data = BusDetailsServices.Delete(id);

                return Request.CreateResponse(HttpStatusCode.OK, data);


            }
            catch (Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.BadRequest, ex.Message);
            }
        }
        [Route("api/buss/update")]
        [HttpPost]
        public HttpResponseMessage Update(BusDetailsDTO s)
        {
            BusDetailsServices.Update(s);
            return Request.CreateResponse(HttpStatusCode.OK, "Updated");
        }


    }
}
