using System;
using B_01;

namespace E_01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Triangulo t = new Triangulo();
            Cuadrado c = new Cuadrado();
            string conti;
            int opc2, opc3;

            do
            {
                Console.Clear();
                menu1();

                do
                {
                    Console.Write("Ingrese una opción: ");
                    opc2 = int.Parse(Console.ReadLine());

                    if (opc2 < 0 || opc2 > 4)
                    {
                        Console.WriteLine("Error. Ingrese una opción válida.\n");
                    }
                    else
                        break;
                } while (true);

                switch (opc2)
                {
                    case 0:
                        return;
                    case 1:
                        opc3 = menu2();
                        switch (opc3)
                        {
                            case 1: t.area();
                                break;
                            case 2: t.perimetro();
                                break;
                        }
                        break;
                    case 2:
                        opc3 = menu2();

                        Console.Write("\nIngrese lado: ");
                        int lado = int.Parse(Console.ReadLine());

                        switch (opc3)
                        {
                            case 1: c.area(lado);
                                break;
                            case 2: c.perimetro(lado);
                                break;
                        }
                        break;
                    case 3:
                        break;
                    case 4:
                        break;
                }

                do
                {
                    Console.Write("\n¿Desea continuar? (s/n): ");
                    conti = Console.ReadLine().ToLower();

                    if (conti != "n" && conti != "s")
                    {
                        Console.WriteLine("Error. Ingrese solo 's' o 'n'.\n");
                    }
                    else
                        break;
                } while (true);

            } while (conti == "s");
        }

        static void menu1()
        {
            Console.WriteLine("Bienvenidos a cálculos de áreas y perímetros\n");
            Console.WriteLine("- Menú de opciones -");
            Console.WriteLine(" 1. Triángulo ");
            Console.WriteLine(" 2. Cuadrado ");
            Console.WriteLine(" 3. Rectángulo ");
            Console.WriteLine(" 4. Trapecio ");
            Console.WriteLine(" 0. Salir ");
        }

        static int menu2()
        {
            Console.WriteLine("- Seleccione el cálculo -");
            Console.WriteLine(" 1. Área ");
            Console.WriteLine(" 2. Perímetro ");
            Console.Write("\nIngrese una opción: ");
            return int.Parse(Console.ReadLine());
        }
    }
}
