using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NAA.Data;
using NAA.Data.IDAO;
using NAA.Data.DAO;

namespace NAA.Services.Service
{
    public class NaaService : NAA.Services.IService.INaaService
    {
        private INaaDAO _applicantDAO;

        public NaaService()
        {
            _applicantDAO = new NaaDAO();
        }

        public void CreateProfile(Applicant applicant)
        {
            _applicantDAO.CreateProfile(applicant);
        }

        public IList<Applicant> GetApplicant()
        {
            return _applicantDAO.GetApplicant();
        }

        public Applicant GetCurrentProfile(int id)
        {
            return _applicantDAO.GetCurrentProfile(id);
        }



        public void EditProfile ( Applicant applicant)
        {
            _applicantDAO.EditProfile(applicant);
        }
        
        public IList<Application> GetApplications(int id)
        {
            return _applicantDAO.GetApplications(id);
        }
        public Application GetApplication(int id)
        {
            return _applicantDAO.GetApplication(id);
        }


        public void DeleteApplication(Application application)
        {
            _applicantDAO.DeleteApplication(application);
        }

        public void ConfirmApplication(int appId)
        {
            _applicantDAO.ConfirmApplication(appId);
        }

        public Boolean ApplicantApplicationNumber(int appId)
        {
           return _applicantDAO.ApplicantApplicationNumber(appId);
        }

        public IList<string> GetUsedCourses(int appId)
        {
            return _applicantDAO.GetUsedCourses(appId);
        }

        public Boolean GetFirmApplication(int appId)
        {
            return _applicantDAO.GetFirmApplication(appId);
        }

    }
}
