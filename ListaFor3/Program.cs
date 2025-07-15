int num;
string bin = "";
bool isValid;
do
{
    Console.Write("Insira um número inteiro: ");
    isValid = int.TryParse(Console.ReadLine(), out num);

    if (isValid)
    {
        if (num < 0)
        {
            Console.WriteLine("Por favor, insira um número inteiro positivo.");
            isValid = false;
            continue;
        }
        else if (num == 0)
        {
            bin = "0";
        }

    }
    else
    {
        Console.WriteLine("Entrada inválida, por favor insira um valor válido");
    }
} while (!isValid);
for (int i = num; i >= 1; i /= 2)
{
    if (i > 1)
    {
        bin = Convert.ToString(i % 2) + bin;
    }
    else
    {
        bin = Convert.ToString(i) + bin;
    }
}

Console.WriteLine(bin);