using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classi_5_AINT
{
    class Cerchio
    {
        //Property e Attributi
        private double _raggio = 0.0F;
        public double Raggio
        {
            get { return _raggio; }  
            set { _raggio = (value >= 0) ? value : 0.0F; }
        }

        //Costruttori
        public Cerchio():this(0.0F){}
        public Cerchio(double raggio)
        {
            this.Raggio = raggio;
        }

        //Metodi e Property
        public double Area
        {
            get
            {
                return this.AreaM();
            }
        }
        public double AreaM()
        {
            return Math.PI * Math.Pow(this.Raggio, 2);
        }

    }
}
