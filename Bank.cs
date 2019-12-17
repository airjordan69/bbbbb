using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace powtórka
{
    class Bank
    {
        public string Nazwa { get; set; }
        private LinkedList<Konto> listaKont { get; set; }
        public Bank(string nazwa)
        {
            Nazwa = nazwa;
            listaKont = new LinkedList<Konto>();
        }
        public void UtwórzKonto(Konto k)
        {
            listaKont.AddLast(k);
        }
        public void UsuńKonto(ulong nr_konta)
        {
            foreach (Konto k in listaKont)
            {
                if (k.NumerKonta == nr_konta)
                {
                    listaKont.Remove(k);
                }
            }
        }
        public Konto PodajKonto(ulong nr_konta)
        {
            foreach (Konto k in listaKont)
            {
                if (k.NumerKonta == nr_konta)
                {
                    return k;
                }    
            }
            throw new Exception(String.Format("Brak konta o nr {0} w systemie banku", nr_konta));
        }
        public Konto PodajKonto(string nazwa)
        {
            foreach (Konto k in listaKont)
            {
                if (k.Wlasciciel == nazwa)
                {
                    return k;
                }
            }
            throw new Exception(String.Format("Brak konta o nazwie {0} w systemie banku", nazwa));
        }
        public double SaldoBanku()
        {
            double saldo = 0;
            foreach (Konto k in listaKont)
            {
                saldo += k.StanKonta;
            }
            return saldo;
        }
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Nazwa banku: " + Nazwa);
            sb.AppendLine(String.Format("Saldo banku: {0:0.00}", SaldoBanku()));
            sb.AppendLine();
            sb.AppendLine("Konta: ");
            foreach(Konto k in listaKont)
            {
                sb.AppendLine(k.ToString());
            }
            return sb.ToString();
        }
    }
}
