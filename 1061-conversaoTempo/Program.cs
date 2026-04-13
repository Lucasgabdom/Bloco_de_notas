using System;

class URI
{

    static void Main(string[] args)
    {

        int N = int.Parse(Console.ReadLine());

        int horas = N / 3600; //Quantas horas completas cabem dentro de N segundos.
        int minutos = (N % 3600) / 60; //Os segundos restantes depois de retirar as horas completas.
        int segundos = N % 60; // Os segundos restantes depois de retirar as horas completas e os minutos completos.

        Console.WriteLine($"{horas}:{minutos}:{segundos}");

    }

}