using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NAA.Data;
using NAA.Data.IDAO;
using NAA.Data.DAO;
using NAA.Data.BEANS;

namespace NAA.Services.Service
{
    public class ApplicationService : NAA.Services.IService.IApplicationService
    {
        private IApplicationDAO _applicationDAO;
        public ApplicationService()
        {
            _applicationDAO = new ApplicationDAO();
        }
        public IList<Application> GetUniversityApplications(int uniID)
        {
            return _applicationDAO.GetUniversityApplications(uniID);
        }
        public void ChangeUniversityOffer(int appId, string offer)
        {
            _applicationDAO.ChangeUniversityOffer(appId, offer);
        }
        public Application GetApplicationDetails(int appId)
        {
            return _applicationDAO.GetApplicationDetails(appId);
        }
    }
}
