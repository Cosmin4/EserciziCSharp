using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classi_5BINT
{
    class C1
    {
        public C1(){}
        public void Metodo1() { }
        public static void Metodo2() { }
    }

    class C2 : C1
    {
        public C2() { }
        public C2(string ss) : this()
        {
            //  ddd
        }

        public void M1()
        {
            base.Metodo1();
            this.Metodo1();
            C1.Metodo2();
        }      
    }
}
