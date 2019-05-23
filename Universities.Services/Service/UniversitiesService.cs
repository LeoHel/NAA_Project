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
        private Sheffield.SheffieldWebService _sheffieldProxy;
        private Sheffield_Hallam.SHUWebService _shuProxy;

        public UniversitiesService(){
            _sheffieldProxy = new Sheffield.SheffieldWebService();
            _shuProxy = new Sheffield_Hallam.SHUWebService();
        }

        //public IList<Course> GetSHCourses()
        //{
        //    IList<Course> _output = _proxy.SheffCourses().ToList();
        //    return _output;
        //}

        //public IList<SHUCourse> GetSHHCourses()
        //{
        //    IList<SHUCourse> _output = _proxy2.SHUCourses().ToList();
        //    return _output;
        //}


        public IList<NAA.Data.BEANS.CoursesBEAN> GetCoursesForUniversity(int universityId)
        {
            List<NAA.Data.BEANS.CoursesBEAN> _beans = new List<NAA.Data.BEANS.CoursesBEAN>();
            if (universityId == 1)
            {
                IList<Course> _output = _sheffieldProxy.SheffCourses().ToList();
                foreach (var output in _output)
                {
                    NAA.Data.BEANS.CoursesBEAN _bean = new NAA.Data.BEANS.CoursesBEAN();
                    _bean.Id = output.Id;
                    _bean.Name = output.Name;
                    _bean.Description = output.Description;
                    _bean.EntryReq = output.EntryReq;
                    _bean.Tarif = output.Tarif.ToString();
                    _bean.University = output.University;
                    _bean.NSS = output.NSS.ToString();
                    _bean.Qualification = output.Qualification;
                    _beans.Add(_bean);
                }
                return _beans;
            } else if (universityId == 2)
            {
                IList<SHUCourse> _output = _shuProxy.SHUCourses().ToList();
                foreach (var output in _output)
                {
                    NAA.Data.BEANS.CoursesBEAN _bean = new NAA.Data.BEANS.CoursesBEAN();
                    _bean.Id = output.CourseId;
                    _bean.Name = output.CName;
                    _bean.Description = output.CDescription;
                    _bean.EntryReq = output.CRequirements;
                    _bean.Tarif = output.CTarif;
                    _bean.University = "Sheffield Hallam";
                    _bean.NSS = output.CNSS;
                    _bean.Qualification = output.CDegree;
                    _beans.Add(_bean);
                }
                return _beans;
            }
            else
            {
                return null;
            }
        }
    }
}
