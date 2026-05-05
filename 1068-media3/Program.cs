using System;
using System.Globalization;
using System.Security.Cryptography;

    
class URI
{

    static void Main(string[] args)
    {

        string[] entrada = Console.ReadLine().Split(' ');

        double n1 = double.Parse(entrada[0], CultureInfo.InvariantCulture);
        double n2 = double.Parse(entrada[1], CultureInfo.InvariantCulture);
        double n3 = double.Parse(entrada[2], CultureInfo.InvariantCulture);
        double n4 = double.Parse(entrada[3], CultureInfo.InvariantCulture);

        double media = (n1*2 + n2*3 + n3*4 + n4*1) / 10;
        double mediaTrucada = Math.Truncate(media * 10) / 10;

        if (media >= 7.0)
        {
            Console.WriteLine("Media: " + mediaTrucada.ToString("F1", CultureInfo.InvariantCulture));
            Console.WriteLine("Aluno aprovado.");
        } else if (media >= 5.0)
        {
            Console.WriteLine($"Media: " + mediaTrucada.ToString("F1", CultureInfo.InvariantCulture));
            Console.WriteLine("Aluno em exame.");

            double provaExtra = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double mediaFinal = (provaExtra + media) / 2;
            double mediaFinalTruncada = Math.Truncate(mediaFinal * 10) / 10;

            if (mediaFinalTruncada >= 5.0)
            {
                Console.WriteLine("Nota do exame: " + provaExtra.ToString("F1", CultureInfo.InvariantCulture));
                Console.WriteLine("Aluno aprovado.");
                Console.WriteLine("Media final: " + mediaFinalTruncada.ToString("F1", CultureInfo.InvariantCulture));
            } else
            {
                Console.WriteLine("Nota do exame:" + provaExtra.ToString("F1", CultureInfo.InvariantCulture));
                Console.WriteLine("Aluno reprovado.");
                Console.WriteLine("Media final: " + mediaFinalTruncada.ToString("F1", CultureInfo.InvariantCulture));
            }


        } else
        {
            Console.WriteLine($"Media: {mediaTrucada:F1}");
            Console.WriteLine("Aluno reprovado.");
        }
    }

}
