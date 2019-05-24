using System;
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
        private NAA.Services.IService.INaaService _naaService;
        public ApplicationController()
        {
            _applicationService = new NAA.Services.Service.ApplicationService();
            _naaService = new NAA.Services.Service.NaaService();
        }
        public ActionResult StartApplication(int applicantId)
        {
            if (_naaService.ApplicantApplicationNumber(applicantId))
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
            return RedirectToAction("GetApplicant", new { Controller = "Profile" });
            
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



            IList<string> courses = _naaService.GetUsedCourses(applicantId, universityId);
            IList<NAA.Data.BEANS.CoursesBEAN> coursesUni = _universitiesService.GetCoursesForUniversity(universityId);

            IList<string> coursesUniString = new List<string>();
            foreach (var cours in coursesUni)
            {
                coursesUniString.Add(cours.Name);
            }
                IEnumerable<string> free;
            free = coursesUniString.Except(courses);


                foreach (var course in free)
                {
                    courseList.Add(
                        new SelectListItem()
                        {
                            Text = course,
                            Value = course
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
