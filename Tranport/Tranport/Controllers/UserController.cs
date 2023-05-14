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
    public class UserController : ApiController
    {
       
        [Route("api/users")]
        [HttpGet]
        public HttpResponseMessage Get()
        {
            try
            {
                var data = UserService.Get();
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.BadRequest, ex.Message);
            }
        }
        [Route("api/users/{id}")]
        [HttpGet]
        public HttpResponseMessage Get(int id)
        {
            var data = UserService.Get(id);
            return Request.CreateResponse(HttpStatusCode.OK, data);
        }
        [Route("api/users/add")]
        [HttpPost]

        public HttpResponseMessage Add(UserDTO user)
        {
            try
            {
                var data = UserService.Add(user);
                if (data != null)
                { return Request.CreateResponse(HttpStatusCode.OK, data); }

                return Request.CreateResponse(HttpStatusCode.BadRequest, new { });
            }
            catch (Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.BadRequest, ex.Message);
            }
        }
        [Route("api/users/{id}")]
        [HttpDelete]

        public HttpResponseMessage Delete(int id)
        {
            try
            {
                var data = UserService.Delete(id);

                return Request.CreateResponse(HttpStatusCode.OK, data);


            }
            catch (Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.BadRequest, ex.Message);
            }
        }
        [Route("api/users/update")]
        [HttpPost]
        public HttpResponseMessage Update(UserDTO s)
        {
            UserService.Update(s);
            return Request.CreateResponse(HttpStatusCode.OK, "Updated");
        }
    }
}
