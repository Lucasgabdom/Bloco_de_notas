using System;
class URI
{

    static void Main(string[] args)
    {
        string[] linha1 = Console.ReadLine().Split(' ');
        string[] linha2 = Console.ReadLine().Split(' ');

        int qtd1 = int.Parse(linha1[1]);
        double valor1 = double.Parse(linha1[2]);

        int qtd2 = int.Parse(linha2[1]);
        double valor2 = double.Parse(linha2[2]);

        double total = (qtd1 * valor1) + (qtd2 * valor2);

        Console.WriteLine($"VALOR A PAGAR: R$ {total:F2}");
    }

}