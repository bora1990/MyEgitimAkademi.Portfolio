using MyEgitimAkademi.Portfolio.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MyEgitimAkademi.Portfolio.Controllers
{
    

    public class RegisterController : Controller
    {
        MyPortfolioDbEntities1 db = new MyPortfolioDbEntities1();

        // GET: Register
        public ActionResult Index()
        {

            return View();
        }
        [HttpPost]
        public ActionResult Index(Admin admin)
        {
            db.Admin.Add(admin);
            db.SaveChanges();
            return RedirectToAction("Index","Login");
        }
    }
}