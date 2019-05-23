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
        
        
        



    }
}
