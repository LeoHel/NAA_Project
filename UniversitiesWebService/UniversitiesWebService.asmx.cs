using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using NAA.Data;
using NAA.Services;
//using NAA.Services.Service;
//using Universities.Services;
//using Universities.Services.Service;
//using Universities.Services.Sheffield;

namespace UniversitiesWebService
{
    /// <summary>
    /// Zusammenfassungsbeschreibung für ForestWebService
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // Wenn der Aufruf dieses Webdiensts aus einem Skript zulässig sein soll, heben Sie mithilfe von ASP.NET AJAX die Kommentarmarkierung für die folgende Zeile auf. 
    // [System.Web.Script.Services.ScriptService]
    public class UniversitiesWebService : System.Web.Services.WebService
    {
        //private Universities.Services.Service.UniversitiesService _universityService;

        //public UniversitiesWebService()
        //{
        //    _universityService = new Universities.Services.Service.UniversitiesService();
            
        //}

        [WebMethod]
        public string HelloWorld()
        {
            return "Hello World";
        }

        //[WebMethod]
        //public List<Universities.Services.Sheffield.Course> GetCourses()
        //{
        //   // List<NAA.Data.Courses.Courses> _newList = new List<_universityService.(_universityService.GetSHCourses());

        //    //List<Universities.Services.Sheffield.Course> _newList = new List<Universities.Services.Sheffield.Course>(_universityService.GetSHCourses());
        //    //List<NAA.Data.Courses.Courses> _newList = new List<NAA.Data.Courses.Courses> _universityService.G
        //    //return _newList;
        //}
    }
}
