using System;
using System.Security.Cryptography.X509Certificates;

class URI
{

    static void Main(string[] args)
    {

        int funcionario = int.Parse(Console.ReadLine());
        int horas = int.Parse(Console.ReadLine());
        double valorHora = double.Parse(Console.ReadLine());

        void calcularSalario()
        {
            double salario = horas * valorHora;
            Console.WriteLine($"NUMBER = {funcionario}");
            Console.WriteLine($"SALARY = U$ {salario:F2}");
        }

        calcularSalario();

    }

}