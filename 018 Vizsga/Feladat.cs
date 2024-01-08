using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _018_Vizsga
{
    class Feladat
    {
        private int a;
        private int b;
        private string aMertekegysege;
        private string bMertekegysege;

        public Feladat(int a, string aMertekegysege, int b, string bMertekegysege)
        {
            this.a = a;
            this.aMertekegysege = aMertekegysege;
            this.b = b;
            this.bMertekegysege = bMertekegysege;
        }

        public override string ToString()
        {
            return "Mennyi a téglalap területe és kerülete, ha a = " 
                + a + " " + aMertekegysege + ", b = " + b + " " + bMertekegysege + "?";
        }

    }
}
