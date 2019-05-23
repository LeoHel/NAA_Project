using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NAA.Data.BEANS;

namespace NAA.Data.DAO
{
    public class ApplicationDAO : NAA.Data.IDAO.IApplicationDAO
    {
        private NAAEntities _context;
        public ApplicationDAO()
        {
            _context = new NAAEntities();
        }
        public IList<NAA.Data.Application> GetUniversityApplications(int uniID)
        {
            IQueryable<Application> _applications;
            _applications = from applications
                            in _context.Application
                            where applications.UniversityId == uniID
                            select applications;
            return _applications.ToList<Application>();
        }
        public void ChangeUniversityOffer(int appId, char offer)
        {

        }
    }
}
