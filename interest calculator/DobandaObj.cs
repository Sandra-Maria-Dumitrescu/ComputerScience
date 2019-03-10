using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculeazaDobanda
{
    class DobandaObj
    {
        private double sumaDepusa;
        private double durataDepozit;
        private double dobandaDepozit;

        public DobandaObj() { }

        public DobandaObj(double sumaDepusa, double durataDepozit, double dobandaDepozit)
        {
            this.sumaDepusa = sumaDepusa;
            this.durataDepozit = (durataDepozit *30) / 360;
            this.durataDepozit = dobandaDepozit;
        }

        public double CalculeazaDobanda(double valoareDepozit, double dobandaDep, double perioadaDepozit)
        {
            double dobanda = valoareDepozit * (dobandaDep /100 )* (perioadaDepozit * 30 / 360);
            return dobanda;
        }

    }
}
