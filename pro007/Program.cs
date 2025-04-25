namespace pro007;

public class Program
{
    public static void Main()
    {
        int res = -1;
        float num = 0;
        float num2 = 0;
        Console.WriteLine("--------CALCULADORA--------");

        do
        {
            Console.Write("Insira um número: ");
            num = float.Parse(Console.ReadLine());
            Console.Write("Insira outro número: ");
            num2 = float.Parse(Console.ReadLine());
            Console.WriteLine("--------MENU DE OPERAÇÕES--------");
            Console.Write("SOMA[1]\nSUBTRAÇÃO[2]\nDIVISÃO[3]\nMULTIPLICAÇÃO[4]\nRESTO DA DIVISÃO[5]\nENCERRAR PROGRAMA[0]\nEsolha uma das operações: ");
            res = int.Parse(Console.ReadLine());
            if (res == 1)
            {
                Console.WriteLine($"{num + num2}");
            }
            else if (res == 2)
            {
                Console.WriteLine($"{num - num2}");
            }
            else if (res == 3)
            {
                Console.WriteLine($"{num / num2}");
            }
            else if (res == 4)
            {
                Console.WriteLine($"{num * num2}");
            }
            else if (res == 5)
            {
                Console.WriteLine($"{num % num2}");
            }

        } while (res != 0);
        Console.WriteLine("-------FIM DO PROGRAMA-------");
    }

}


