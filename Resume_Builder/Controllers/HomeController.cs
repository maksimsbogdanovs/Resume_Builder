using Resume_Builder.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using System;

namespace Resume_Builder.Controllers
{
    public class HomeController : Controller
    {
        [Route("/")]
        public ActionResult Home()
        {
            return View();
        }


        public ActionResult List()
        {
            List<ResumeModel> resumes = new List<ResumeModel>();
            using (var db = new ResumeContext())
            {
                resumes = db.Resumes.ToList();
            }

            ViewBag.resumes = resumes;

            return View("List");
        }


        public ActionResult CreateResume()
        {

            return View();
        }


        
        public ActionResult Display(ResumeModel resume)
        {
            using (var db = new ResumeContext())
            {
                var disTemp = db.Resumes.Where(u => u.Id == resume.Id).FirstOrDefault();
                TempData["disTemp"] = disTemp;
            }
            return View();
        }


        public ActionResult ResumeDisplay(ResumeModel resume)
        {

            using (var db = new ResumeContext())
            {
                var display = db.Resumes.Where(u => u.Id == resume.Id).FirstOrDefault();

                display.Name = resume.Name;
                display.Surname = resume.Surname;
                display.Email = resume.Email;
                display.Phone = resume.Phone;
                display.Adress = resume.Adress;
                display.City = resume.City;
                display.Country = resume.Country;
                display.Indexx = resume.Indexx;
                display.University = resume.University;
                display.Study = resume.Study;
                display.Degree = resume.Degree;
                display.StudyTimeFrom = resume.StudyTimeFrom;
                display.StudyTimeTo = resume.StudyTimeTo;
                display.Job = resume.Name;
                display.Title = resume.Title;
                display.Description = resume.Description;
                display.WorkTimeFrom = resume.WorkTimeFrom;
                display.WorkTimeTo = resume.WorkTimeTo;
            }

            return View();
        }


        [HttpPost]
        public ActionResult CreateResume(ResumeModel resume )
        {
            if (ModelState.IsValid)
            {
                using (var db = new ResumeContext())
                {
                    db.Add(resume);
                    db.SaveChanges();
                }
            }

            return RedirectToAction("List");
        }

        [HttpPost]
        public ActionResult UpdateResume(ResumeModel resume)
        {

            using (var db = new ResumeContext())
            {
                var resTemp = db.Resumes.Where(u => u.Id == resume.Id).FirstOrDefault();

                TempData["resTemp"] = resTemp;
            }
                return View();
        }

        public ActionResult ResumeUpdate(ResumeModel resume)
        {

            using (var db = new ResumeContext())
            {
                var UpdateResume = db.Resumes.Where(u => u.Id == resume.Id).FirstOrDefault();

                UpdateResume.Name = resume.Name;
                UpdateResume.Surname = resume.Surname;
                UpdateResume.Email = resume.Email;
                UpdateResume.Phone = resume.Phone;
                UpdateResume.Adress = resume.Adress;
                UpdateResume.City = resume.City;
                UpdateResume.Country = resume.Country;
                UpdateResume.Indexx = resume.Indexx;
                UpdateResume.University = resume.University;
                UpdateResume.Study = resume.Study;
                UpdateResume.Degree = resume.Degree;
                UpdateResume.StudyTimeFrom = resume.StudyTimeFrom;
                UpdateResume.StudyTimeTo = resume.StudyTimeTo;
                UpdateResume.Job = resume.Name;
                UpdateResume.Title = resume.Title;
                UpdateResume.Description = resume.Description;
                UpdateResume.WorkTimeFrom = resume.WorkTimeFrom;
                UpdateResume.WorkTimeTo = resume.WorkTimeTo;

                db.SaveChanges();
            }

           return RedirectToAction("List");
        }

        
        public ActionResult DeleteResume(ResumeModel resume)
        {
            using (var db = new ResumeContext())
            {
                var resumes = db.Resumes.Where(u => u.Name == resume.Name).FirstOrDefault();

                db.Remove(resume);
                db.SaveChanges();
            }
            return RedirectToAction("List");
        }

    }
}
