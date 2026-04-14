using System;

class URI
{

    static void Main(string[] args)
    {
        //Usamos um array para poder ler os valores.
        string[] entrada = Console.ReadLine().Split(' ');

        double a = double.Parse(entrada[0]);
        double b = double.Parse(entrada[1]);
        double c = double.Parse(entrada[2]);


        //Calculando delta
        double delta = (b*b) - (4 * a * c);



        //Verificando se é possível calcular as raízes. Se a for igual a zero, não será possível calcular. Ou se delta não for positivo, não será possível calcular.
        if (a == 0 || delta < 0)
        {
            Console.WriteLine("Impossivel calcular");
        } else
        {

            //Calculando as raizes usando a fórmula de Bhaskara. aonde seria -b + raiz de delta dividido por 2 vezes a, e -b - raiz de delta dividido por 2 vezes a.
            double r1 = (-b + Math.Sqrt(delta)) / (2 * a);
            double r2 = (-b - Math.Sqrt(delta)) / (2 * a);


            //Nesssa parte imprimimos o resultando, usando a formatação para mostrar apenas 5 casas decimais, usando o formato F5.
            Console.WriteLine($"R1 = {r1:F5}");
            Console.WriteLine($"R2 = {r2:F5}");
        }

    }

}