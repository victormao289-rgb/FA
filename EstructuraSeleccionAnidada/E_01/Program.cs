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
            Console.Write("Ingrese un número: ");
            int numero = int.Parse(Console.ReadLine());

            // Estructura de selección anidada (if dentro de otro if)
            if (numero > 0)
            {
                Console.WriteLine("El número es positivo.");

                if (numero % 2 == 0)
                {
                    Console.WriteLine("Además, es par.");
                }
                else
                {
                    Console.WriteLine("Además, es impar.");
                }
            }
            else if (numero < 0)
            {
                Console.WriteLine("El número es negativo.");
            }
            else
            {
                Console.WriteLine("El número es cero.");
            }

            Console.WriteLine("Fin del programa.");
        }
    }
}

/*
# Programa que determina si un número es positivo, negativo o cero, y además si es par o impar (cuando es positivo)

def main():
    numero = int(input("Ingrese un número: "))

    # Estructura de selección anidada (if dentro de otro if)
    if numero > 0:
        print("El número es positivo.")

        if numero % 2 == 0:
            print("Además, es par.")
        else:
            print("Además, es impar.")

    elif numero < 0:
        print("El número es negativo.")
    else:
        print("El número es cero.")

    print("Fin del programa.")

# Llamada al programa principal
if __name__ == "__main__":
    main()
*/