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
            //var m1 = new Macchina();
            //m1.Produttore = "Fiat";
            //m1.Modello = "Punto 1300cc";
            //m1.Anno = 1997;
            //Console.WriteLine(m1.ToString());
            //Console.WriteLine("Valore stimato = {0:C2}", m1.Valore);
            
            var m1 = new Macchina("Fiat","Panda 1200cc",1997);
            Macchina m2;
            m2 = m1; // Che significa? due RIFERIMENTI dello stesso oggetto in memoria.
            
            Console.WriteLine(m1 == m2);
            Console.WriteLine(Macchina.Equals(m1, m2));

            // Se un oggetto non ha riferimenti viene eliminato dal Garbage Collector.
            m2 = null;
            m1 = null;

            Console.ReadKey();
        }
    }
}
