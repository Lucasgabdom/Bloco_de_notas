using System;

class URI
{

    static void Main(string[] args)
    {

        string[] entrada = Console.ReadLine().Split(' ');

        int a = int.Parse(entrada[0]);
        int b = int.Parse(entrada[1]);
        int c = int.Parse(entrada[2]);
        int d = int.Parse(entrada[3]);

        if (b > c && d > a && (c + d) > (a + b) && (c > 0) && (d>0) && (a % 2 == 0)) {
            Console.WriteLine("Valores aceitos");
        } else { Console.WriteLine("Valores nao aceitos"); }

        /*
         Para conferir se um valor é positivo ou negativo, podemos usar o zero com referência. Se for maior, 
         é positivo, se for menor, negativo.

         Para verificar se um número é par, podemos usar o operador de módulo (%), se a divisão por 2 resultar 
         em zero, o número é par.        
         */
            
    }

}