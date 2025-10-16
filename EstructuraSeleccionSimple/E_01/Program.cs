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
            Console.Write("Ingrese su edad: ");
            int edad = int.Parse(Console.ReadLine());

            // Estructura de selección simple (if)
            if (edad >= 18)
            {
                Console.WriteLine("Eres mayor de edad.");
            }

            Console.WriteLine("Fin del programa.");
        }
    }
}

/*
# Programa que pide la edad y determina si es mayor de edad

def main():
    edad = int(input("Ingrese su edad: "))

    # Estructura de selección simple (if)
    if edad >= 18:
        print("Eres mayor de edad.")

    print("Fin del programa.")

# Llamada al programa principal
if __name__ == "__main__":
    main()
*/
