using System;

class URI
{

    static void Main(string[] args)
    {

        int distancia = int.Parse(Console.ReadLine());
        double consumo = double.Parse(Console.ReadLine());

        double media = distancia / consumo;
        Console.WriteLine(media.ToString("F3") + " km/l");



    }

}