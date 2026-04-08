using System;

class URI
{

    static void Main(string[] args){

        string[] entrada = Console.ReadLine().Split(' ');

        double a = double.Parse(entrada[0]);
        double b = double.Parse(entrada[1]);
        double c = double.Parse(entrada[2]);

        double areaTrianguloRentagulo = (a*c) / 2.0;
        double areaCirculo = 3.14159 * Math.Pow(c, 2);
        double areaTrapezio = ((a +b) * c) / 2.0;
        double areaQuadrado = b * b;
        double areaRetangulo = a * b;

        Console.WriteLine("TRIANGULO: " + areaTrianguloRentagulo.ToString("F3"));
        Console.WriteLine("CIRCULO: " + areaCirculo.ToString("F3"));
        Console.WriteLine("TRAPEZIO: " + areaTrapezio.ToString("F3"));
        Console.WriteLine("QUADRADO: " + areaQuadrado.ToString("F3"));
        Console.WriteLine("RETANGULO: " + areaRetangulo.ToString("F3"));

    }
}
