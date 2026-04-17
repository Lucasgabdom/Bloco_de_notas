using System;
using System.Data;

class URI
{

    static void Main(string[] args)
    {

        string[] entrada = Console.ReadLine().Split(' ');

        int a = int.Parse(entrada[0]);
        int b = int.Parse(entrada[1]);
        int c = int.Parse(entrada[2]);

        int[] ordenados = {a,b,c};

        Array.Sort(ordenados);

        foreach (int numero in ordenados)
        {
            Console.WriteLine(numero);
        }
        Console.WriteLine();

        Console.WriteLine(a);
        Console.WriteLine(b);
        Console.WriteLine(c);
    }

}