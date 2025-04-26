namespace pro009;

public class Program
{
    enum DiasSemana {Domingo, Segunda, Terça, Quarta, Quinta, Sexta, Sábado};
    public static void Main()
    {
        DiasSemana ds = (DiasSemana)3;

        Console.WriteLine(ds);
    }
}
