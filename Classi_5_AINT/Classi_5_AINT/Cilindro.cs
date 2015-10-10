using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classi_5_AINT
{
    class Cilindro:Cerchio
    {
        //Property e Attributi
        private double _altezza = 0.0F;
        public double Altezza
        {
            get { return _altezza; }
            set { _altezza = (value >= 0) ? value : 0.0F; }
        }

        //Costruttori
        public Cilindro():this(0.0F,0F) { }
        public Cilindro(double raggioBase, double altezza) : base(raggioBase)
        {
            this.Altezza = altezza;
        }

        //Metodi e Property
        public double Volume
        {
            get
            {
                return this.Area * this.Altezza;
            }
        }

        //Override
        public override string ToString()
        {
            return String.Format("CILINDRO\nRaggio = \t{0:N} m\nAltezza = \t{1:N} m\nArea = \t{2:N} m^2", 
                this.Raggio,
                this.Altezza, 
                this.Volume);
        }
    }
}
