using MyEgitimAkademi.Portfolio.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MyEgitimAkademi.Portfolio.Controllers
{
    public class SkillController : Controller
    {
        MyPortfolioDbEntities1 db = new MyPortfolioDbEntities1();
        // GET: Skill

        [Authorize]
        public ActionResult Index()
        {
            var values=db.Skill.ToList();
            return View(values);
        }

        public ActionResult AddSkill()
        {
            return View();
        }
        [HttpPost]
        public ActionResult AddSkill(Skill skill)
        {
            db.Skill.Add(skill);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        public ActionResult DeleteSkill(int id)
        {
            var value = db.Skill.Find(id);

            db.Skill.Remove(value);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
        public ActionResult UpdateSkill(int id)  //id routetan geliyor.
        {
            var value = db.Skill.Find(id);
            return View(value);
        }
        [HttpPost]
        public ActionResult Updateskill(Skill skill)
        {
            var value = db.Skill.Find(skill.SkillID);

            value.SkillTitle = skill.SkillTitle;

            value.SkillValue = skill.SkillValue;


            db.SaveChanges();
            return RedirectToAction("Index");
        }


    }
}