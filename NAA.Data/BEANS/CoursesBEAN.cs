using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NAA.Data.BEANS
{
    public class CoursesBEAN
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string EntryReq { get; set; }
        public int Tarif { get; set; }
        public string University { get; set; }
        public int NSS { get; set; }
        public string Qualification { get; set; }

        public CoursesBEAN() { }
    }
}
