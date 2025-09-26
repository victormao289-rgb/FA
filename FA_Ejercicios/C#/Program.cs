using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ejercicio01();
            Console.ReadKey(); //realizando detenimiento de consola
        }
        static void ejercicio01()
        {
            Console.WriteLine("Ingrese x: ");
            int x = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese y: ");
            int y = Convert.ToInt32(Console.ReadLine());

            int sum = x + y;
            double division = (double)x / (double)y;

            Console.WriteLine("\nSuma: " + sum);
            Console.WriteLine("Resta: " + (x - y));
            Console.WriteLine("Multiplicacion: " + (x * y));
            Console.WriteLine("Division: " + division);
        }
        static void ejercicio02()
        {
            Console.WriteLine("Ingrese un numero decimal: ");
            double num = double.Parse(Console.ReadLine());

            double raizCuadrada = Math.Sqrt(num);
            int redondeo = (int)Math.Round(num, 0);
            double cubo = Math.Pow(num, 3);
            double raizCubica = Math.Pow(num, 1 / 3d);

            Console.WriteLine("Raiz cuadradada: " + raizCuadrada);
            Console.WriteLine("Redondeo: " + redondeo);
            Console.WriteLine("Cubo: " + cubo);
            Console.WriteLine("Raiz cubica: " + raizCubica);
        }
        static void ejercicio03()
        {
            Console.WriteLine("Ingrese un numero: ");
            string num = Console.ReadLine();

            double deci = double.Parse(num);
            int entero = (int)Math.Round(deci);

            Console.WriteLine("Resto: " + entero % 2);
            Console.WriteLine("Division: " + deci / 3);
        }
        static void ejercicio04()
        {
            Console.WriteLine("Ingrese la edad: ");
            int edad = int.Parse(Console.ReadLine());

            if (edad < 18)
            {
                Console.WriteLine("Menor de edad");
            }
            else
            {
                if (edad <= 64)
                {
                    Console.WriteLine("Adulto");
                }
                else
                {
                    Console.WriteLine("Adulto mayor");
                }
            }
        }
        static void ejercicio05()
        {
            Console.WriteLine("Ingrese un año: ");
            int a = int.Parse(Console.ReadLine());

            if (a % 4 == 0 && a % 100 != 0 || a % 400 == 0)
                Console.WriteLine("El año es bisiesto");
            else
                Console.WriteLine("El año no es bisiesto");

            if (a % 2 == 0) Console.WriteLine("El año es par");
            else Console.WriteLine("El año es impar");
        }
        static void ejercicio06()
        {
            Console.WriteLine("Ingrese tipo en soles:");
            double monto = double.Parse(Console.ReadLine());

            Console.WriteLine("\n1. Dolares:");
            Console.WriteLine($"2. Euros\n");

            Console.WriteLine("Ingrese una opcion: ");
            int opcion = int.Parse(Console.ReadLine());

            switch (opcion)
            {
                case 1:
                    Console.WriteLine("Dolares: " + Math.Round((monto / 3.75), 2));
                    break;
                case 2:
                    Console.WriteLine($"Euros: {(monto / 4.05):0F}");
                    break;
                default:
                    Console.WriteLine("Opcion incorrecta");
                    break;
            }
        }
        static void ejercicio07()
        {
            Console.WriteLine("Bienvenidos al sistema de Areas\n");
            Console.WriteLine("1. Cuadrado");
            Console.WriteLine("2. Rectangulo");
            Console.WriteLine("3. Triangulo");
            Console.WriteLine("4. Circulo\n");

            Console.WriteLine("Ingrese una opcion: ");
            int opcion = int.Parse(Console.ReadLine());

            switch (opcion)
            {
                case 1:
                    Console.Write("Ingrese lado: ");
                    int lado = int.Parse(Console.ReadLine());
                    Console.WriteLine("Area del cuadrado: " + lado * lado);
                    break;
                case 2:
                    Console.Write("Ingrese la base: ");
                    int bse = int.Parse(Console.ReadLine());
                    Console.Write("Ingrese la altura: ");
                    int alt = int.Parse(Console.ReadLine());
                    Console.Write("Area del rectangulo: " + bse * alt);
                    break;
                case 3:
                    Console.Write("Ingrese la base: ");
                    int bse2 = int.Parse(Console.ReadLine());
                    Console.Write("Ingrese la altura: ");
                    int alt2 = int.Parse(Console.ReadLine());
                    Console.Write("Area del triangulo: " + (bse2 * alt2) / 2);
                    break;
                case 4:
                    Console.Write("Ingrese la radio: ");
                    double ra = double.Parse(Console.ReadLine());
                    Console.Write("Area del circulo: " + Math.Round((Math.PI * Math.Pow(ra, 2)), 2));
                    break;
                default: break;
            }
        }
        static void ejercicio08()
        {
            Console.Write("¿Cuantos numeros ingresara? ");
            int cantidad = int.Parse(Console.ReadLine());

            int pares = 0, impares = 0, ceros = 0;

            for (int i = 1; i <= cantidad; i++)
            {
                Console.Write($"Ingrese el numero {i}: ");
                int numero = int.Parse(Console.ReadLine());

                if (numero == 0)
                {
                    ceros++;
                }
                else if (numero % 2 == 0)
                {
                    pares++;
                }
                else
                {
                    impares++;
                }
            }

            Console.WriteLine("\nRESULTADOS");
            Console.WriteLine("Cantidad de pares: " + pares);
            Console.WriteLine("Cantidad de impares: " + impares);
            Console.WriteLine("Cantidad de ceros: " + ceros);

            Console.ReadKey(); // pausa la consola
        }
        static void ejercicio09()
        {
            Console.Write("Ingrese un numero entero");
            int num = int.Parse(Console.ReadLine());

            while (num <= 0)
            {
                Console.Write("Error. Ingrese un numero entero: ");
                num = int.Parse(Console.ReadLine());
            }

            int i = 1;
            Console.WriteLine();

            while (i <= 12)
            {
                Console.WriteLine($"{num} x {i} = {num * i}");
                i++;
            }
        }
        static void ejercicio10()
        {
            int sp = 0, si = 0;

            while (true)
            {
                Console.Write("Ingrese un numero positivo:");
                int num = int.Parse(Console.ReadLine());

                if (num == 0) break;
                if (num < 0)
                {
                    Console.WriteLine("Error. Ingrese solo positivos:");
                    Console.WriteLine();
                    continue;
                }

                if (num % 2 == 0)
                    sp += num; // sp = sp + suma
                else
                    si += num;
            }
            Console.WriteLine("Suma de pares: " + sp);
            Console.WriteLine("Suma de impares: " + si);
            Console.ReadKey();
        }
        static void ejercicio11()
        {
            Console.Write("Ingrese la cantidad de filas: ");
            int filas = int.Parse(Console.ReadLine());

            Console.Write("Ingrese la cantidad de columnas: ");
            int columnas = int.Parse(Console.ReadLine());

            Console.WriteLine();

            int i = 1;
            while (i <= filas)
            {
                int j = 1;
                while (j <= columnas)
                {
                    Console.Write("* ");
                    j++;
                }
                Console.WriteLine(); // salto de línea al terminar una fila
                i++;
            }
            Console.ReadKey();
        }
        static void ejercicio12()
        {
            Console.WriteLine("Genere una contraseña: ");
            string contra = Console.ReadLine();

            int intentos = 3;

            Console.WriteLine("------------------------");
            Console.WriteLine("--Valida tu contraseña--");
            Console.WriteLine("------------------------");

            while (intentos > 0)
            {
                Console.Write("Ingresa tu contraseña: ");
                string pass = Console.ReadLine();

                if (contra == pass)
                {
                    Console.WriteLine("Acceso concedido!");
                    return;
                }
                else
                {
                    Console.WriteLine($"Contraseña incorrecta! Le restan {intentos - 1} intentos");
                    intentos--;
                }
            }
            Console.WriteLine("Acceso denegado. Ya culmino todos sus intentos!");
            Console.ReadKey();
        }
    }
}
