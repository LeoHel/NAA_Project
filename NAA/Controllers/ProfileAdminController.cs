using NAA.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace NAA.Controllers
{
    public class ProfileAdminController : Controller
    {

        private NAA.Services.IService.INaaService _naaService;

        public ProfileAdminController()
        {
            _naaService = new NAA.Services.Service.NaaService();
        }
        
        
        // GET: ProfileAdmin
        public ActionResult Index()
        {
            return View();
        }

        // GET: ProfileAdmin/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: ProfileAdmin/Create
        public ActionResult CreateProfile(string name)
        {

            return View();

        }

        // POST: ProfileAdmin/Create
        [HttpPost]
        public ActionResult CreateProfile(Applicant applicant)
        {
            try
            {
                // TODO: Add insert logic here
                _naaService.CreateProfile(applicant);
                return RedirectToAction("GetApplicant", new {Controller = "Profile"});
            }
            catch
            {
                return View();
            }
        }

        // GET: ProfileAdmin/Edit/5
        public ActionResult EditProfile(int id)
        {
            return View(_naaService.GetCurrentProfile(id));

        }

        // POST: ProfileAdmin/Edit/5
        [HttpPost]
        public ActionResult EditProfile(int id, Applicant applicant)
        {
            try
            {
                // TODO: Add update logic here
                _naaService.EditProfile(applicant);
                return RedirectToAction("GetApplicant", new { id = applicant.Id, Controller = "Profile" });
            }
            catch
            {
                return View();
            }
        }

        // GET: ProfileAdmin/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: ProfileAdmin/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
