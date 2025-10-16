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
        // Definición de función con retorno
        static int SumaNumeros()
        {
            int a = 5;
            int b = 10;
            int suma = a + b;
            return suma; // Función que retorna la suma
        }
        static void Main(string[] args)
        {
            int resultado = SumaNumeros();
            Console.WriteLine("La suma es: " + resultado);
        }
    }
}

/*
# Definición de función con retorno
def suma_numeros():
    a = 5
    b = 10
    suma = a + b
    return suma  # La función retorna la suma

# Función principal
def main():
    resultado = suma_numeros()
    print("La suma es:", resultado)

# Llamada al programa principal
if __name__ == "__main__":
    main()
*/



