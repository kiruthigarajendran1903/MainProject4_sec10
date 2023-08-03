using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace MainProject4_Sec10
{
    public class Teacher
    {
        public string Name { get; set; }
        public string ClassAndSection { get; set; }
        public List<Subject> SubjectsTaught { get; set; }

        public Teacher()
        {
            SubjectsTaught = new List<Subject>();
        }
    }
}
