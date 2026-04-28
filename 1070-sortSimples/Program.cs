using System;

class URI
{
    static void Main(string[] args)
    {
        // 1. Lendo a entrada
        string linha = Console.ReadLine();

        // Proteção contra entrada vazia (Dica de ouro para o mercado!)
        if (string.IsNullOrEmpty(linha)) return;

        string[] entrada = linha.Split(' ');

        // 2. Convertendo
        int a = int.Parse(entrada[0]);
        int b = int.Parse(entrada[1]);
        int c = int.Parse(entrada[2]);

        // 3. Criando a cópia para ordenar
        int[] ordenados = { a, b, c };
        Array.Sort(ordenados);

        // 4. Imprimindo os ordenados
        foreach (int numero in ordenados)
        {
            Console.WriteLine(numero);
        }

        // 5. Linha em branco obrigatória
        Console.WriteLine();

        // 6. Imprimindo os originais
        Console.WriteLine(a);
        Console.WriteLine(b);
        Console.WriteLine(c);
    }
}