using MyEgitimAkademi.Portfolio.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MyEgitimAkademi.Portfolio.Controllers
{
    public class TestimonialController : Controller
    {
        // GET: Testimonial
        MyPortfolioDbEntities1 db = new MyPortfolioDbEntities1();

        [Authorize]
        public ActionResult Index()
        {
            var values = db.Testimonial.ToList();  //verilen dizideki elemanları listeler.

            return View(values);
        }
        public ActionResult AddTestimonial()
        {
            return View();
        }
        [HttpPost]
        public ActionResult AddTestimonial(Testimonial testimonial) //burada testimonial otomatik newleniyor mu?
        {
            db.Testimonial.Add(testimonial); //id siz
            db.SaveChanges();
            return RedirectToAction("Index");      
        }

        public ActionResult DeleteTestimonial(int id)
        {
            var value = db.Testimonial.Find(id);
     
            db.Testimonial.Remove(value);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
        public ActionResult UpdateTestimonial(int id)  //id routetan geliyor.
        {
            var value=db.Testimonial.Find(id);
            return View(value);

        }
        [HttpPost]
        public ActionResult UpdateTestimonial(Testimonial testimonial)
        {
            var value = db.Testimonial.Find(testimonial.TestimonialID);

            value.NameSurname = testimonial.NameSurname;
            value.Title = testimonial.Title;
            value.ImageUrl = testimonial.ImageUrl;
            value.Comment = testimonial.Comment;
            
            db.SaveChanges();
            return RedirectToAction("Index");   
        }
        




    }
}