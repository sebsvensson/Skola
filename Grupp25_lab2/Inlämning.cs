using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grupp25_lab2
{
    class Inlämning : IInlämning
    {
        private string betyg;
        private DateTime inlämningstid;
        private Student student;
        private Laborationsuppgift laborationsuppgift;

        public Student Student
        {
            get { return this.student; }
        }

        public Laborationsuppgift Laborationsuppgift_
        {
            get { return this.laborationsuppgift; }
        }

        public DateTime Inlämningstid
        {
            get { return this.inlämningstid; }
        }

        public string Betyg
        {
            get { return this.betyg; }
            set { this.betyg = value; }
        }

        public Inlämning(Laborationsuppgift laborationsuppgift, Student student, DateTime inlämningstid)
        {
            this.inlämningstid = inlämningstid;
            this.laborationsuppgift = laborationsuppgift;
            this.student = student;
        }
    }
}
