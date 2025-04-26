namespace pro011;

public class Program
{
    public static void Main()
    {
        int[] num = new int[5];

        for (int i = 0; i<5; i++)
        {
            num[i] = int.Parse(Console.ReadLine());
        }

        for (int i = 0; i < 5; i++)
        {
            Console.WriteLine(num[i]);
        }
    }
}
