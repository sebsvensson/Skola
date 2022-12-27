using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grupp25_lab2
{
    interface ILärare
    {

        string LärarID { get; set; }
        void AvregistreraKurs(Kurs kurs);
        void Radera();
        string ToString();
        void RegistreraKurs(Kurs kurs);
    }
}