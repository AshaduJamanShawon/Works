using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ZeroHunger.DB;

namespace ZeroHunger.Controllers
{
    public class MainController : Controller
    {
        // GET: Main
        public ActionResult Home()
        {
            return View();
        }
        public ActionResult DynamicLogin(Restaurant objUser, Admin objAdmin)
        {
            if (ModelState.IsValid)
            {
                using (ZeroHungerEntities db = new ZeroHungerEntities())
                {
                    var ob = db.Admins.Where(a => a.Email.Equals(objAdmin.Email) && a.Password.Equals(objAdmin.Password)).FirstOrDefault();
                    if (ob != null)
                    {
                        return RedirectToAction("../Admin/AdminHome");
                    }
                    var obj = db.Restaurants.Where(a => a.Email.Equals(objUser.Email) && a.Password.Equals(objUser.Password)).FirstOrDefault();
                    if (obj != null)
                    {
                        Session["UserID"] = obj.Id.ToString();
                        Session["UserName"] = obj.Name.ToString();
                        return RedirectToAction("../Restaurant/RestaurantHome");
                    }

                    var objj = db.Employees.Where(a => a.Email.Equals(objUser.Email) && a.Password.Equals(objUser.Password)).FirstOrDefault();
                    if (objj != null)
                    {
                        Session["EID"] = objj.Id.ToString();
                        Session["EName"] = objj.Name.ToString();
                        return RedirectToAction("../Employee/EmployeeHome");
                    }

                }
            }
            return View(objAdmin);
        }

        public ActionResult About()
        {
            return View();
        }


        public ActionResult Award()
        {
            return View();
        }

    }
    }
