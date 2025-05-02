namespace ex005
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int h;
            Console.Write("Insira a hora atual: ");
            h = int.Parse(Console.ReadLine());
            if (h < 6)
            {
                Console.WriteLine("Está de madrugada!");
            }else if(h < 12)
            {
                Console.WriteLine("Bom dia!");
            }else if (h < 18)
            {
                Console.WriteLine("Boa tarde!");
            }
            else
            {
                Console.WriteLine("Boa noite!");
            }
        }
    }
}
