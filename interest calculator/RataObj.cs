using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculeazaDobanda
{
    class RataObj
    {
        private double valoareCredit;
        private double perioadaCredit;
        private double dobandaCredit;
        private double rata = 0;
        
        public RataObj() {   }

        public RataObj(double valoareCredit, double perioadaCredit, double dobandaCredit)
        {
            this.valoareCredit = valoareCredit;
            this.perioadaCredit = perioadaCredit;
            this.dobandaCredit = dobandaCredit;
        }

        public double CalculeazaRata(double valoareCredit, double perioadaCredit, double dobandaCredit)
        {
            double dobanda = dobandaCredit / 12;
            double perioada = perioadaCredit * 12;
            rata = valoareCredit * (dobanda/100 )/ (1 - Math.Pow((1 + (dobanda/100)), -perioada));

            return rata;
        }

    }
}
