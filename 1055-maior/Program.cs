using System;
using System.Globalization;

class URI
{

    static void Main(string[] args)
    {

        string[] entrada = Console.ReadLine().Split(' ');

        double a = double.Parse(entrada[0], CultureInfo.InvariantCulture);
        double b = double.Parse(entrada[1], CultureInfo.InvariantCulture);
        double c = double.Parse(entrada[2], CultureInfo.InvariantCulture);

        double maiorAB = (a + b + Math.Abs(a - b)) / 2;

        double maiorAC = (maiorAB + c + Math.Abs(maiorAB - c)) / 2;

        Console.WriteLine(maiorAC + " eh o maior");

    }

}