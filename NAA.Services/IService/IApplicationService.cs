using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NAA.Data;
using NAA.Data.IDAO;
using NAA.Data.DAO;
using NAA.Data.BEANS;

namespace NAA.Services.IService
{
    public interface IApplicationService
    {
        IList<NAA.Data.BEANS.ApplicationBEAN> GetUniversityApplications(int uniID);
        void ChangeUniversityOffer(int appId, string offer);
        ApplicationBEAN GetApplicationDetails(int appId);
        IList<NAA.Data.University> GetUniversities();
        void AddApplication(NAA.Data.Application application);
    }
}
