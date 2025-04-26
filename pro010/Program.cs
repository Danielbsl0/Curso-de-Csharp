namespace pro010;

public class Program
{
    public static void Main()
    {
        int tempo;
        int escolha;

        Console.Write("Escolha o seu meio de transporte para BH([1]Avião, [2]Carro, [3]Ônibus): ");
        escolha = int.Parse(Console.ReadLine());

        switch (escolha){
            case 1:
                tempo = 60;
                break;
            case 2:
                tempo = 480;
                break;
            case 3:
                tempo = 660;
                break;
            default:
                tempo = -1;
                break;
                                            

        }

        if (tempo != -1)
        {
            Console.WriteLine($"O seu tempo de viagem total é de: {tempo}");
        }
        else
        {
            Console.WriteLine("ERRO! Selecione uma opção de transporte válida");
        }
    }
}