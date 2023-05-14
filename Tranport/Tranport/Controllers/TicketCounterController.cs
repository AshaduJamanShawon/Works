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

namespace pro_admin.Controllers
{

    [EnableCors("*", "*", "*")]
    public class TicketCounterController : ApiController
    {
       

      
        [Route("api/tickets")]
        [HttpGet]
        public HttpResponseMessage Get()
        {
            try
            {
                var data = TicketCounterService.Get();
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.BadRequest, ex.Message);
            }
        }
        [Route("api/tickets/{id}")]
        [HttpGet]
        public HttpResponseMessage Get(int id)
        {
            var data = TicketCounterService.Get(id);
            return Request.CreateResponse(HttpStatusCode.OK, data);
        }
        [Route("api/tickets/add")]
        [HttpPost]

        public HttpResponseMessage Add(TicketCounterDTO ticket)
        {
            try
            {
                var data = TicketCounterService.Add(ticket);
                if (data != null)
                { return Request.CreateResponse(HttpStatusCode.OK, data); }

                return Request.CreateResponse(HttpStatusCode.BadRequest, new { });
            }
            catch (Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.BadRequest, ex.Message);
            }
        }
        [Route("api/tickets/{id}")]
        [HttpDelete]

        public HttpResponseMessage Delete(int id)
        {
            try
            {
                var data = TicketCounterService.Delete(id);

                return Request.CreateResponse(HttpStatusCode.OK, data);


            }
            catch (Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.BadRequest, ex.Message);
            }
        }
        [Route("api/tickets/update")]
        [HttpPost]
        public HttpResponseMessage Update(TicketCounterDTO s)
        {
            TicketCounterService.Update(s);
            return Request.CreateResponse(HttpStatusCode.OK, "Updated");
        }
    }
}
