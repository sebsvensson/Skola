using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grupp25_lab2
{
    abstract class Person : IPerson
    {
        private string personnummer;
        public string Personnummer
        {
            get { return personnummer; }
            set
            {
                personnummer = value;
            }
        }

        private string förnamn;
        public string Förnamn 
        { 
            get { return förnamn; } 
            set 
            { 
                förnamn = value; 
            }
        }

        private string efternamn;
        public string Efternamn
        {
            get { return efternamn; }
            set
            {
                efternamn = value;
            }
        }

        private string telefonnummer;
        public string Telefonnummer
        {
            get { return telefonnummer; }
            set
            {
                telefonnummer = value;
            }
        }
    }
}
