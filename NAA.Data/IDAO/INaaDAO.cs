using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NAA.Data.IDAO
{
    public interface INaaDAO
    {
        IList<Applicant> GetApplicant();

        void EditProfile(Applicant applicant);

        Applicant GetCurrentProfile(int id);

        void CreateProfile(Applicant applicant);

        IList<Application> GetApplications(int id);

        void DeleteApplication(Application application);

        Application GetApplication(int id);

        void ConfirmApplication(int appId);
        Boolean ApplicantApplicationNumber(int appId);
        IList<string> GetUsedCourses(int appId);
        Boolean GetFirmApplication(int appId);


    };
}
