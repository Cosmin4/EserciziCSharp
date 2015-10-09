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
        public Cilindro():this(0,0) { }
        public Cilindro(double raggioBase, double altezza) : base(raggioBase)
        {
            this.Altezza = altezza;
        }
    }
}
