using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication30
{
    class Program
    {
        static void Main(string[] args)
        {
            int cantidad, opcion;
            double precioSinIVA = 650;
            double precioConIVA = precioSinIVA * 1.12;
            double totalSinDesc, descuento = 0, totalPagar;
            string formaPago = "";

            Console.WriteLine("===== T&S, S.A =====");
            Console.Write("Ingrese cantidad de impresoras: ");
            cantidad = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Forma de pago:");
            Console.WriteLine("1. Efectivo (10%)");
            Console.WriteLine("2. Tarjeta de crédito (5%)");
            Console.WriteLine("3. Vale de regalo (15%)");

            opcion = Convert.ToInt32(Console.ReadLine());

            totalSinDesc = precioConIVA * cantidad;

            switch (opcion)
            {
                case 1:
                    formaPago = "Efectivo";
                    descuento = totalSinDesc * 0.10;
                    break;

                case 2:
                    formaPago = "Tarjeta de crédito";
                    descuento = totalSinDesc * 0.05;
                    break;

                case 3:
                    formaPago = "Vale de regalo";
                    descuento = totalSinDesc * 0.15;
                    break;

                default:
                    Console.WriteLine("Opción inválida");
                    Console.ReadLine();
                    return;
            }

            totalPagar = totalSinDesc - descuento;

            Console.WriteLine("\n===== DETALLE DE COMPRA =====");
            Console.WriteLine("Cantidad: " + cantidad);
            Console.WriteLine("Precio unitario con IVA: Q" + precioConIVA);
            Console.WriteLine("Total sin descuento: Q" + totalSinDesc);
            Console.WriteLine("Forma de pago: " + formaPago);
            Console.WriteLine("Descuento: Q" + descuento);
            Console.WriteLine("Total a pagar: Q" + totalPagar);

            Console.WriteLine("\nPresione Enter para salir...");
            Console.ReadLine();
        }
    }
}
