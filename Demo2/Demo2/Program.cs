using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConvertidorTemperatura
{
    class Program
    {
        
        static void Main(string[] args)
        {
            Console.Title = "Temperatura";

            bool continuar = true;

            while (continuar)
            {
                Console.Clear();

                Console.WriteLine("Seleccione una operación: ");

                Console.WriteLine("1. Convertir de Celcius a Fahrenheit");
                Console.WriteLine("2. Convertir de Fahrenheit a Celcius ");
                
                string opcion = Console.ReadLine();

                if (opcion == "1")
                {
                    Celcius();
                }

                if (opcion == "2")
                {
                    Fahrenheit();
                }

         
                Console.WriteLine("\nSeleccione una opción: ");
                Console.WriteLine("1. Volver al menú principal");
                Console.WriteLine("2. Salir");

                opcion = Console.ReadLine();

                if (opcion != "1")
                {
                    continuar = false;
                }

            }
        }



        static void Celcius()
        {
            Console.Clear();

            Console.WriteLine("Celcius");
            Console.WriteLine("");

            Console.WriteLine("Ingrese el primer valor: ");
            int valor1 = Int32.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese el segundo valor: ");
            int valor2 = Int32.Parse(Console.ReadLine());

            int resultado = valor1 * valor2;

            Console.WriteLine("El resultado es: " + resultado);
        }

        
        static void Fahrenheit()
        {
            Console.Clear();

            Console.WriteLine("SUMA");
            Console.WriteLine("");

            Console.WriteLine("Ingrese el primer valor: ");
            int valor1 = Int32.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese el segundo valor: ");
            int valor2 = Int32.Parse(Console.ReadLine());

            int resultado = valor1 + valor2;

            Console.WriteLine("El resultado es: " + resultado);
        }

        

    }
}
