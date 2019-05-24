using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using NAA.Data;

namespace NAA.Controllers
{
    public class ApplicationsController : Controller
    {

        private NAA.Services.IService.INaaService _naaService;

        public ApplicationsController()
        {
            _naaService = new NAA.Services.Service.NaaService();
        }

        public ActionResult GetApplications(int id)
        {

            return View(_naaService.GetApplications(id));

        }


        // GET: Applications
        public ActionResult Index()
        {
            return View();
        }

        // GET: Applications/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Applications/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Applications/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Applications/Edit/5
        public ActionResult EditApplication(int id)
        {
            return View(_naaService.GetCurrentApplication(id));
        }

        // POST: Applications/Edit/5
        [HttpPost]
        public ActionResult EditApplication(Application application)
        {
            try
            {
                _naaService.EditApplication(application);
                return RedirectToAction("GetApplicant", new {Controller = "Profile" });
            }
            catch
            {
                return View();
            }
        }

        // GET: Applications/Delete/5
        [HttpGet]
        public ActionResult DeleteApplication(int id)
        {
            
            return View(_naaService.GetApplication(id));
        }

        // POST: Applications/Delete/5
        [HttpPost]
        public ActionResult DeleteApplication(Application application)
        {
            try
            {
                // TODO: Add delete logic here
                _naaService.DeleteApplication(application);
                return RedirectToAction("GetApplicant", new {controller = "Profile" });
            }
            catch
            {
                return View();
            }
        }
        public ActionResult ConfirmApplication(int appId, int userId)
        {
            if (!_naaService.GetFirmApplication(userId))
            {
                _naaService.ConfirmApplication(appId);
            }
            return RedirectToAction("GetApplications", new { id = userId });
        }
    }
}
