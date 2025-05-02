namespace pro013;

public class Program
{
    public static void Main()
    {
        int[] n = {8, 7, 6, 5, 4, 3, 2, 1};

        int i = n.Length-1;

        while (i>=0)
        {
            Console.WriteLine(n[i]);
            i--;
        }
    }
}
