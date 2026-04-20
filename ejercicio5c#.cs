using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication25
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero;
            string mes = "";
            int dias = 0;

            Console.Write("Ingrese un número del 1 al 12: ");
            numero = Convert.ToInt32(Console.ReadLine());

            switch (numero)
            {
                case 1: mes = "Enero"; dias = 31; break;
                case 2: mes = "Febrero"; dias = 28; break;
                case 3: mes = "Marzo"; dias = 31; break;
                case 4: mes = "Abril"; dias = 30; break;
                case 5: mes = "Mayo"; dias = 31; break;
                case 6: mes = "Junio"; dias = 30; break;
                case 7: mes = "Julio"; dias = 31; break;
                case 8: mes = "Agosto"; dias = 31; break;
                case 9: mes = "Septiembre"; dias = 30; break;
                case 10: mes = "Octubre"; dias = 31; break;
                case 11: mes = "Noviembre"; dias = 30; break;
                case 12: mes = "Diciembre"; dias = 31; break;
                default:
                    Console.WriteLine("Número inválido");
                    Console.ReadLine(); // pausa
                    return;
            }

            Console.WriteLine("Mes: " + mes);
            Console.WriteLine("Días: " + dias);

            Console.ReadLine(); // ← esto evita que se cierre
        
        }
    }
}
