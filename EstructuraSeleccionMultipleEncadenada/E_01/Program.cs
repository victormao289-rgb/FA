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
            Console.Write("Ingrese su nota (0-20): ");
            int nota = int.Parse(Console.ReadLine());

            if (nota >= 18)
            {
                Console.WriteLine("Excelente");
            }
            else if (nota >= 14)
            {
                Console.WriteLine("Bueno");
            }
            else if (nota >= 11)
            {
                Console.WriteLine("Regular");
            }
            else
            {
                Console.WriteLine("Desaprobado");
            }
        }
    }
}

/*
# Programa que evalúa una nota y muestra un mensaje

def main():
    nota = int(input("Ingrese su nota (0-20): "))

    if nota >= 18:
        print("Excelente")
    elif nota >= 14:
        print("Bueno")
    elif nota >= 11:
        print("Regular")
    else:
        print("Desaprobado")

# Llamada al programa principal
if __name__ == "__main__":
    main()
*/
