using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grupp25_lab2
{
    class Laborationsuppgift : ILaborationsuppgift
    {
        private readonly Databas databas = Databas.HämtaDatabas();

        private DateTime startdatum;
        public DateTime Startdatum
        {
            get { return startdatum; }
            set
            {
                startdatum = value;
            }
        }

        private DateTime slutdatum;
        public DateTime Slutdatum
        {
            get { return slutdatum; }
            set
            {
                slutdatum = value;
            }
        }

        private double poäng;
        public double Poäng
        {
            get { return poäng; }
            set
            {
                poäng = value;
            }
        }

        private string namn;
        public string Namn
        {
            get { return namn; }
            set
            {
                namn = value;
            }
        }

        private Kurs kurs;
        public Kurs Kurs_
        {
            get { return this.kurs; }
        }

        public string Kursnamn
        {
            get { return kurs.Namn; }
        }

        public List<Inlämning> inlämningar = new List<Inlämning>();

        public Laborationsuppgift(Kurs kurs, string namn, double poäng, DateTime startdatum, DateTime slutdatum)
        {
            this.kurs = kurs;
            this.Namn = namn;
            this.Poäng = poäng;
            this.Startdatum = startdatum;
            this.Slutdatum = slutdatum;
        }

        public Inlämning HittaInlämning(Student student, bool skapaUppgift)
        {
            for (int i = 0; i < this.inlämningar.Count; i++)
            {
                if (this.inlämningar[i].Student == student)
                    return this.inlämningar[i];
            }

            if (!skapaUppgift)
                return null;

            Inlämning inlämning = new Inlämning(this, student, DateTime.Now);

            this.databas.inlämningar.Add(inlämning);
            this.inlämningar.Add(inlämning);

            return inlämning;
        }

        public void LäggTillInlämning(Inlämning inlämning)
        {
            if (this.inlämningar.Contains(inlämning))
                return;

            this.databas.inlämningar.Add(inlämning);
            this.inlämningar.Add(inlämning);
        }

        public void TaBortInlämning(Inlämning inlämning)
        {
            this.databas.inlämningar.Remove(inlämning);
            this.inlämningar.Remove(inlämning);
        }
    }
}
