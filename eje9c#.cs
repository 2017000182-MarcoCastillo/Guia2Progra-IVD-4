using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication29
{
    class Program
    {
        static void Main(string[] args)
        {
            int opcion1, opcion2;
            double valor, resultado = 0;

            Console.WriteLine("===== CONVERSOR DE LONGITUD =====");
            Console.WriteLine("1. Metros");
            Console.WriteLine("2. Pies");
            Console.WriteLine("3. Centímetros");
            Console.WriteLine("4. Pulgadas");

            Console.Write("Seleccione unidad de entrada: ");
            opcion1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Ingrese el valor: ");
            valor = Convert.ToDouble(Console.ReadLine());

            Console.Write("Seleccione unidad de salida: ");
            opcion2 = Convert.ToInt32(Console.ReadLine());

            // Convertir a metros primero
            switch (opcion1)
            {
                case 1: break; // metros
                case 2: valor *= 0.3048; break; // pies a metros
                case 3: valor /= 100; break; // cm a metros
                case 4: valor *= 0.0254; break; // pulgadas a metros
                default:
                    Console.WriteLine("Unidad de entrada inválida");
                    Console.ReadLine();
                    return;
            }

            // Convertir de metros a la unidad final
            switch (opcion2)
            {
                case 1: resultado = valor; break;
                case 2: resultado = valor / 0.3048; break;
                case 3: resultado = valor * 100; break;
                case 4: resultado = valor / 0.0254; break;
                default:
                    Console.WriteLine("Unidad de salida inválida");
                    Console.ReadLine();
                    return;
            }

            Console.WriteLine("Resultado: " + resultado);

            Console.WriteLine("Presione Enter para salir...");
            Console.ReadLine();
        }
    }
}
