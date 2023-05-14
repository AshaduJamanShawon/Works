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
    [EnableCors("*","*","*")]
    public class AdminController : ApiController
    {
     //   [Logged]
        [Route("api/admins")]
        [HttpGet]
        public HttpResponseMessage Get()
        {
            try
            {
                var data = AdminService.Get();
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch(Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.BadRequest, ex.Message);
            }
        }
        [Route("api/admins/{id}")]
        [HttpGet]
        public HttpResponseMessage Get(int id)
        {
            var data = AdminService.Get(id);
            return Request.CreateResponse(HttpStatusCode.OK, data);
        }
        [Route("api/admins/add")]
        [HttpPost]

        public HttpResponseMessage Add(AdminDTO admin)
        {
            try
            {
                var data = AdminService.Add(admin);
                if (data != null)
                { return Request.CreateResponse(HttpStatusCode.OK, data); }

                return Request.CreateResponse(HttpStatusCode.BadRequest, new { });
            }
            catch (Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.BadRequest, ex.Message);
            }
        }
        [Route("api/admins/{id}")]
        [HttpDelete]

        public HttpResponseMessage Delete(int id)
        {
            try
            {
                var data = AdminService.Delete(id);
                
                return Request.CreateResponse(HttpStatusCode.OK, data); 

                
            }
            catch (Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.BadRequest, ex.Message);
            }
        }
        [Route("api/admins/update")]
        [HttpPost]
        public HttpResponseMessage Update(AdminDTO s)
        {
            AdminService.Update(s);
            return Request.CreateResponse(HttpStatusCode.OK, "Updated");
        }
    }
}
