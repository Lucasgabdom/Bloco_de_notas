using System;
using System.Collections.Generic;

class URI
{

    static void Main(string[] args)
    {
        int totalCasos = int.Parse(Console.ReadLine());

        for (int caso = 1; caso <= totalCasos; caso++)
        {
            string[] entrada = Console.ReadLine().Split(' ');
            int totalPessoas = int.Parse(entrada[0]);
            int tamanhoSalto = int.Parse(entrada[1]);

            // Monta o círculo
            List<int> circulo = new List<int>();
            for (int i = 1; i <= totalPessoas; i++)
                circulo.Add(i);

            // Simula as eliminações
            int posicaoAtual = 0;
            while (circulo.Count > 1)
            {
                posicaoAtual = (posicaoAtual + tamanhoSalto - 1) % circulo.Count;
                circulo.RemoveAt(posicaoAtual);
                posicaoAtual = posicaoAtual % circulo.Count;
            }

            Console.WriteLine($"Case {caso}: {circulo[0]}");
        }


    }

}