using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classi_5BINT
{
    /// <summary>
    /// Classe Veicolo.
    /// </summary>
    abstract class Veicolo
    {
        public string Produttore { get; set; }
        public string Modello { get; set; }
        public int Anno { get; set; }
        public Colore Colore { get; set; }
        public float PrezzoDiListino { get; set; }
        public int Eta
        {
            get
            {
                return DateTime.Now.Year - this.Anno;
            }
        }

        public override string ToString()
        {
            return String.Format("Produttore = {0}\nModello = {1}\nAnno immatricolazione = {2} ({3} anni)\nColore = {4}",
                this.Produttore, this.Modello, this.Anno, this.Eta, this.Colore);
        }
    }
}
