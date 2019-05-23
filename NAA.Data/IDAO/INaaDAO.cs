using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NAA.Data.IDAO
{
    public interface INaaDAO
    {
        IList<Applicant> GetApplicant();

        void EditProfile(Applicant applicant);

        Applicant GetCurrentProfile(int id);

        //void CreateProfile(Applicant applicant);





    };
}
