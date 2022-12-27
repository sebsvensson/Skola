using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grupp25_lab2
{
    interface IInlämning
    {
        DateTime Inlämningstid { get; }
        string Betyg { get; set; }
    }
}
