using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Universities.Services.IService
{
    interface IUniversitiesService
    {
        IList<NAA.Data.BEANS.CoursesBEAN> GetCoursesForUniversity(int universityId);

        //IList<Sheffield.Course> GetSHCourses();

        //IList<Sheffield_Hallam.SHUCourse> GetSHHCourses();
    }
}
