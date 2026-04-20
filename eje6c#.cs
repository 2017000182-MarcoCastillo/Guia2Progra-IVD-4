using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication26
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ingrese el ángulo en grados: ");
            double angulo = Convert.ToDouble(Console.ReadLine());

            // Convertir a radianes
            double radianes = angulo * Math.PI / 180;

            Console.WriteLine("Seleccione la función:");
            Console.WriteLine("1. Seno");
            Console.WriteLine("2. Coseno");
            Console.WriteLine("3. Tangente");

            int opcion = Convert.ToInt32(Console.ReadLine());

            double resultado = 0;

            switch (opcion)
            {
                case 1:
                    resultado = Math.Sin(radianes);
                    Console.WriteLine("Seno: " + resultado);
                    break;
                case 2:
                    resultado = Math.Cos(radianes);
                    Console.WriteLine("Coseno: " + resultado);
                    break;
                case 3:
                    resultado = Math.Tan(radianes);
                    Console.WriteLine("Tangente: " + resultado);
                    break;
                default:
                    Console.WriteLine("Opción inválida");
                    break;
            }

            Console.WriteLine("Presione Enter para salir...");
            Console.ReadLine(); // evita que se cierre
        }
    }
}
