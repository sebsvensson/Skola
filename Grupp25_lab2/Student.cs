using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grupp25_lab2
{
    class Student : Person, IStudent
    {
        private static readonly Databas databas = Databas.HämtaDatabas();

        public static void PopulateStudenter()
        {
            databas.studenter.Add(new Student("S195202", "19430714-6383", "Mirwais", "Hotaki", "0739723380"));
            databas.studenter.Add(new Student("S123456", "19981004-9610", "Gunnar", "Göransson", "0705647123"));
            databas.studenter.Add(new Student("S136892", "19770102-4353", "Sebbe", "Hejsansson", "0726523380"));
            databas.studenter.Add(new Student("S186502", "19630323-5599", "Gunilla", "Valkov", "0739653680"));
            databas.studenter.Add(new Student("S179702", "19990804-1478", "Ludvig", "Olofsson", "0737803345"));
        }

        public static void SkapaStudent(string studentID, string personnummer, string förnamn, string efternamn, string telefonnummer)
        {
            databas.studenter.Add(new Student(studentID, personnummer, förnamn, efternamn, telefonnummer));
        }

        private string studentID;
        public string StudentID
        {
            get { return studentID; }
            set
            {
                studentID = value;
            }
        }

        public List<Laborationsuppgift> Uppgifter
        {
            get
            {
                List<Laborationsuppgift> uppgifter = new List<Laborationsuppgift>();
                
                foreach (Kurs kurs in kurser)
                    foreach (Laborationsuppgift upg in kurs.laborationsuppgifter)
                        uppgifter.Add(upg);

                return uppgifter;
            }
        }

        private List<Kurs> kurser = new List<Kurs>();
        private List<Laborationsuppgift> laborationsuppgifter = new List<Laborationsuppgift>();

        public Student(string studentID, string personnummer, string förnamn, string efternamn, string telefonnummer)
        {
            this.StudentID = studentID;
            this.Förnamn = förnamn;
            this.Efternamn = efternamn;
            this.Telefonnummer = telefonnummer;
            this.Personnummer = personnummer;
        }

        public void TaBortStudent()
        {
            // Radera studenten från databasen
            databas.studenter.Remove(this);

            // Avregistrera från alla kurser
            for (int i = this.kurser.Count - 1; i > -1; i--)
                this.kurser[i].AvregistreraStudent(this);
        }

        public void RegistreraKurs(Kurs kurs)
        {
            if (kurser.Contains(kurs))
                return;

            kurser.Add(kurs);
        }

        public void AvregistreraKurs(Kurs kurs)
        {
            kurser.Remove(kurs);
        }

        public void LäggTillLaborationsuppgift(Laborationsuppgift laborationsuppgift)
        {
            if (this.laborationsuppgifter.Contains(laborationsuppgift))
                return;

            this.laborationsuppgifter.Add(laborationsuppgift);
        }

        public override string ToString()
        {
           return string.Format("{0} {1} ({2})", this.Förnamn, this.Efternamn, this.studentID);
        }

    }
} 
