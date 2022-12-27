using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grupp25_lab2
{
    class Kurs : IKurs
    {
        private static readonly Databas databas = Databas.HämtaDatabas();
        public static void SkapaKurs(string namn, string kurskod, DateTime startdatum, DateTime slutdatum)
        {
            databas.kurser.Add(new Kurs(namn, kurskod, startdatum, slutdatum));
        }

        public static void PopulateKurser()
        {
            SkapaKurs("Informationsdesign", "NID021", DateTime.Now.Date, DateTime.Now.Date);
            SkapaKurs("Systemanalys och design", "21SD1A", DateTime.Now.Date, DateTime.Now.Date);
            SkapaKurs("Interaktionsdesign", "21ID2B", DateTime.Now.Date, DateTime.Now.Date);
            SkapaKurs("Webbdesign", "NWD011", DateTime.Now.Date, DateTime.Now.Date);
            SkapaKurs("Introduktion till programmering med C#", "NGC011", DateTime.Now.Date, DateTime.Now.Date);
            SkapaKurs("Databasteknik", "NDA01G", DateTime.Now.Date, DateTime.Now.Date);

            for (int i = 0; i < databas.kurser.Count; i++)
            {
                databas.kurser[i].PopulateKurs();
            }
        }

        public void PopulateKurs()
        {
            RegistreraLaborationsuppgift("Laboration 1", 7.5, DateTime.Now.Date, DateTime.Now.Date);
            RegistreraLaborationsuppgift("Laboration 2", 7.5, DateTime.Now.Date, DateTime.Now.Date);
            RegistreraLaborationsuppgift("Laboration 3", 7.5, DateTime.Now.Date, DateTime.Now.Date);
            RegistreraLaborationsuppgift("Laboration 4", 3.5, DateTime.Now.Date, DateTime.Now.Date);
            RegistreraLaborationsuppgift("Laboration 5", 0.5, DateTime.Now.Date, DateTime.Now.Date);
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

        private string kurskod;
        public string Kurskod
        {
            get { return kurskod; }
            set
            {
                kurskod = value;
            }
        }

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

        public List<Laborationsuppgift> laborationsuppgifter = new List<Laborationsuppgift>();

        private List<Lärare> registreradeLärare = new List<Lärare>();
        private List<Student> registreradeStudenter = new List<Student>();

        public Kurs(string namn, string kurskod, DateTime startdatum, DateTime slutdatum)
        {
            this.Namn = namn;
            this.Kurskod = kurskod;
            this.Startdatum = startdatum;
            this.Slutdatum = slutdatum;
        }

        public void Radera()
        {
            // Radera kursen
            databas.kurser.Remove(this);

            // Avregistrera alla lärare
            for (int i = 0; i < this.registreradeLärare.Count; i++)
                this.registreradeLärare[i].AvregistreraKurs(this);

            // Avregistrera alla studenter
            for (int i = 0; i < this.registreradeStudenter.Count; i++)
                this.registreradeStudenter[i].AvregistreraKurs(this);

            // Radera alla laborationsuppgifter
            for (int i = 0; i < this.laborationsuppgifter.Count; i++)
                this.laborationsuppgifter[i].inlämningar.Clear();
            this.laborationsuppgifter.Clear();
        }

        public void RegistreraLärare(Lärare lärare)
        {
            if (LärareRegistrerad(lärare))
                return;

            this.registreradeLärare.Add(lärare);
            lärare.RegistreraKurs(this);
        }

        public void AvregistreraLärare(Lärare lärare)
        {
            this.registreradeLärare.Remove(lärare);
            lärare.AvregistreraKurs(this);
        }

        public bool LärareRegistrerad(Lärare lärare)
        {
            return registreradeLärare.Contains(lärare);
        }

        public void RegistreraStudent(Student student)
        {
            if (StudentRegistrerad(student))
                return;

            this.registreradeStudenter.Add(student);
            student.RegistreraKurs(this);
        }
        public void AvregistreraStudent(Student student)
        {
            // Avregistrera studenten
            this.registreradeStudenter.Remove(student);
            student.AvregistreraKurs(this);

            // Radera alla inlämningar av studenten
            for (int i = 0; i < this.laborationsuppgifter.Count(); i++)
                for (int j = this.laborationsuppgifter[i].inlämningar.Count - 1; j > -1; j--)
                    if (this.laborationsuppgifter[i].inlämningar[j].Student == student)
                        this.laborationsuppgifter[i].inlämningar.RemoveAt(j);
        }
        public bool StudentRegistrerad(Student student)
        {
            return registreradeStudenter.Contains(student);
        }
        public void RegistreraLaborationsuppgift(string namn, double poäng, DateTime startdatum, DateTime slutdatum)
        {
            Laborationsuppgift laborationsuppgift = new Laborationsuppgift(this, namn, poäng, startdatum, slutdatum);
            this.laborationsuppgifter.Add(laborationsuppgift);
            databas.laborationsuppgifter.Add(laborationsuppgift);
        }

        public void AvregistreraLaborationsuppgift(Laborationsuppgift laborationsuppgift)
        {
            databas.laborationsuppgifter.Remove(laborationsuppgift);
            this.laborationsuppgifter.Remove(laborationsuppgift);
        }
    }
}
