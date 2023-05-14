using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ZeroHunger.DB;

namespace ZeroHunger.Controllers
{
    public class AdminController : Controller
    {
        // GET: Admin
        public ActionResult Index()
        {
            return View();
        }




        public ActionResult AdminHome()
        {
            return View();
        }


        public ActionResult RestaurantList()
        {
            var db = new ZeroHungerEntities();
            var Restaurants = db.Restaurants.ToList();

            return View(Restaurants);

        }




        [HttpGet]
        public ActionResult RestaurantEdit(int Id)
        {
            var db = new ZeroHungerEntities();

            var ext = (from st in db.Restaurants
                       where st.Id == Id
                       select st).SingleOrDefault();
            return View(ext);
        }

        [HttpPost]
        public ActionResult RestaurantEdit(Restaurant s)
        {
            var db = new ZeroHungerEntities();

            var ext = (from st in db.Restaurants
                       where st.Id == s.Id
                       select st).SingleOrDefault();

            ext.Name = s.Name;
            ext.Address = s.Address;
            ext.Email = s.Email;
            ext.PhoneNumber = s.PhoneNumber;


            db.SaveChanges();

            return RedirectToAction("List");

        }






        [HttpGet]
        public ActionResult RestaurantDelete(int Id)
        {
            var db = new ZeroHungerEntities();

            var ext = (from st in db.Restaurants
                       where st.Id == Id
                       select st).SingleOrDefault();
            return View(ext);
        }


        [HttpPost]
        public ActionResult RestaurantDelete(Restaurant s)
        {
            var db = new ZeroHungerEntities();

            var ext = (from st in db.Restaurants
                       where st.Id == s.Id
                       select st).SingleOrDefault();
            db.Restaurants.Remove(ext);
            db.SaveChanges();
            return RedirectToAction("List");
        }




        //request list

        public new ActionResult Request()
        {
            var db = new ZeroHungerEntities();
            var RequestAdds = db.RequestAdds.ToList();

           


            return View(RequestAdds);
        }




        //request accept


        public ActionResult Requestdelete(int Id, RequestAdd s)
        { 
            var db = new ZeroHungerEntities();
             var Employees = db.Employees.ToList();

            // return View(Employees);

                var ext = (from st in db.RequestAdds
                           where st.Id == Id
                           select st).SingleOrDefault();
          
                var extt = (from st in db.RequestAdds
                           where st.Id == s.Id
                           select st).SingleOrDefault();
                db.RequestAdds.Remove(extt);
                db.SaveChanges();
                return RedirectToAction("Accept");
            

        }

        public ActionResult Accept()
        {
            var db = new ZeroHungerEntities();
            var Employees = db.Employees.ToList();

            return View(Employees);
        }



        public ActionResult Assign(int Id)
        {
            var db = new ZeroHungerEntities();
            var ext = (from st in db.Employees where st.Id == Id select st).ToList();


            return View(ext);

        }

        
        public ActionResult AssignAdd(EmployeeAssign add)
        {
            var db = new ZeroHungerEntities();

            db.EmployeeAssigns.Add(add);
            db.SaveChanges();
            return RedirectToAction("AdminHome");

        }



        //employee assign

        public ActionResult EmployeeAssignList()
        {
            var db = new ZeroHungerEntities();
            var EmployeeAssigns = db.EmployeeAssigns.ToList();

            return View(EmployeeAssigns);

        }



    }
}