using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classi_5BINT
{
    class Program
    {
        static void Main(string[] args)
        {
            var m1 = new Macchina();
            m1.Produttore = "Fiat";
            m1.Modello = "Punto 1300cc";
            m1.Anno = 1997;
            Console.WriteLine(m1.ToString());
            Console.WriteLine("Valore stimato = {0:C2}", m1.Valore);
  

            Console.ReadKey();
        }
    }
}
