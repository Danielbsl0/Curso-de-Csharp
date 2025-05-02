namespace ex004
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double n1, n2;
            int op;
            Console.Write("INsira um número: ");
            n1 = double.Parse(Console.ReadLine());
            Console.Write("Insira outro número: ");
            n2 = double.Parse(Console.ReadLine());
            Console.Write("Soma[1]\nDiferença[2]\nProduto[3]\nDivisão[4]\nInsira a operação desejada: ");
            op = int.Parse(Console.ReadLine());

            switch (op)
            {
                case 1:
                    Console.WriteLine($"{n1 + n2}");
                    break;
                case 2:
                    Console.WriteLine($"{n1 - n2}");
                    break;
                case 3:
                    Console.WriteLine($"{n1*n2}");
                    break;
                case 4:
                    Console.WriteLine($"{n1/n2}");
                    break;
                default:
                    Console.WriteLine("Operação inválida, tente novamente!");
                    break;
            }
        }
    }
}
