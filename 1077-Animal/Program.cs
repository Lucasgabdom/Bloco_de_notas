using System;

class URI
{

    static void Main(string[] args)
    {

        String[] Entrada = Console.ReadLine().Split(' ');

        string Filo = Entrada[0];
        string Classe = Entrada[1];
        string Ordem = Entrada[2];

        if (Filo == "vertebrado" && Classe == "ave" && Ordem == "carnivoro")
        {
            Console.WriteLine("aguia");
        } else if (Filo == "vertebrado" && Classe == "ave" && Ordem == "onivoro")
        {
            Console.WriteLine("pomba");
        }
        else if (Filo == "vertebrado" && Classe == "mamifero" && Ordem == "onivoro")
        {
            Console.WriteLine("homem");
        }
        else if (Filo == "vertebrado" && Classe == "mamifero" && Ordem == "herbivoro")
        {
            Console.WriteLine("vaca");
        }
        else if (Filo == "invertebrado" && Classe == "inseto" && Ordem == "hematofago")
        {
            Console.WriteLine("pulga");
        }
        else if (Filo == "invertebrado" && Classe == "inseto" && Ordem == "herbivoro")
        {
            Console.WriteLine("lagarta");
        }
        else if (Filo == "invertebrado" && Classe == "anelideo" && Ordem == "hematofago")
        {
            Console.WriteLine("sanguessuga");
        }
        else if (Filo == "invertebrado" && Classe == "anelideo" && Ordem == "onivoro")
        {
            Console.WriteLine("minhoca");
        }

    }

}