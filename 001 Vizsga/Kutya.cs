using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _001_Vizsga
{
    public class Kutya : Allat
    {
        public Kutya(string nev) : base(nev)
        {
        }

        public string Ugat()
        {
            return nev + " ugat... vau-vau...";
        }
    }
}
