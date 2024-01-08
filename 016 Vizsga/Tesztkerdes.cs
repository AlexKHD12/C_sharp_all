using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _016_Vizsga
{
    class Tesztkerdes
    {
        private string kerdes;
        private string helyesValasz;
        private int pontszam;

        public Tesztkerdes(string kerdes, string helyesValasz, int pontszam)
        {
            this.kerdes = kerdes;
            this.helyesValasz = helyesValasz;
            this.pontszam = pontszam;
        }

        public string GetKerdes()
        {
            return kerdes;
        }

        public string GetHelyesValasz()
        {
            return helyesValasz;
        }

        public int GetPontszam()
        {
            return pontszam;
        }

        public override string ToString()
        {
            return "[" + pontszam + "] " + kerdes;
        }

    }
}
