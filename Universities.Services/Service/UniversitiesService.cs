using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Universities.Services.IService;
using Universities.Services.Sheffield;
using Universities.Services.Sheffield_Hallam;
using Universities;

namespace Universities.Services.Service
{
    public class UniversitiesService : IUniversitiesService
    {

        //private UniversitiesWebService.UniversitiesWebService _proxy;
        private Sheffield.SheffieldWebService _proxy;
        private Sheffield_Hallam.SHUWebService _proxy2;

        public UniversitiesService(){
            _proxy = new Sheffield.SheffieldWebService();
            _proxy2 = new Sheffield_Hallam.SHUWebService();
        }

        public IList<Course> GetSHCourses()
        {
            IList<Course> _output = _proxy.SheffCourses().ToList();
            return _output;
        }

        public IList<SHUCourse> GetSHHCourses()
        {
            IList<SHUCourse> _output = _proxy2.SHUCourses().ToList();
            return _output;
        }


    //    public IList<NAA.Data.BEANS.CoursesBEAN> getCourses(int Id)
    //    {
    //        List<NAA.Data.BEANS.CoursesBEAN> _bean = new List<NAA.Data.BEANS.CoursesBEAN>();
    //        if (Id == 1)
    //        {
    //            IList<Course> _output = _proxy.SheffCourses().ToList();
    //            foreach (var output in _output)
    //            {

    //            }
    //}
    //    }
    }
}
