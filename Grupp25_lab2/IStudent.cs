using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grupp25_lab2
{
    interface IStudent
    {
        string StudentID { get; set; }
        List<Laborationsuppgift> Uppgifter { get; }

        void RegistreraKurs(Kurs kurs);
        void AvregistreraKurs(Kurs kurs);
        void LäggTillLaborationsuppgift(Laborationsuppgift laborationsuppgift);
        void TaBortStudent();
    }
}
