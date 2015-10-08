using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classi_5BINT
{
    enum Colore { Bianco, Rosso, Nero, Blue, Grigio, Giallo }

    class Macchina : Veicolo
    {
        
        //Property        
      
      
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
        public Macchina(string produttore, string modello, int anno, Colore colore)
            : this(produttore,modello,anno)
        {
            this.Colore = colore;
        }

       
        public float Valore
        {
            get
            {
                return Macchina.CalcolaValore(this);
            }
        }
        private static float CalcolaValore(Macchina m)
        {
            // Da inserire un metodo
            return 100.0F - m.Eta;
        }

    }
}
