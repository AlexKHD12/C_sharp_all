namespace _015_Vizsga
{
    public class Feladat
    {
        private int szam1, szam2;
        private char muveletiJel;

        public Feladat(int szam1, int szam2, char muveletiJel)
        {
            this.szam1 = szam1;
            this.szam2 = szam2;
            this.muveletiJel = muveletiJel;
        }

        public int Eredmeny()
        {
            if (muveletiJel == '+')
            {
                return szam1 + szam2;
            } 
            else 
            {
                return szam1 - szam2;
            }            
        }

        public override string ToString()
        {
            return szam1 + " " + muveletiJel + " " + szam2 + " =";
        }

    }
}
