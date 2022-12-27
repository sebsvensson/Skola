using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grupp25_lab2
{
    class Databas
    {
        private static Databas databas;

        public static Databas HämtaDatabas()
        {
            if (databas == null)
                databas = new Databas();

            return databas;
        }

        private Databas() { }

        public List<Kurs> kurser = new List<Kurs>();
        public List<Student> studenter = new List<Student>();
        public List<Lärare> lärare = new List<Lärare>();
        public List<Laborationsuppgift> laborationsuppgifter = new List<Laborationsuppgift>();
        public List<Inlämning> inlämningar = new List<Inlämning>();
    }
}
