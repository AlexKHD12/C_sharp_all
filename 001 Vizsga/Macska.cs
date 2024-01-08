using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _001_Vizsga
{
    public class Macska : Allat
    {
        public Macska(string nev) : base(nev)
        {
        }

        public string Nyavog()
        {
            return nev + " nyavog... miau...";
        }
    }
}
