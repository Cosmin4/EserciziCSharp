using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classi_5BINT
{ 
    class Macchina
    {
        
        //Property        
        public string Produttore { get; set; }
        public string Modello { get; set; }
        public int Anno { get; set; }
        public string Colore { get; set; }
        public float PrezzoDiListino { get; set; }
        public int Eta
        {
            get
            {
                return DateTime.Now.Year - this.Anno;
            }
        }
        public float Valore {
            get
            {
                return Macchina.CalcolaValore(this);
            }
        }
      
        // Costruttori
        public Macchina()
        {
            this.Produttore = "Fiat";
            this.Anno = DateTime.Now.Year;
        }
        public Macchina(string produttore, string modello, int anno)
        {
            this.Produttore = produttore;
            this.Modello = modello;
            this.Anno = anno;
        }
        public Macchina(string produttore, string modello, int anno, string colore)
            : this(produttore,modello,anno)
        {
            this.Colore = colore;
        }

        public override string ToString()
        {
            return String.Format("Produttore = {0}\nModello = {1}\nAnno immatricolazione = {2} ({3} anni)\nColore = {4}", 
                this.Produttore,this.Modello,this.Anno,this.Eta   ,this.Colore);
        }

        private static float CalcolaValore(Macchina m)
        {
            // Da inserire un metodo
            return 100.0F-m.Eta;
        }
    }
}
