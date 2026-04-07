using System;

class URI
{

    static void Main(string[] args)
    {

        double raio = float.Parse(Console.ReadLine());
        double pi = 3.14159;
        double volume = (4.0 / 3) * pi * Math.Pow(raio, 3);

        Console.WriteLine("VOLUME = " + volume.ToString("F3"));

        // no double volume o 4.0 é escrito com ponto para indicar que é um número de ponto flutuante, e não um inteiro. Isso é importante porque a divisão entre um inteiro e outro inteiro pode resultar em um número inteiro, o que não é o caso aqui, já que queremos um resultado de ponto flutuante. Portanto, ao usar 4.0, garantimos que a divisão seja realizada corretamente e o resultado seja um número de ponto flutuante, mesmo que o valor de pi seja uma constante.



    }

}