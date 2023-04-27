using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace L6_WGKM_1279121
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x;
            Console.WriteLine("ejercicio 1");

            Console.WriteLine("ingrese un numereo del mes");
            x = Convert.ToInt32(Console.ReadLine());

            switch (x)
            {
                case 1:
                    Console.WriteLine("Mes:enero");
                    break;
                case 2:
                    Console.WriteLine("Mes:Febrero");
                    break;
                case 3:
                    Console.WriteLine("Mes:Marzo");
                    break;
                case 4:
                    Console.WriteLine("Mes:Abril");
                    break;
                case 5:
                    Console.WriteLine("Mes:Mayo");
                    break;
                case 6:
                    Console.WriteLine("Mes:Junio");
                    break;
                case 7:
                    Console.WriteLine("Mes:Julio");
                    break;
                case 8:
                    Console.WriteLine("Mes:Agosto");
                    break;
                case 9:
                    Console.WriteLine("Mes:Septiembre");
                    break;
                case 10:
                    Console.WriteLine("Mes:Octubre");
                    break;
                case 11:
                    Console.WriteLine("Mes:Noviembre");
                    break;
                case 12:
                    Console.WriteLine("Mes:Diciembre");
                    break;
                default:
                    Console.WriteLine("Error: El número a ingresar debe estar contenido entre 1 y 12");
                    break;

            }

            int mes, dia, ano;
            Console.WriteLine("tarea");
            Console.WriteLine("¿cual es año de su nacimiento?");
            ano = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("¿cual es el mes de su nacimiento?");
            mes = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("cual es el dia de su nacimiento?");
            dia = Convert.ToInt32(Console.ReadLine());

            switch (mes)
            {
                case(1):
                if (dia <= 20)
                {
                    Console.WriteLine("Su Signo del Zodiaco es: Capricornio");
                }

                else
                {
                    Console.WriteLine("Su Signo del Zodiaco es: Acuario");
                }
                break;

                    case(2):
                if (dia <=18)
                {
                        Console.WriteLine("Su Signo del Zodiaco es: Acuario");
                }
                else
                {
                        Console.WriteLine("Su Signo del Zodiaco es: Pisis");
                }
                break;

                case (3):
                       if (dia <=20)
                {
                        Console.WriteLine("Su Signo del Zodiaco es: Pisis");
                }
                else
                {
                        Console.WriteLine("Su Signo del Zodiaco es: Aries");
                }
                break;

                case (4):
                    if (dia <= 20)
                    {
                        Console.WriteLine("Su Signo del Zodiaco es: Aries");
                    }
                    else
                    {
                        Console.WriteLine("Su Signo del Zodiaco es: Tauro");
                    }
                    break;

                case (5):
                    if (dia <= 21)
                    {
                        Console.WriteLine("Su Signo del Zodiaco es: Tauro");
                    }
                    else
                    {
                        Console.WriteLine("Su Signo del Zodiaco es: Geminid");
                    }
                    break;

                case (6):
                    if (dia <= 21)
                    {
                        Console.WriteLine("Su Signo del Zodiaco es: Geminis");
                    }
                    else
                    {
                        Console.WriteLine("Su Signo del Zodiaco es: Cancer");
                    }
                    break;

                    case (7):
                    if (dia <= 22)
                    {
                        Console.WriteLine("Su Signo del Zodiaco es: Cancer");
                    }
                    else
                    {
                        Console.WriteLine("Su Signo del Zodiaco es: Leo");
                    }
                    break;

                    case (8):
                    if (dia <= 23)
                    {
                        Console.WriteLine("Su Signo del Zodiaco es: Leo");
                    }
                    else
                    {
                        Console.WriteLine("Su Signo del Zodiaco es: virgo");
                    }
                    break;

                    case (9):
                    if (dia <= 23)
                    {
                        Console.WriteLine("Su Signo del Zodiaco es: Virgo");
                    }
                    else
                    {
                        Console.WriteLine("Su Signo del Zodiaco es: Libra");
                    }
                    break;
                    case (10):
                    if (dia <= 23)
                    {
                        Console.WriteLine("Su Signo del Zodiaco es: Libra");
                    }
                    else
                    {
                        Console.WriteLine("Su Signo del Zodiaco es: Escorpio");
                    }
                    break;

                    case (11):
                    if (dia <= 22)
                    {
                        Console.WriteLine("Su Signo del Zodiaco es: Escorpio");
                    }
                    else
                    {
                        Console.WriteLine("Su Signo del Zodiaco es: Sagitario");
                    }
                    break;

                    case (12):
                    if (dia <= 21)
                    {
                        Console.WriteLine("Su Signo del Zodiaco es: Sagitario");
                    }
                    else
                    {
                        Console.WriteLine("Su Signo del Zodiaco es: capricornio");
                    }
                    break;

            }
            int num1, num2, num3;
            Console.WriteLine("ingrese el número");
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("ingrese el número");
            num2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("ingrese el número");
            num3 = Convert.ToInt32(Console.ReadLine());

            if (num1 > num2)
            {
                Console.WriteLine("el numero mayor: " + num1);
            }
            else
            if (num1 == num2)
            {
                Console.WriteLine("el numero es igual: " + num1);
            }

            if (num2 > num3)
            {
                Console.WriteLine("el numero mayor: " + num2);
            }
            if (num3 > num1)
            {
                Console.WriteLine("el numero mayor: " + num3);
            }

            {
                int m;
                Console.WriteLine("1. ejercicio");
                Console.WriteLine("2.ejercicio");
                Console.WriteLine("3. tarea");
                m = Convert.ToInt32(Console.ReadLine());
 
                switch (m)
                {
                    case 1:
                        Console.WriteLine("C");
                        break;
                }
            }

            Console.ReadKey();


        }
        
    }
}
