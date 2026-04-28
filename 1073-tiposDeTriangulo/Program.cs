using System;

class URI
{

    static void Main(string[] args)
    {

        String[] entrada = Console.ReadLine().Split(' ');

        double[] lados =
        {
            double.Parse(entrada[0]),
            double.Parse(entrada[1]),
            double.Parse(entrada[2])
        };

        Array.Sort(lados);
        Array.Reverse(lados);

        double a = lados[0];
        double b = lados[1];
        double c = lados[2];

        bool formaTriangulo = a < b + c;

        
        if (!formaTriangulo)
        {
            Console.WriteLine("NAO FORMA TRIANGULO");
            return;
        }

       
        if (a * a == b * b + c * c)
        {
            Console.WriteLine("TRIANGULO RETANGULO");
        }
        else if (a * a > b * b + c * c)
        {
            Console.WriteLine("TRIANGULO OBTUSANGULO");
        }
        else if (a * a < b * b + c * c)
        {
            Console.WriteLine("TRIANGULO ACUTANGULO");
        }


        if (formaTriangulo && a == b && b == c)
        {
            Console.WriteLine("TRIANGULO EQUILATERO");
        }
        else if (a == b || a == c || b == c)
        {
            Console.WriteLine("TRIANGULO ISOSCELES");
        }
    }
}