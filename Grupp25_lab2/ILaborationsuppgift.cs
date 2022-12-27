using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grupp25_lab2
{
    interface ILaborationsuppgift
    {
        string Kursnamn { get; }
        Kurs Kurs_ { get; }
        DateTime Startdatum { get; set; }
        DateTime Slutdatum { get; set; }
        double Poäng { get; set; }
        string Namn { get; set; }
        Inlämning HittaInlämning(Student student, bool skapaUppgift);
        void LäggTillInlämning(Inlämning inlämning);
        void TaBortInlämning(Inlämning inlämning);
    }
}