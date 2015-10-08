using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classi_5BINT
{
    partial class  Furgone : Veicolo
    {
        public int Carico { get; set; }

        public override string ToString()
        {
            return base.ToString() + "\nCarico = " +this.Carico; 
        }
    }
}
