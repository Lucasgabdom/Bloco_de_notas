using System;
using System.Globalization;

class URI
{
    static void Main(string[] args)
    {

        //cultureinfo ele garante que o ponto seja interpretado como separador decimal, mesmo em culturas difrentes.
        double valor = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture); 

        // Nessa caso multiplicamos o valor por 100 para converter de reais para centavos.
        int valorEmCentavos = (int)Math.Round(valor * 100);

        int[] divisoes = { 10000, 5000, 2000, 1000, 500, 200, 100, 50, 25, 10, 5, 1 };

        Console.WriteLine("NOTAS:");

        bool moedasImpressas = false;

        // o foreach percorre o array fazendo as modificações necessárias a cada iteração.
        foreach (int i in divisoes) 
        {
            int quantidade = valorEmCentavos / i;
            valorEmCentavos = valorEmCentavos % i;


            /*Usamoso um if para verificar se a nota já foi imprido e*/
            if (i <= 100 && !moedasImpressas) 
            {
                Console.WriteLine("MOEDAS:");
                moedasImpressas = true;
            }
            //nesse caso denominamos o tipo, caso seja notas ou moedas, usando o operador ternário para simplificar a estrutura de decisão.
            string tipo = i > 100 ? "nota(s)" : "moeda(s)";
            
            // Convertendo o valor de centavos para reais, dividindo por 100.0 para garantir que o resultado seja um número de ponto flutuante.
            double valorReal = i / 100.0;

            //aqui imprimos o resultado de toda a operação.
            Console.WriteLine($"{quantidade} {tipo} de R$ {valorReal.ToString("F2", CultureInfo.InvariantCulture)}"); 
        }
    }
}