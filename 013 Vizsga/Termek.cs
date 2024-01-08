namespace _013_Vizsga
{
    public class Termek
    {
        private string termekNeve;
        private int darabRaktaron;

        public Termek(string termekNeve)
        {
            this.termekNeve = termekNeve;
            darabRaktaron = 0;
        }

        public void RaktarbaErkezett(int darab)
        {
            darabRaktaron += darab;
        }

        public bool RaktarbolKiadas(int darab)
        {
            if (darab<=darabRaktaron)
            {
                darabRaktaron -= darab;
                return true;
            }
            return false;
        }      

        public override string ToString()
        {
            return termekNeve + " (raktáron: " + darabRaktaron + " darab)";
        }

    }
}
