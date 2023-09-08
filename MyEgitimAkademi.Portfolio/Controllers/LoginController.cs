using MyEgitimAkademi.Portfolio.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

namespace MyEgitimAkademi.Portfolio.Controllers
{
    public class LoginController : Controller
    {
        MyPortfolioDbEntities1 db=new MyPortfolioDbEntities1();
        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Index(Admin p)
        {
            var values=db.Admin.FirstOrDefault(x=>x.UserName==p.UserName && x.Password==p.Password); 
            if(values!=null) {

                FormsAuthentication.SetAuthCookie(values.UserName, false); //kalıcı cookie 
                Session["username"]=values.UserName.ToString(); // username e göre dolaşım sağlancak
                return RedirectToAction("Index", "Service");           
            }
            return View();
        }
    }
}