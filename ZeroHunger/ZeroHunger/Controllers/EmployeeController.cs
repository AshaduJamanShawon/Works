using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ZeroHunger.DB;

namespace ZeroHunger.Controllers
{
    public class EmployeeController : Controller
    {
        // GET: Employee
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult EmployeeHome()
        {


            return View();
        }


        public ActionResult Todayslist()
        {

            var db = new ZeroHungerEntities();
            // var ext = (from st in db.EmployeeAssigns where st.EmployeeId == Id select st).ToList();
            return View();
        }
    }
}