using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B_01
{
    public class Cuadrado
    {
        public void area (int l)
        {
            Console.WriteLine("\nArea: " + l * l);
        }
        public void perimetro (int l)
        {
            Console.WriteLine("\nPerimetro: " + 4 * l);
        }
    }
}
