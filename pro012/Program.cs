namespace pro012;

public class Program
{
    public static void Main()
    {
        int[,] m = new int[3, 3];

        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 3; j++)
            {
                m[i, j] = int.Parse(Console.ReadLine());
            }
        }

        Console.WriteLine();

        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 3; j++)
            {
                Console.WriteLine($"O número da posição {i+1} no array é: {m[i,j]}");
            }
        }
    }
}
