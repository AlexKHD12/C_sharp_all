namespace _007_Vizsga
{
    public class Zeneszam
    {
        private string eloado, cim;
        private int perc, masodperc;

        public Zeneszam(string eloado, string cim, int perc, int masodperc)
        {
            this.eloado = eloado;
            this.cim = cim;
            this.perc = perc;
            this.masodperc = masodperc;
        }

        public string GetEloado()
        {
            return eloado;
        }

        public string GetCim()
        {
            return cim;
        }

        public int GetPerc()
        {
            return perc;
        }

        public int GetMasodperc()
        {
            return masodperc;
        }

        public override string ToString()
        {
            return eloado + " : " + cim + " (" + perc + ":" + masodperc + ") ";
        }

    }
}
