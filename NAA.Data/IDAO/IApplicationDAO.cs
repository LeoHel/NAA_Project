using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NAA.Data.IDAO
{
    public interface IApplicationDAO
    {
        IList<NAA.Data.BEANS.ApplicationBEAN> GetUniversityApplications(int uniID);
        void ChangeUniversityOffer(int appId, string offer);
        NAA.Data.BEANS.ApplicationBEAN GetApplicationDetails(int appId);
        IList<NAA.Data.University> GetUniversities();
        void AddApplication(NAA.Data.Application application);
    }
}
