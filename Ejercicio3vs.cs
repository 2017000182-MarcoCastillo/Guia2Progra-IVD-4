internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Rango de estudiantes");
        Console.WriteLine("INGRESE UNA LETRA (A, B, C, D, F");
        char letra = char.ToUpper(Console.ReadKey().KeyChar);
        Console.WriteLine();

        switch (letra)
        {
            case'A':
                Console.WriteLine("Excelente");
                break;
            case 'B':
                Console.WriteLine("Excelente");
                break;
            case 'C':
                Console.WriteLine("Excelente");
                break;
            case 'D':
                Console.WriteLine("Excelente");
                break;
            case 'F':
                Console.WriteLine("Excelente");
                break;
        }
    }
}