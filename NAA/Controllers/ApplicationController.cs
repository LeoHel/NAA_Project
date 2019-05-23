﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using NAA.Data;

namespace NAA.Controllers
{
    public class ApplicationController : Controller
    {
        private NAA.Services.IService.IApplicationService _applicationService;
        public ApplicationController()
        {
            _applicationService = new NAA.Services.Service.ApplicationService();
        }
        public ActionResult StartApplication(int applicantId)
        {
            List<SelectListItem> universityList = new List<SelectListItem>();
            foreach (var uni in _applicationService.GetUniversities())
            {
                universityList.Add(
                    new SelectListItem()
                    {
                        Text = uni.UniversityName,
                        Value = uni.UniversityId.ToString()
                    });
            }
            ViewBag.universityList = universityList;
            return View();
        }
        [HttpPost]
        public ActionResult StartApplication(NAA.Data.Application application)
        {
            return RedirectToAction("AddApplication", new { applicantId = application.ApplicantId, universityId = application.UniversityId });
        }
        public ActionResult AddApplication(int applicantId, int universityId)
        {
            Universities.Services.Service.UniversitiesService _universitiesService = new Universities.Services.Service.UniversitiesService();
            List<SelectListItem> courseList = new List<SelectListItem>();
            
            
                foreach (var course in _universitiesService.GetCoursesForUniversity(universityId))
                {
                    courseList.Add(
                        new SelectListItem()
                        {
                            Text = course.Name,
                            Value = course.Name,
                        });
                }
                ViewBag.courseList = courseList;
                return View();
        }
        [HttpPost]
        public ActionResult AddApplication(NAA.Data.Application application)
        {
            try
            {
                _applicationService.AddApplication(application);
                return RedirectToAction("GetApplications", new { id = application.ApplicantId, Controller = "Applications" });
            }
            catch
            {
                return View();
            }
        }
    }
}