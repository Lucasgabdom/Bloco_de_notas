using System;

class URI
{

    static void Main(string[] args)
    {

        string[] entrada = Console.ReadLine().Split(' ');

        double a = double.Parse(entrada[0]);
        double b = double.Parse(entrada[1]);
        double c = double.Parse(entrada[2]);


        if (a < b + c && b < a + c && c < a + b)
        {
            double perimetro = a + b + c;
            Console.WriteLine($"Perimetro = {perimetro:F1}");
        }
        else
        {
            double area = ((a + b) * c / 2);
            Console.WriteLine($"Area = {area:F1}");
        }
    }
}