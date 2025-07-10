string palavra;
int cont = 0;

Console.WriteLine("Digite uma palavra: ");
palavra = Console.ReadLine();

for (int i = 1; i < palavra.Length; i++) { 
    if (palavra[i] == 'a' || palavra[i] == 'e' || palavra[i] == 'i' ||
        palavra[i] == 'o' || palavra[i] == 'u')
    {
        cont++;
    }
}

Console.WriteLine($"A quantidade de vogais na palavra é: {cont}");