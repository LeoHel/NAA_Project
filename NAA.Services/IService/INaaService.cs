using NAA.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace NAA.Services.IService
{
    public interface INaaService
    {

        //void CreateProfile(Applicant applicant);
        
        IList<NAA.Data.Applicant> GetApplicant();

        void EditProfile(Applicant applicant);

        Applicant GetCurrentProfile(int id);

        void CreateProfile(Applicant applicant);

        IList<Application> GetApplications(int id);

        Application GetApplication(int id);

        void DeleteApplication(Application application);

        void ConfirmApplication(int appId);
        Boolean ApplicantApplicationNumber(int appId);
        IList<string> GetUsedCourses(int appId, int uniId);
        void EditApplication(Application application);
        Application GetCurrentApplication(int id);


        Boolean GetFirmApplication(int appId);
    }
}
