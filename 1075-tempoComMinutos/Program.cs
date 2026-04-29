using System;

class URI
{

    static void Main(string[] args)
    {

        string[] entrada = Console.ReadLine().Split(' ');

        int horaInicial = int.Parse(entrada[0]);
        int minutoInicial = int.Parse(entrada[1]);
        int horaFinal = int.Parse(entrada[2]);
        int minutofinal = int.Parse(entrada[3]);

        int totalInicial = horaInicial * 60 + minutoInicial;
        int totalFinal = horaFinal * 60 + minutofinal;

        int diferenca = totalFinal - totalInicial;

        if (diferenca < 0) { 
            diferenca += 1440;
        }

        int hora = diferenca / 60;
        int minuto = diferenca % 60;

        Console.WriteLine($"O JOGO DUROU {hora} HORA(S) E {minuto} MINUTO(S)");
    }

}