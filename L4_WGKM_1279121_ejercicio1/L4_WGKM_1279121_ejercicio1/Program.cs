using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L4_WGKM_1279121_ejercicio1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1.ejercicio No.1");
            Console.WriteLine("2.Jerarquía de operaciones");
            Console.WriteLine("3 expresión cuadrática");
            switch (Convert.ToInt32(Console.ReadLine()))
            {
                case 1:
                    Console.Clear();
                    int n1, n2, suma = 0, resta = 0, multiplicación = 0, división = 0;
                    Console.WriteLine("ejercicio 1");
                    Console.WriteLine("");
                    Console.WriteLine("ingrese un numero");
                    n1 = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("ingrese un numero");
                    n2 = Convert.ToInt32(Console.ReadLine());

                    suma = n1 + n2;
                    resta = n1 - n2;
                    multiplicación = n1 * n2;
                    división = n1 / n2;
                    
                    Console.WriteLine();
                    
                    Console.WriteLine("resrultado de la suma:" + suma);
                    Console.WriteLine("resrultado de la resta:" + resta);
                    Console.WriteLine("resrultado de la multiplicación:" + multiplicación);
                    Console.WriteLine("resrultado de la división:" + división);

                    Console.WriteLine("");

                    Console.WriteLine("ejerciios bolenaos");
                    Console.WriteLine("");
                    Console.WriteLine("ejercicio 2");
                    Console.WriteLine(n1 < n2);
                    Console.WriteLine(n1 > n2);
                    Console.WriteLine(n1 == n2);
                    Console.ReadKey();
                    break;
                case 2:
                    double a, b, c, z = 3, x=2;
                    
                    Console.WriteLine("ejercicio 3: Jerarquía de operacione");
                    Console.WriteLine("");
                    Console.WriteLine("ingrese un numero");
                    a = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("ingrese un numero");
                    b = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("ingrese un numero");
                    c = Convert.ToDouble(Console.ReadLine());

                    double resultado = 0, resultado1 = 0, resultado2 = 0, resultado3 = 0;
                    resultado = a * b + c;
                    resultado1 = a*(b + c);
                    resultado2 = a/(b/+c);
                    resultado3 = z * a + x * b / (Math.Pow(c,2));

                    Console.WriteLine(resultado);
                    Console.WriteLine(resultado1);
                    Console.WriteLine(resultado2);
                    Console.WriteLine(resultado3);
                    Console.ReadKey();
                    break;

                    case 3:

                    double nun1, nun2, nun3, nun4 = 4, nun5 = 2, resultado4, resultado5, resultado6, resultado7, resultado8, resultado9;
                    Console.WriteLine("ingrese un numero");
                    nun1 = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("ingrese un numero");
                    nun2 = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("ingrese un numero");
                    nun3 = Convert.ToDouble(Console.ReadLine());

                    resultado4 = (Math.Pow(nun2, 2));
                    resultado5 = resultado4 - nun4 * nun1 * nun3;  
                    resultado6 = (Math.Pow(resultado5,0.5));
                    resultado7 = nun5 * nun1;
                    resultado8 = -5 + resultado6;
                    resultado9 = resultado8 / resultado7;
                    Console.WriteLine(resultado9);
                    Console.ReadKey();
                    break;
                    case 4:

                    break;

            }
        
        } 


    }

}
