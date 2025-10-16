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
            Console.WriteLine("Menú de opciones:");
            Console.WriteLine("1. Suma");
            Console.WriteLine("2. Resta");
            Console.WriteLine("3. Multiplicación");
            Console.WriteLine("4. División");

            Console.Write("\nIngrese una opción (1-4): ");
            int opcion = int.Parse(Console.ReadLine());

            // Estructura de selección múltiple (switch)
            switch (opcion)
            {
                case 1:
                    Console.WriteLine("Has elegido Suma.");
                    break;
                case 2:
                    Console.WriteLine("Has elegido Resta.");
                    break;
                case 3:
                    Console.WriteLine("Has elegido Multiplicación.");
                    break;
                case 4:
                    Console.WriteLine("Has elegido División.");
                    break;
                default:
                    Console.WriteLine("Opción no válida.");
                    break;
            }

            Console.WriteLine("Fin del programa.");
        }
    }
}

/*
# Programa con menú de opciones usando estructura de selección múltiple

def main():
    print("Menú de opciones:")
    print("1. Suma")
    print("2. Resta")
    print("3. Multiplicación")
    print("4. División")

    opcion = int(input("\nIngrese una opción (1-4): "))

    # Estructura de selección múltiple (match-case en Python 3.10+)
    match opcion:
        case 1:
            print("Has elegido Suma.")
        case 2:
            print("Has elegido Resta.")
        case 3:
            print("Has elegido Multiplicación.")
        case 4:
            print("Has elegido División.")
        case _:
            print("Opción no válida.")

    print("Fin del programa.")

# Llamada al programa principal
if __name__ == "__main__":
    main()
*/