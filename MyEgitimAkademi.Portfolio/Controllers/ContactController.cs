﻿using MyEgitimAkademi.Portfolio.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MyEgitimAkademi.Portfolio.Controllers
{
    public class ContactController : Controller
    {
        // GET: Contact

        MyPortfolioDbEntities1 db=new MyPortfolioDbEntities1();

        [Authorize]
        public ActionResult Index()
        {
            ViewBag.description=db.Address.Select(x => x.Description).FirstOrDefault();
            ViewBag.phone=db.Address.Select(x=>x.Phone).FirstOrDefault();   
            ViewBag.addressDetail=db.Address.Select(x=>x.AddressDetail).FirstOrDefault();
            ViewBag.mail=db.Address.Select(x=>x.Mail).FirstOrDefault(); 


            return View();
        }
        [HttpPost]
        public ActionResult Index(Contact contact)
        {
            db.Contact.Add(contact);
            db.SaveChanges();

            return RedirectToAction("Index","Default");
        }

        public PartialViewResult PartialScript()
        {
            return PartialView();
        }
    }
}