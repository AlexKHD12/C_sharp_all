using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _001_Vizsga
{
    public class Allat
    {
        protected string nev;

        public Allat(string nev)
        {
            this.nev = nev;
        }

        public override string ToString()
        {
            return GetType().Name[0] + " " + nev; 
        }
    }
}
