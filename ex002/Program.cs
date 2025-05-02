namespace ex001;

public class Program
{
    public static void Main()
    {
        Console.WriteLine("Digite um número: ");
        int n = int.Parse(Console.ReadLine());
        if (n % 2 == 0)
        {
            Console.WriteLine("É par");
        }
        else
        {
            Console.WriteLine("É ímpar");
        }
    }
}