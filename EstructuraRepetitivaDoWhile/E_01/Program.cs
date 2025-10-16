using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i = 3, contador = 0, suma = 0;
            do
            {
                Console.WriteLine(i);
                i += 3;

                contador++;
                suma += i;
            } while (i <= 45);
        }
    }
}

/*
# Programa que muestra múltiplos de 3 hasta 45, contando y sumando

def main():
    i = 3
    contador = 0
    suma = 0

    # En Python no existe 'do...while', así que se usa 'while True' con 'break'
    while True:
        print(i)
        i += 3

        contador += 1
        suma += i

        if i > 45:
            break

# Llamada al programa principal
if __name__ == "__main__":
    main()
*/