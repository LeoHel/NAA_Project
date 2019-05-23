using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NAA.Data.IDAO
{
    public interface IApplicationDAO
    {
        IList<NAA.Data.Application> GetUniversityApplications(int uniID);
        void ChangeUniversityOffer(int appId, string offer);
        Application GetApplicationDetails(int appId);
        IList<NAA.Data.University> GetUniversities();
        void AddApplication(NAA.Data.Application application);
    }
}
