using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L10_WGKM_1279121
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool continuar = true;

            while (continuar)
            {
                Console.WriteLine("Calculadora");
                Console.WriteLine("1. Suma");
                Console.WriteLine("2. Multiplicación");
                Console.WriteLine("3. Raíz Cuadrada");
                Console.WriteLine("4. Porcentaje");
                Console.WriteLine("5. Salir");
                Console.WriteLine("Seleccione una opción:");

                string opciones = Convert.ToString(Console.ReadLine());

                switch (opciones)
                {
                    case "1":
                        Console.Clear();
                        int total = 0;

                        for (int i = 1; i <= 3; i++)
                        {
                            Console.WriteLine("Ingrese el número");
                            int num = Convert.ToInt32(Console.ReadLine());
                            total += num;
                        }

                        Console.WriteLine("La suma total es: " + total);

                        break;

                    case "2":
                        Console.Clear();
                        Console.WriteLine("Ingrese el primer número:");
                        double num1Mul = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("Ingrese el segundo número:");
                        double num2Mul = Convert.ToDouble(Console.ReadLine());

                        double resultadoMul = Multiplicacion(num1Mul, num2Mul);
                        Console.WriteLine("El resultado de la multiplicación es: " + resultadoMul);
                        break;

                    case "3":
                        Console.Clear();
                        Console.WriteLine("Ingrese el número:");
                        double numRaiz = Convert.ToDouble(Console.ReadLine());

                        double resultadoRaiz = RaizCuadrada(numRaiz);
                        Console.WriteLine("La raíz cuadrada es: " + resultadoRaiz);
                        break;

                    case "4":
                        Console.Clear();
                        Console.WriteLine("Ingrese el número:");
                        double numPorcentaje = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("Ingrese el porcentaje:");
                        double porcentaje = Convert.ToDouble(Console.ReadLine());

                        double resultadoPorcentaje = Porcentaje(numPorcentaje, porcentaje);
                        Console.WriteLine("El porcentaje es: " + resultadoPorcentaje);
                        break;

                    case "5":
                        continuar = false;
                        break;

                    default:
                        Console.WriteLine("Opción no válida.");
                        break;
                }

                Console.WriteLine("\nPresione una tecla para continuar...");
                Console.ReadKey();
                Console.Clear();
            }
        }

        static double Multiplicacion(double num1, double num2)
        {
            return num1 * num2;
        }

        static double RaizCuadrada(double num)
        {
            return Math.Sqrt(num);
        }

        static double Porcentaje(double num, double porcentaje)
        {
            return num * porcentaje / 100;
        }
    }
}
 
