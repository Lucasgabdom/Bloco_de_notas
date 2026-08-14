class URI
{

    static void Main(string[] args)
    {

        string linha1 = Console.ReadLine();
        int diaInicio = int.Parse(linha1.Split()[1]);

        string horaInicioStr = LimparHora(Console.ReadLine());

        string linha3 = Console.ReadLine();
        int diaFim = int.Parse(linha3.Split()[1]);

        string HoraFinal = LimparHora(Console.ReadLine());

        TimeSpan horaInicio = TimeSpan.Parse(horaInicioStr);
        TimeSpan horaFinal = TimeSpan.Parse(HoraFinal);

        DateTime inicio = new DateTime(2024, 4, diaInicio) + horaInicio;
        DateTime fim = new DateTime(2024, 4, diaFim) + horaFinal;

        TimeSpan duracao = fim - inicio;

        Console.WriteLine($"{duracao.Days} dia(s)");
        Console.WriteLine($"{duracao.Hours} hora(s)");
        Console.WriteLine($"{duracao.Minutes} minuto(s)");
        Console.WriteLine($"{duracao.Seconds} segundo(s)");




    }

    static string LimparHora(string linha)
    {
        return linha.Replace(" :", " ");
    }

}