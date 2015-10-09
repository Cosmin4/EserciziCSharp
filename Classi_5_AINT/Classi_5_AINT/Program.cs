using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classi_5_AINT
{
    class Program
    {
        static void Main(string[] args)
        {
            Cilindro cl1 = new Cilindro(3.0F,4.0F);
            Cerchio c1 = new Cerchio(4.0F);

            Console.WriteLine(c1);
            Console.WriteLine(cl1);

            Cerchio c2 = c1;
            c2 = null;
            c1 = null;

            Console.ReadKey();
        }
    }
}
