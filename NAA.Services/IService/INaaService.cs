using NAA.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace NAA.Services.IService
{
    public interface INaaService
    {

        //void CreateProfile(Applicant applicant);
        
        IList<NAA.Data.Applicant> GetApplicant();

        void EditProfile(Applicant applicant);

        Applicant GetCurrentProfile(int id);

    }
}
