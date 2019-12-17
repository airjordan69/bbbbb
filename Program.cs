using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace powtórka
{
    class Program
    {
        static void Main(string[] args)
        {
            Konto konto1 = new Konto("hubert");
            Konto konto2 = new Konto("igordacz");
            KontoSkarbonka ks = new KontoSkarbonka("kontoskarbonka");
            //ks.Wplac(1000);
            //ks.Wyplac(100);
            //Console.WriteLine(ks.ToString());
            //Console.WriteLine(konto2.ToString());
            konto1.Wplac(500.50);
            //Console.WriteLine(konto1.MoznaWyplacic(700));
            konto1.Wyplac(20.15);
            Konto.Przelej(konto1, konto2, 300);
            //Console.WriteLine("================SPRAWDZENIE STANU KONTAA================");
            //Console.WriteLine(konto1.ToString());
            //Console.WriteLine(konto2.ToString());
            //Console.WriteLine();
            Bank bank1 = new Bank("bank");
            bank1.UtwórzKonto(konto1);
            bank1.UtwórzKonto(konto2);
            Console.WriteLine();
            Console.WriteLine(bank1.PodajKonto("hubert"));
            Console.WriteLine("Saldo banku: ");
            Console.WriteLine(bank1.SaldoBanku());
            Console.WriteLine();
            Console.WriteLine(bank1.ToString());
            Console.ReadKey();
        }
    }
}
