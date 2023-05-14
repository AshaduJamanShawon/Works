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
    public class BusOwnerController : ApiController
    {

        [Logged]
        [Route("api/busowners")]
        public HttpResponseMessage Get()
        {
            try
            {
                var data = BusOwnerService.Get();
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.BadRequest, ex.Message);
            }
        }

        [Route("api/busowners/add")]
        [HttpPost]
         public HttpResponseMessage Add(BusOwnerDTO busOwner)
        {
            try
            {
                var data = BusOwnerService.Add(busOwner);
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
        [Route("api/busowners/{Id}")]
        [HttpGet]
        public HttpResponseMessage Get(int Id)
        {
            try
            {
                return Request.CreateResponse(HttpStatusCode.OK, BusOwnerService.Get(Id));
            }
            catch (Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.BadRequest, ex.Message);
            }
        }

       

        [Route("api/busowners/{id}")]
        [HttpDelete]

        public HttpResponseMessage Delete(int id)
        {
            try
            {
                var data = BusOwnerService.Delete(id);

                return Request.CreateResponse(HttpStatusCode.OK, data);


            }
            catch (Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.BadRequest, ex.Message);
            }
        }
        [Route("api/busowners/update")]
        [HttpPost]
        public HttpResponseMessage Update(BusOwnerDTO s)
        {
            BusOwnerService.Update(s);
            return Request.CreateResponse(HttpStatusCode.OK, "Updated");
        }

    }
}
