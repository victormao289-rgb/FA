using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace E_01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i = 3;
            while (i <= 45)
            {
                Console.WriteLine(i);
                i += 3;
            }
        }
    }
}

/*
# Programa que muestra los múltiplos de 3 hasta 45

def main():
    i = 3
    while i <= 45:
        print(i)
        i += 3

# Llamada al programa principal
if __name__ == "__main__":
    main()
*/