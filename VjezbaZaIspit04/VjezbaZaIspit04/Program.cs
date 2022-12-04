using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VjezbaZaIspit04
{
    internal class Program
    {

        class KlasaX
        {
            private int broj;

            public int Broj { get => broj; set => broj = value; }
 
        }

        static void Main(string[] args)
        {
            KlasaX x = new KlasaX();
            x.Broj = 10;
            Console.WriteLine(x.Broj);
            Console.ReadKey();
        }
    }
}
