using System;

class URI
{

    static void Main(string[] args)
    {

        int horas = int.Parse(Console.ReadLine());
        double VelocidadeMedia = double.Parse(Console.ReadLine());

        double consumo = VelocidadeMedia * horas / 12;

        Console.WriteLine(consumo.ToString("F3"));

    }

}