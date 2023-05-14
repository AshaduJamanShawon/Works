using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Deployment.Internal;
using System.Linq;
using System.Security.Cryptography;
using System.Web;
using System.Web.Helpers;
using System.Web.Mvc;
using System.Web.Services.Description;
using ZeroHunger.DB;

namespace ZeroHunger.Controllers
{
    public class RestaurantController : Controller
    {
        // GET: Restaurant
        public ActionResult Index()
        {
            return View();
        }



        public ActionResult RestaurantHome(string Email)
        {
            var db = new ZeroHungerEntities();

            var ext = (from st in db.Restaurants where st.Email == Email select st).ToList();

           
                return View(ext);
          

        }

       
            public ActionResult food(int Id)
            {

            var db = new ZeroHungerEntities();
            var ext = (from st in db.Restaurants where st.Id == Id select st).ToList();


            return View(ext);

         

        }


     [HttpPost]
       public ActionResult foodadd(RequestAdd ad)
    {

         var db = new ZeroHungerEntities();
            
        db.RequestAdds.Add(ad);

        db.SaveChanges();
       return RedirectToAction("RestaurantHome");

    }


    
    




        [HttpGet]
        public ActionResult RestaurantReg()
        {
            return View();
        }



        [HttpPost]
        public ActionResult RestaurantReg(Restaurant add)
        {

            var db = new ZeroHungerEntities();

            db.Restaurants.Add(add);

            db.SaveChanges();
            return RedirectToAction("Home");

        }
     

    }
}