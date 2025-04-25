namespace Aula006;

public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("-------VERIFICADOR DE NÚMERO PAR OU ÍMPAR--------");
        Console.Write("Insira um número: ");
        int num = int.Parse(Console.ReadLine());
        if (num % 2 == 0)
        {
            Console.WriteLine($"{num} é par!");
        }
        else
        {
            Console.WriteLine($"{num} é ímpar");
        }
        Console.WriteLine("FIM DO PROGRAMA!");
    }
}