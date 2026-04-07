using System;

class URI
{

    static void Main(string[] args)
    {

        string nome = Console.ReadLine ();
        double salarioFixo = double.Parse (Console.ReadLine ());
        double vendas = double.Parse (Console.ReadLine ());

        double comissao = vendas * 0.15;
        double total = salarioFixo + comissao;

        Console.WriteLine ("TOTAL = R$ " + total.ToString("F2"));



    }

}