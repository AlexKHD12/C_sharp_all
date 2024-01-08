namespace _010_Vizsga
{
    public class Szemely
    {
        private string nev, telefonszam;

        public Szemely(string nev, string telefonszam)
        {
            this.nev = nev;
            this.telefonszam = telefonszam;
        }

        public string GetNev()
        {
            return nev;
        }

        public string GetTelefonszam()
        {
            return telefonszam;
        }

        public override string ToString()
        {
            return nev;
        }
    }
}