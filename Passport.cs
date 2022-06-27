using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace paperplease_visual
{
    public class Passport
    {
        public List<string> errorsStrings { get; set; }
        public string birth { get; set; }
        public string fname { get; set; }
        public string mname { get; set; }
        public string lname { get; set; }
        public string city { get; set; }
        public Passport(string Birth, string Fname, string Mname, string Lname, string City)
        {
            birth = Birth;
            fname = Fname;
            mname = Mname;
            lname = Lname;
            city = City;
        }
    }
}
