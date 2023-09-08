using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MyEgitimAkademi.Portfolio.Controllers
{
    public class EducationController : Controller
    {
        [Authorize]
        // GET: Education
        public ActionResult Index()
        {
            return View();
        }
    }
}