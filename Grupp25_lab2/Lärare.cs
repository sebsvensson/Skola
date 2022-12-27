using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grupp25_lab2
{
    class Lärare : Person, ILärare
    {
        private static readonly Databas databas = Databas.HämtaDatabas();

        private string lärarID;
        public string LärarID
        {
            get { return lärarID; }
            set
            {
                lärarID = value;
            }
        }

        private List<Kurs> kurser = new List<Kurs>();

        public Lärare(string LärarID, string personnummer, string förnamn, string efternamn, string telefonnummer)
        {
            this.LärarID = LärarID;
            this.Förnamn = förnamn;
            this.Efternamn = efternamn;
            this.Telefonnummer = telefonnummer;
            this.Personnummer = personnummer;
        }

        public static void PopulateLärare()
        {
            databas.lärare.Add(new Lärare("L134602", "19750817-9582", "Bo", "Skarsgård", "0739723380"));
            databas.lärare.Add(new Lärare("L1789456", "19730201-2039", "Pär", "Svensson", "0705647123"));
            databas.lärare.Add(new Lärare("L876045", "18880701-6319", "Britt-Marie", "Hjalmarsson", "0726523380"));
            databas.lärare.Add(new Lärare("L234567", "18380106-8622", "Gunvor", "Robertsson", "0739653680"));
            databas.lärare.Add(new Lärare("L356890", "19700922-3178", "Engelnreckt", "Andersson", "0737803345"));
        }

        public static void SkapaLärare(string LärarID, string personnummer, string förnamn, string efternamn, string telefonnummer)
        {
            databas.lärare.Add(new Lärare(LärarID, personnummer, förnamn, efternamn, telefonnummer));
        }

        public void Radera()
        {
            for (int i = 0; i < this.kurser.Count; i++)
                this.kurser[i].AvregistreraLärare(this);

            databas.lärare.Remove(this);
        }

        public override string ToString()
        {
            return string.Format("{0} {1} ({2})", this.Förnamn, this.Efternamn, this.lärarID);
        }

        public void AvregistreraKurs(Kurs kurs)
        {
            this.kurser.Remove(kurs);
        }

        public void RegistreraKurs(Kurs kurs)
        {
            if (this.kurser.Contains(kurs))
                return;

            this.kurser.Add(kurs);
        }
    }
}
