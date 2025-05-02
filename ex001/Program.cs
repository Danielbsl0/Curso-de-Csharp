namespace ex003;

public class Program
{
    public static void Main()
    {
        Console.Write("Insira um número: ");
        float n = float.Parse(Console.ReadLine());
        float[] nums = {n};
        float soma = 0;
        int i = 1;
        Console.Write("Quer Continuar?: ");
        char resp = char.Parse(Console.ReadLine());
        while (resp != 'N')
        {
            float num = float.Parse(Console.ReadLine());
            nums[i] = num;
            i++;
            Console.Write("Quer Continuar?: ");
            resp = char.Parse(Console.ReadLine());
        }
        float maior = nums[0], menor = nums[0];
        for (int c = 0; c<nums.Length; c++)
        {
            soma += nums[c];
            if (c != 0)
            {
                if (maior < nums[c])
                {
                    maior = nums[c];
                }else if (menor < nums[c])
                {
                    menor = nums[c];
                }
            }
        }
        float media = soma / nums.Length;
        Console.WriteLine($"A média é: {media}\nO maior valor é: {maior}\nO menor valor é: {menor}");
    }
}
