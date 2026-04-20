using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication27
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ingrese un carácter: ");
            string input = Console.ReadLine();

            if (input.Length != 1)
            {
                Console.WriteLine("Debe ingresar solo un carácter");
                Console.ReadLine();
                return;
            }

            char c = input[0];

            if ("aeiouAEIOU".Contains(c))
            {
                Console.WriteLine("Es una vocal");
            }
            else if (char.IsDigit(c))
            {
                Console.WriteLine("Es un dígito");
            }
            else
            {
                Console.WriteLine("No es vocal ni dígito");
            }

            Console.WriteLine("Presione Enter para salir...");
            Console.ReadLine(); // evita que se cierre
        }
    }
}
