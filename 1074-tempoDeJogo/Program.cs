using System;

class URI
{

    static void Main(string[] args)
    {

        string[] entrada = Console.ReadLine().Split(' ');

        int horaInicial = int.Parse(entrada[0]);
        int horaFinal = int.Parse(entrada[1]);

        int calcularHora = horaFinal - horaInicial;

        if (calcularHora > 0)
        {
            Console.WriteLine($"O JOGO DUROU {calcularHora} HORA(S)");
        } else
        {
            Console.WriteLine($"O JOGO DUROU {24 + calcularHora} HORA(S)");
        }
    }

}