using System;

class URI
{

    static void Main(string[] args)
    {

        int idadeDias = int.Parse(Console.ReadLine());

        int ano = 365;
        int mes = 30;


        int anos = idadeDias / ano;
        int restoDosAnos = idadeDias % ano;

        int meses = restoDosAnos / mes;
        int restoDosMeses = restoDosAnos % mes;

        int dias = restoDosMeses;

        Console.WriteLine($"{anos} ano(s)");
        Console.WriteLine($"{meses} mes(es)");
        Console.WriteLine($"{dias} dia(s)");

    }

}
