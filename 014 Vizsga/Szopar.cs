namespace _014_Vizsga
{
    public class Szopar
    {
        private string magyar;
        private string angol;
        
        public Szopar(string magyar, string angol)
        {
            this.magyar = magyar;
            this.angol = angol;
        }

        public string GetMagyar()
        {
            return magyar;
        }

        public string GetAngol()
        {
            return angol;
        }
        
        public override string ToString()
        {
            return magyar + " - " + angol;
        }

    }
}
