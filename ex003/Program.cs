namespace ex003;

public class Program
{
    public static void Main()
    {
        int cont = 0;
        Console.Write("Insira uma palavra: ");
        string p = Console.ReadLine();
        for (int i = 0; i<p.Length; i++)
        {
            if (p[i] == 'a' || p[i] == 'e' || p[i] == 'i' || p[i] == 'o' || p[i] == 'u')
            {
                cont++;
            }
        }
        Console.WriteLine($"A quantidade de vogais é {cont}");
    }
}
