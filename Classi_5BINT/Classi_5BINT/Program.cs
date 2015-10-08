using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classi_5BINT
{
    class Program
    {
        public static string DettagliVeicolo(Veicolo veicolo)
        {
            //Da Fare!!!
            return "";
        }

        static void Main(string[] args)
        {
            //var m1 = new Macchina();
            //m1.Produttore = "Fiat";
            //m1.Modello = "Punto 1300cc";
            //m1.Anno = 1997;
            //Console.WriteLine(m1.ToString());
            //Console.WriteLine("Valore stimato = {0:C2}", m1.Valore);

            //var m1 = new Macchina("Fiat","Panda 1200cc",1997);
            //Macchina m2;
            //m2 = m1; // Che significa? due RIFERIMENTI dello stesso oggetto in memoria.

            //Console.WriteLine(m1 == m2);
            //Console.WriteLine(Macchina.Equals(m1, m2));

            // Se un oggetto non ha riferimenti viene eliminato dal Garbage Collector.
            //m2 = null;
            //m1 = null;

            //var macchinaComune = new Macchina();
            //macchinaComune.Modello = "500 XL";

            //Console.WriteLine(macchinaComune.ToString());
            //Metodo statico o di classe
            //C1.Metodo2();
            //var c1 = new C1();
            //Metodo di istanza o di oggetto
            //c1.Metodo1();

            Furgone f1 = new Furgone();
            f1.Produttore = "Fiat";
            f1.Modello = "Campagnola";
            f1.Colore = Colore.Grigio;
            f1.Carico = 12;
         

            Console.WriteLine(f1.ToString());
            
            Console.ReadKey();
        }
    }

    partial class Furgone
    {
        public int AltezzaMassima { get; set; }
    }
}
