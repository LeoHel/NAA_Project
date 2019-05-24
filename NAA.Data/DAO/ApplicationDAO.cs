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
        public IList<NAA.Data.BEANS.ApplicationBEAN> GetUniversityApplications(int uniID)
        {
            IQueryable<ApplicationBEAN> _applications;
            _applications = from applications
                            in _context.Application
                            where applications.UniversityId == uniID
                            select new ApplicationBEAN
                            {
                                Id = applications.Id,
                                ApplicantName = (from _apps in _context.Application
                                                from _appl in _context.Applicant
                                                where _apps.ApplicantId == _appl.Id
                                                select _appl.ApplicantName).FirstOrDefault(),
                                CourseName = applications.CourseName,
                                PersonalStatement = applications.PersonalStatement,
                                TeacherReference = applications.TeacherReference,
                                TeacherContactDetails = applications.TeacherContactDetails,
                                UniversityOffer = applications.UniversityOffer,
                                Firm = applications.Firm
                            };
            return _applications.ToList<ApplicationBEAN>();
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
        public ApplicationBEAN GetApplicationDetails(int appId)
        {
            IQueryable<ApplicationBEAN> _app;
            _app = from applications
                            in _context.Application
                   where applications.Id == appId
            select new ApplicationBEAN
            {
                Id = applications.Id,
                ApplicantName = (from _apps in _context.Application
                                 from _appl in _context.Applicant
                                 where _apps.ApplicantId == _appl.Id
                                 select _appl.ApplicantName).FirstOrDefault(),
                CourseName = applications.CourseName,
                PersonalStatement = applications.PersonalStatement,
                TeacherReference = applications.TeacherReference,
                TeacherContactDetails = applications.TeacherContactDetails,
                UniversityOffer = applications.UniversityOffer,
                Firm = applications.Firm
            };
            return _app.ToList<ApplicationBEAN>().First();
        }
        public IList<NAA.Data.University> GetUniversities()
        {
            IQueryable<University> _uni;
            _uni = from uni
                   in _context.University
                   select uni;
            return _uni.ToList<University>();
        }
        public void AddApplication(NAA.Data.Application application)
        {
            Application app = new Application();
            app.ApplicantId = application.ApplicantId;
            app.CourseName = application.CourseName;
            app.Firm = application.Firm;
            app.Id = application.Id;
            app.PersonalStatement = application.PersonalStatement;
            app.TeacherContactDetails = application.TeacherContactDetails;
            app.TeacherReference = application.TeacherReference;
            app.UniversityId = application.UniversityId;
            app.UniversityOffer = application.UniversityOffer;
            _context.Application.Add(app);
            _context.SaveChanges();
        }
    }
}
