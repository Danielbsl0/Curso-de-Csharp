namespace Aula004;

public class Program
{
    public static void Main()
    {
        Console.WriteLine("------LOGIN------");
        Console.Write("Insira o seu nome: ");
        string nome = Console.ReadLine();
        Console.Write("Insira a sua idade");
        int idade = int.Parse(Console.ReadLine());
        Console.WriteLine($"Login efetuado com sucesso! Olá, {nome} que tem {idade} anos");

    }
}