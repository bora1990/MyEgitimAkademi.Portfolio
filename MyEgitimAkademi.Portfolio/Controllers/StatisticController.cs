using MyEgitimAkademi.Portfolio.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MyEgitimAkademi.Portfolio.Controllers
{
    public class StatisticController : Controller
    {
        MyPortfolioDbEntities1 db=new MyPortfolioDbEntities1();
        [Authorize]
        public ActionResult Index()
        {
            ViewBag.totalProjectCount = db.Project.Count();
            ViewBag.totalTestimonialCount=db.Testimonial.Count();
            ViewBag.sumWorkDay = db.Project.Sum(x => x.CompleteDay);
            ViewBag.avgWorkDay=db.Project.Average(x => x.CompleteDay);
            ViewBag.avgPrice = db.Project.Average(x => x.Price);

          

            int value = (int)db.Project.Max(x => x.Price);//en yüksek fiyat

            ViewBag.maxPriceProject = db.Project.Where(x => x.Price == value).Select(y=>y.Title).FirstOrDefault();

            int value1 = (int)db.Project.Average(x => x.Price);
            ViewBag.highFromAverage = db.Project.Where(x => x.Price >= value1);

            var value2 = db.Category.Where(x => x.CategoryName == "AspNetCORE wEB gELİŞTİRME").Select(y => y.CategoryID).FirstOrDefault();

            ViewBag.categoryCountByName = db.Project.Where(x => x.ProjectCategory == value2).Count();

            var value3=db.Category.Where(x=>x.CategoryName== "Java Spring").Select(x=>x.CategoryID).FirstOrDefault();

            ViewBag.projectCategoryCountByName = db.Project.Where(x => x.ProjectCategory == value3).Count(); 

            return View();
        }
    }
}