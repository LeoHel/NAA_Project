using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NAA.Data.IDAO;

namespace NAA.Data.DAO
{
    public class NaaDAO : INaaDAO
    {
        private NAAEntities _context;
        public NaaDAO()
        {
            _context = new NAAEntities();
        }

        public void EditProfile(Applicant applicant)
        {
            Applicant applic = GetCurrentProfile(applicant.Id);

            applic.ApplicantName = applicant.ApplicantName;
            applic.ApplicantAddress = applicant.ApplicantAddress;
            applic.Phone = applicant.Phone;
            applic.Email = applicant.Email;

            _context.SaveChanges();
        }
        
        public void CreateProfile(Applicant applicant)
        {
            _context.Applicant.Add(applicant);
            _context.SaveChanges();

        }
        
        
        
        public IList<Applicant> GetApplicant()
        {

            IQueryable<Applicant> _applicants;
            _applicants = from applicant
                          in _context.Applicant
                          select applicant;
            return _applicants.ToList<Applicant>();
        }

        public Applicant GetCurrentProfile(int id)
        {
            IQueryable<Applicant> _applicants;
            _applicants = from applicant
                          in _context.Applicant
                          select applicant;
            return _applicants.ToList<Applicant>().First();


        }

       
        



    }
}
