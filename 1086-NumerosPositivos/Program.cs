using System;
using System.ComponentModel;

class URI
{

    static void Main(string[] args)
    {

        int contador = 0;
        
        for (int i = 0; i < 6; i++)
        {
            double numero = double.Parse(Console.ReadLine());
            if (numero > 0)
            {
                contador++;
            }
        }
        
        Console.WriteLine($"{contador} valores positivos");

    }

}