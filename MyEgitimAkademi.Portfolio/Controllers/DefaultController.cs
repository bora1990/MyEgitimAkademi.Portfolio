using MyEgitimAkademi.Portfolio.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MyEgitimAkademi.Portfolio.Controllers
{
    public class DefaultController : Controller
    {
        MyPortfolioDbEntities1 db=new MyPortfolioDbEntities1();

        public ActionResult Index()
        {
            return View();
        }
        public PartialViewResult PartialHead()
        {
            return PartialView();
        }

        public PartialViewResult PartialNavbar()
        {
            return PartialView();   
        }
        public PartialViewResult PartialQuickContact()
        {
            return PartialView();
        }
        public PartialViewResult PartialFeature()
        {

            return PartialView();   
        }
        public PartialViewResult PartialService()
        {
            var values=db.Service.ToList();

            return PartialView(values);
        }
        public PartialViewResult PartialSkill() 
        {
            var values=db.Skill.ToList();   

            return PartialView(values);
        }
        public PartialViewResult PartialAward()
        {
            var values=db.Award.ToList();   
            return PartialView(values);
        }

        public PartialViewResult PartialTestimonial()
        {
            var value=db.Testimonial.ToList();
            return PartialView(value);
        }

        public PartialViewResult PartialClientPartner()
        {
            var value=db.ClientPartner.FirstOrDefault();
            return PartialView(value);
        }

    }
}