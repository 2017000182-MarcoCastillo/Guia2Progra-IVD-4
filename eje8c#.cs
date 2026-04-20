using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication28
{
    class Program
    {
        static void Main(string[] args)
        {
            int sector, opcion, cantidad;
            double precio = 0, total;

            Console.WriteLine("Seleccione el sector:");
            Console.WriteLine("1. Palco (Q300)");
            Console.WriteLine("2. Tribuna (Q100 o Q125)");
            Console.WriteLine("3. Preferencia (Q50 o Q75)");
            Console.WriteLine("4. Generales (Q30 o Q50)");

            sector = Convert.ToInt32(Console.ReadLine());

            switch (sector)
            {
                case 1:
                    precio = 300;
                    break;

                case 2:
                    Console.WriteLine("Seleccione precio: 1=Q100, 2=Q125");
                    opcion = Convert.ToInt32(Console.ReadLine());
                    precio = (opcion == 1) ? 100 : 125;
                    break;

                case 3:
                    Console.WriteLine("Seleccione precio: 1=Q50, 2=Q75");
                    opcion = Convert.ToInt32(Console.ReadLine());
                    precio = (opcion == 1) ? 50 : 75;
                    break;

                case 4:
                    Console.WriteLine("Seleccione precio: 1=Q30, 2=Q50");
                    opcion = Convert.ToInt32(Console.ReadLine());
                    precio = (opcion == 1) ? 30 : 50;
                    break;

                default:
                    Console.WriteLine("Sector inválido");
                    Console.ReadLine();
                    return;
            }

            Console.Write("Ingrese cantidad de entradas: ");
            cantidad = Convert.ToInt32(Console.ReadLine());

            total = precio * cantidad;

            Console.WriteLine("Total a pagar: Q" + total);

            Console.WriteLine("Presione Enter para salir...");
            Console.ReadLine();
        }
    }
}
