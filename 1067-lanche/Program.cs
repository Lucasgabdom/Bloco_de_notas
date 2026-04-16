using System;
using System.Globalization;

class URI
{

    static void Main(string[] args)
    {
        //Requisição para o usuário digitar o código do lanche e a quantidade
        string[] entrada = Console.ReadLine().Split(' ');

        //Acessa no array as informações necessárias.
        int codigo = int.Parse(entrada[0]);
        int quantidade = int.Parse(entrada[1]);

        //Definindo que o preco do lanche é do tipo double, para que seja possível calcular o valor total.
        double preco = 0.0;

        //usando switch para definir o preço de cada lanche, de acordo com o código digitado pelo usuário.
        switch (codigo)
        {
            case 1:
                preco = 4.00;                
                break;
            case 2:
                preco = 4.50;
                break;
            case 3:
                preco = 5.00;               
                break;
            case 4:
                preco = 2.00;               
                break;
            case 5:
                preco = 1.50;
                break;
        }

        //calculando o valor total.
        double total = preco * quantidade;

        //convertendo o valor total para o formato de moeda brasileira, usando a cultura "pt-BR".
        Console.WriteLine($"Total: R$ {total.ToString("F2", new CultureInfo("pt-BR"))}");

    }

}