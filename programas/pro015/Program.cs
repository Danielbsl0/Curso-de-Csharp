int[] vet1 = new int[5];
int[] vet2 = new int[5];
int[] vet3 = new int[5];
int[,] matriz = new int[2, 5] {11, 22, 00, 44, 55}, {66, 77, 88, 99, 00};

Random random = new Random();
for (int i = 0; i<vet1.Length; i++)
{
    vet1[i] = random.Next(50);
}

Console.WriteLine("Elementos do vetor1");
foreach(int n in vet1)
{
    Console.WriteLine(i);
}

Console.WriteLine(48 * '-');

//Método BinarySearch
int proc = 33;
int pos = Array.BinarySearch(vet1, proc);
if (pos != -1)
{
    Console.WriteLine($"Valor {proc} está na posição {pos}");
}

Console.WriteLine(48 * '-');

//Método Copy
Array.Copy(vet1, vet2, vet2.Length);
foreach(int n in vet2)
{
    Console.WriteLine(n);
}

Console.WriteLine(48 * '-');

//CopyTo
vet1.CopyTo(vet3, 0);
foreach(int n in vet3)
{
    Console.WriteLine(n);
}

Console.WriteLine(48 * '-');

//Método GetLongLenght(dimensao)
int qntElem = vet1.GetLongLength(0);
Console.WriteLine($"Quantidade de elementos {qntElem}");

Console.WriteLine(48 * '-');

//Método GetLowerBound(dimensao)
int menInd = vet1.GetLowerBound(0);
int menIndMt1 = matriz.GetLowerBound(1);
Console.WriteLine($"Menor índice do vetor1 é {menInd}");

Console.WriteLine(48 * '-');

//Método GetUpperBound(dimensao)
int maiInd = vet1.GetUpperBound(0);
int maiIndMt1 = matriz.GetUpperBound(1);
Console.WriteLine($"Maior índice do vetor1 é {maiIndMt1}");

Console.WriteLine(48 * '-');


//Método GetValue(dimensao, índice) -> Retorna um objeto
int valor = Convert.ToInt32(vet1.GetValue(3));
Console.WriteLine($"Valor da posição 3 no vetor 1 é: {valor}");

Console.WriteLine(48 * '-');

//Método IndexOf
int ind = Array.IndexOf(vet1, 3);
Console.WriteLine("Índice do valor 3 no vetor1 é: " + ind);

Console.WriteLine(48 * '-');

//Método LastIndexOf
int lastInd = Array.LastIndexOf(vet1, 3);
Console.WriteLine("Último índice do valor 3 no vetor1 é: " + lastInd);

Console.WriteLine(48 * '-');

//Método Reverse
Array.Reverse(vet1);
Console.WriteLine($"Vetor1 após o Reverse: {vet1}");

Console.WriteLine(48 * '-');

//Método SetValue(dimensao, valor, índice)
vet2.SetValue(99, 0);
for(int i=1; i<vet2.Length; i++)
{
    vet2.SetValue(0, i);
}

foreach(int n in vet2)
{
    Console.WriteLine(n);
}

Console.WriteLine(48 * '-');

//Método Sort
Array.Sort(vet1);
Array.Sort(vet2);
Array.Sort(vet3);

Console.WriteLine("Vetor1 ordenado:");
foreach(int n in vet3)
{
    Console.WriteLine(n);
}

Console.WriteLine("Vetor2 ordenado:");
foreach(int n in vet2)
{
    Console.WriteLine(n);
}

Console.WriteLine("Vetor3 ordenado:");
foreach(int n in vet3)
{
    Console.WriteLine(n);
}

Console.WriteLine(48 * '-');
