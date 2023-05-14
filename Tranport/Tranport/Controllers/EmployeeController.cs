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
    public class EmployeeController : ApiController
    {
      
        [Logged]
        [Route("api/employees")]
        public HttpResponseMessage Get()
        {
            try
            {
                var data = EmployeeServices.Get();
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.BadRequest, ex.Message);
            }
        }


        [Route("api/employees/add")]
        [HttpPost]
        public HttpResponseMessage Add(EmployeeDTO employee)
        {
            try
            {
                var data = EmployeeServices.Add(employee);
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
        [Route("api/employees/{Id}")]
        [HttpGet]
        public HttpResponseMessage Get(int Id)
        {
            try
            {
                return Request.CreateResponse(HttpStatusCode.OK, EmployeeServices.Get(Id));
            }
            catch (Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.BadRequest, ex.Message);
            }
        }



        [Route("api/employees/{id}")]
        [HttpDelete]

        public HttpResponseMessage Delete(int id)
        {
            try
            {
                var data = EmployeeServices.Delete(id);

                return Request.CreateResponse(HttpStatusCode.OK, data);


            }
            catch (Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.BadRequest, ex.Message);
            }
        }
        [Route("api/employees/update")]
        [HttpPost]
        public HttpResponseMessage Update(EmployeeDTO s)
        {
            EmployeeServices.Update(s);
            return Request.CreateResponse(HttpStatusCode.OK, "Updated");
        }


    }
}
