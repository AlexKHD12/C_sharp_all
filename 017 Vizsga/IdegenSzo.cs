using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _017_Vizsga
{
    class IdegenSzo
    {
        private string szo;
        private string jelentese;
        private string eredete;

        public IdegenSzo(string szo, string jelentese, string eredete)
        {
            this.szo = szo;
            this.jelentese = jelentese;
            this.eredete = eredete;
        }

        public string GetSzo()
        {
            return szo;
        }

        public string GetJelentese()
        {
            return jelentese;
        }

        public string GetEredete()
        {
            return eredete;
        }

        public override string ToString()
        {
            if (eredete.Length > 0)
            {
                return szo + " (" + eredete + ")";
            }
            return szo;
        }

    }
}
