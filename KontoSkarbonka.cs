using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace powtórka
{
    public class KontoSkarbonka : Konto
    {
        public double Skarbonka { get; set; }
        public KontoSkarbonka(string wlasciciel) : base(wlasciciel)
        {
            Skarbonka = 0;
        }
        
        public override void Wyplac(double kwota)
        {
            if (kwota <= StanKonta)
            {
                StanKonta -= kwota;
                Skarbonka += 0.01 * kwota;
            }     
            else
                throw new ZlaOperacjaEXCEPTION("Za mały stan konta");
        }
        public override string ToString()
        {
            return base.ToString() + $"\n Skarbonka: {Skarbonka} zł.";
        }

    }
}
