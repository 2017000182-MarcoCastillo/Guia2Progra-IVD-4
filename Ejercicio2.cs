internal class Program
{
    //pide dos numero
    private static void Main(string[] args)
    {
        Console.WriteLine("ESCRIBA DOS VALORES NUMERICOS");
        double num1=Convert.ToDouble(Console.ReadLine());
        double num2 = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("\n***MENU PRINCIPAL***");
        Console.WriteLine("1- SUMA");
        Console.WriteLine("2- resta");
        Console.WriteLine("3- MULTIPLICSCION");
        Console.WriteLine("4- DIVISION");
        Console.WriteLine("5- Saltar");
        Console.WriteLine("Digite el valor segun la operacion: []");
        int opc=Convert.ToInt32(Console.ReadLine());

        //Evaluar con switch
        String msj = "";
        double result=0;
        switch (opc)
        {
            case 1:
                msj = "\nLa suma\n es: ";
                result = num1+num2;
                break;
            case 2:
                msj = "\nLa resta\n es: ";
                result = num1 - num2;
                break;
            case 3:
                msj = "\nLa MULTIPLICACION\n es: ";
                result = num1 * num2;
                break;
            case 4:
                msj = "\nLa Division\n es: ";
                result = num1 / num2;
                break;
            case 5:
                msj = "Saliendo del sistema..: ";
                break;
            default:
                msj = "Digite una opcion valida";
                break;

        }
        Console.Clear();
        Console.BackgroundColor = ConsoleColor.Green;
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine(msj);
        Console.WriteLine(result);
    }
}