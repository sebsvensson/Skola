using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grupp25_lab2
{
    interface IPerson
    {
        string Förnamn { get; set; }
        string Efternamn { get; set; }
        string Telefonnummer { get; set; }
        string Personnummer { get; set; }
    }
}
