namespace teste;

public class Program
{
    public static void Main()
    {
        int c1, b1, p1, c2, b2, p2;
        c1 = Console.Read();
        b1 = Console.Read();
        p1 = Console.Read();
        c2 = Console.Read();
        b2 = Console.Read();
        p2 = Console.Read();

        int somac = c2 - c1;
        int somab = b2 - b1;
        int somap = p2 - p1;

        if (somac < 0)
        {
            somac = 0;
        }
        if (somab < 0)
        {
            somab = 0;
        }
        if (somap < 0)
        {
            somap = 0;
        }

        //int soma = somab + somac + somap;

        Console.WriteLine($"{somac} {somab} {somap}");
        
    }
}