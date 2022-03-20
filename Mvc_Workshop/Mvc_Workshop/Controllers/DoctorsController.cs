using Mvc_Workshop.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Mvc_Workshop.Controllers
{
    public class DoctorsController : Controller
    {
        HospitalContext hc = new HospitalContext();
        public ActionResult Index()
        {
            List<Doctor> Dlist = hc.Doctors.ToList();
            return View(Dlist);
        }

        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(Doctor dc)
        {
            if(ModelState.IsValid)
            {
                hc.Doctors.Add(dc);
                hc.SaveChanges();
                return RedirectToAction(nameof(Index));
                
            }
            return View();
        }
        [HttpGet]
        public ActionResult Delete(int id)
        {
            return View(hc.Doctors.Find(id));
        }

        [HttpPost, ActionName("Delete")]
        public ActionResult DeletePost(int id)
        {
            Doctor dc = hc.Doctors.Find(id);
            hc.Doctors.Remove(dc);
            hc.SaveChanges();
            return RedirectToAction(nameof(Index));
            //return View();
        }

        [HttpGet]
        public ActionResult Edit(int id)
        {
            return View(hc.Doctors.Find(id));
        }

        [HttpPost, ActionName("Edit")]
        public ActionResult EditPost(Doctor dc)
        {
            if (ModelState.IsValid)
            {
                hc.Entry(dc).State = EntityState.Modified;
                hc.SaveChanges();
                return RedirectToAction(nameof(Index));
            }
            return View(hc);
        }

        [HttpGet]
        public ActionResult Details(int id)
        {
            return View(hc.Doctors.Single(x => x.id == id));
        }


    }
}