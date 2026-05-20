using System;
using System.Collections.Generic;

class URI
{
    static int Josephus(int totalpessoas, int tamanhoSalto)
    {
        List<int> circulo = new List<int>();
        for (int i = 1; i <= totalpessoas; i++)
            circulo.Add(i);

        circulo.RemoveAt(0);

        int posicaoAtual = (tamanhoSalto - 1) % circulo.Count;

        while (circulo.Count > 1)
        {
            circulo.RemoveAt(posicaoAtual);
            posicaoAtual = (posicaoAtual + tamanhoSalto - 1) % circulo.Count;
        }

        return circulo[0];

    }

    static void Main(string[] args)
    {
        string linha;
        while ((linha = Console.ReadLine()) != null)
        {
            int n = int.Parse(linha);
            if (n == 0) break;


            int salto = 1;
            while (true)
            {
                if (Josephus(n, salto) == 13)
                    break;
                salto++;
            }

            Console.WriteLine(salto);
        }
    }
}