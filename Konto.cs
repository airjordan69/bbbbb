using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace powtórka
{
    public class Konto
    {
        public string Wlasciciel { get; set; }

        public double StanKonta { get; set; }
        public ulong NumerKonta { get; set; }
        private static ulong biezacyNrKonta = 100;

        public Konto(string wlasciciel)
        {
            if (wlasciciel.Length > 5)
            {
                Wlasciciel = wlasciciel;
            }
            else
            {
                Wlasciciel = "NIEPOPRAWNA NAZWA";
            }
            StanKonta = 0;
            biezacyNrKonta++;
            NumerKonta = biezacyNrKonta;


        }
        public override string ToString()
        {
            return "Właściciel: " + Wlasciciel + "\n Stan konta: " + StanKonta + " zł." + "\n Numer konta: " + NumerKonta;
        }
        public void Wplac(double kwota)
        {
            StanKonta += kwota;
        }
        public bool MoznaWyplacic(double kwota)
        {
            if (kwota <= StanKonta)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        virtual public void Wyplac(double kwota)
        {
            if (kwota <= StanKonta)
                StanKonta -= kwota;
            else
                throw new ZlaOperacjaEXCEPTION("Za mały stan konta");
        }
        public static void Przelej(Konto k1, Konto k2, double kwota)
        {
            if (k1.StanKonta >= kwota)
            {
                k1.StanKonta -= kwota;
                k2.StanKonta += kwota;
            } else
            {
                throw new ZlaOperacjaEXCEPTION("Za mały stan konta");
            }
        }
    }
}
