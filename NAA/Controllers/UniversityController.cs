﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace NAA.Controllers
{
    public class UniversityController : Controller
    {
        private Universities.Services.Service.UniversitiesService _UniversityService;

        public UniversityController()
        {
            _UniversityService = new Universities.Services.Service.UniversitiesService();
        }

        public ActionResult Courses()
        {
            return View(_UniversityService.GetSHCourses());
        }
        public ActionResult SHUCourses()
        {
            return View(_UniversityService.GetSHHCourses());
        }
        // GET: University
        public ActionResult Index()
        {
            return View();
        }
    }
}