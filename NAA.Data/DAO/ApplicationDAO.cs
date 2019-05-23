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
        public void ChangeUniversityOffer(int appId, string offer)
        {
            IQueryable<Application> _application;
            _application = from applications
                           in _context.Application
                           where applications.Id == appId
                           select applications;
            Application _app = _application.ToList<Application>().First();
            _app.UniversityOffer = offer;
            _context.SaveChanges();
        }
        public Application GetApplicationDetails(int appId)
        {
            IQueryable<Application> _app;
            _app = from apps
                   in _context.Application
                   where apps.Id == appId
                   select apps;
            return _app.ToList<Application>().First();
        }
    }
}
