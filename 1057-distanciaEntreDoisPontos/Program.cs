using System;

class URI
{
    static void Main(string[] args)
    {

        // Lê a primeira linha: x1 e y1
        string[] linha1 = Console.ReadLine().Split(' ');
        double x1 = double.Parse(linha1[0]);
        double y1 = double.Parse(linha1[1]);

        // Lê a segunda linha: x2 e y2
        string[] linha2 = Console.ReadLine().Split(' ');
        double x2 = double.Parse(linha2[0]);
        double y2 = double.Parse(linha2[1]);

        // Aplica a fórmula
        double distancia = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));

        // Imprime com 4 casas decimais
        Console.WriteLine("{0:F4}", distancia);
    }
}