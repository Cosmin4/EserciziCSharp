using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classi_5_AINT
{
    enum Colori {blue,nero,giallo,bianco};

    class Automobile
    {
        public string Produttore { get; set; }
        public string Modello { get; set; }
        public int Anno { get; set; }
        public Colori Colore { get; set; }

        public double ValoreDiMercaro()
        {
            //Codice e codice....
            return 50.0F - (DateTime.Now.Year - this.Anno);
        }
      
    }
    class Program
    {
       
        static void Main(string[] args)
        {
            Automobile miaAuto = new Automobile();
            miaAuto.Produttore = "Fiat";
            miaAuto.Modello = "Punto 1300cc";
            miaAuto.Anno = 1990;
            miaAuto.Colore = Colori.blue;



            Console.WriteLine(miaAuto.ValoreDiMercaro());

            Console.ReadKey();
        }


    }
}
