using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L5_WGKM_1279121
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool continuar = true;

            while (continuar)
            {
                Console.Clear();
                Console.WriteLine("1. EJercicio No.1");
                Console.WriteLine("2. EJercicio No.2");
                Console.WriteLine("3. tarea 1"); 
                Console.WriteLine("4. tarea 2");

                try
                {
                    switch (Convert.ToInt32(Console.ReadLine()))
                    {
                        case 1:
                            Console.Clear();
                            Console.WriteLine("ingrese un numero entero");
                            int x = Convert.ToInt32(Console.ReadLine());

                            if (x < 0)
                            {
                                Console.WriteLine("negatica");
                            }
                            if (x > 0)
                            {
                                Console.WriteLine("posictiva");
                            }
                            Console.ReadKey();
                            break;
                        case 2:
                            Console.Clear();
                            Console.WriteLine("ingrese un dia de la semana");
                            int y = Convert.ToInt32(Console.ReadLine());
                            if (y == 0) { Console.WriteLine("“Error: El número a ingresar debe estar contenido entre 1 y 7"); }
                            if (y == 1) { Console.WriteLine("Lunes");}
                            if (y == 2) { Console.WriteLine("Martes");}
                            if (y == 3) { Console.WriteLine("Miercoles");}
                            if (y == 4) { Console.WriteLine("Jueves");}
                            if (y == 5) { Console.WriteLine("Viernes");}
                            if (y == 6) { Console.WriteLine("Sabado");}
                            if (y == 7) { Console.WriteLine("Domingo"); }
                            if (y == 8) { Console.WriteLine("r"); }
                            Console.ReadKey();
                            break;
                        case 3:
                            decimal cantidad1, cantidad2, cantidad3;
                            string moneda1, moneda2, moneda3;

                            Console.WriteLine("Ingrese la primera cantidad y moneda (USD o GTQ):");
                            cantidad1 = Convert.ToDecimal(Console.ReadLine());
                            moneda1 = Console.ReadLine();

                            Console.WriteLine("Ingrese la segunda cantidad y moneda (USD o GTQ):");
                            cantidad2 = Convert.ToDecimal(Console.ReadLine());
                            moneda2 = Console.ReadLine();

                            Console.WriteLine("Ingrese la tercera cantidad y moneda (USD o GTQ):");
                            cantidad3 = Convert.ToDecimal(Console.ReadLine());
                            moneda3 = Console.ReadLine();

                            decimal[] cantidades = { cantidad1, cantidad2, cantidad3 };
                            string[] monedas = { moneda1, moneda2, moneda3 };

                            decimal tipoCambio = 7.83m;

                            decimal[] cantidadesEnQuetzales = new decimal[3];

                            for (int i = 0; i < 3; i++)
                            {
                                if (monedas[i] == "USD")
                                {
                                    cantidadesEnQuetzales[i] = cantidades[i] * tipoCambio;
                                }
                                else if (monedas[i] == "GTQ")
                                {
                                    cantidadesEnQuetzales[i] = cantidades[i];
                                }
                                else
                                {
                                    Console.WriteLine("Moneda no reconocida: " + monedas[i]);
                                    return;
                                }
                            }

                            Array.Sort(cantidadesEnQuetzales);

                            Console.WriteLine("Las cantidades en quetzales son:");
                            foreach (decimal cantidadEnQuetzales in cantidadesEnQuetzales)
                            {
                                Console.WriteLine(cantidadEnQuetzales);
                            }
                            Console.ReadKey();
                            break;
                        case 4:
                            Console.Write("Ingrese el monto de la compra: ");
                            double monto = double.Parse(Console.ReadLine());

                            double descuento;
                            if (monto < 400)
                            {
                                descuento = 0;
                            }
                            else if (monto <= 1000)
                            {
                                descuento = monto * 0.07;
                            }
                            else if (monto <= 5000)
                            {
                                descuento = monto * 0.1;
                            }
                            else if (monto <= 15000)
                            {
                                descuento = monto * 0.15;
                            }
                            else
                            {
                                descuento = monto * 0.25;
                            }

                            Console.WriteLine("El descuento correspondiente es de: Q{0}", descuento);
                            Console.ReadKey();
                            break;

                    }

                }
                catch 
                {
                    Console.WriteLine("error");

                }
            }


            Console.ReadKey();  
        } 
        
        

    }
}
