using System;
using System.Runtime.Serialization;

class URI
{

    static void Main(string[] args)
    {

        double salario = double.Parse(Console.ReadLine());


        if (salario >= 0 && salario <= 400.00)
        {
            double resultado = salario * 0.15;
            double novoSalario = salario + resultado;
            Console.WriteLine($"Novo salario: {novoSalario:F2}");
            Console.WriteLine($"Reajuste ganho: {resultado:F2}");
            Console.WriteLine("Em percentual: 15%");

        }
        else if (salario > 400.00 && salario <= 800.00)
        {
            double resultado = salario * 0.12;
            double novoSalario = salario + resultado;
            Console.WriteLine($"Novo salario: {novoSalario:F2}");
            Console.WriteLine($"Reajuste ganho: {resultado:F2}");
            Console.WriteLine("Em percentual: 12%");
        }
        else if (salario > 800.00 && salario <= 1200.00)
        {
            double resultado = salario * 0.10;
            double novoSalario = salario + resultado;
            Console.WriteLine($"Novo salario: {novoSalario:F2}");
            Console.WriteLine($"Reajuste ganho: {resultado:F2}");
            Console.WriteLine("Em percentual: 10%");
        }
        else if (salario > 1200.00 && salario <= 2000.00)
        {
            double resultado = salario * 0.07;
            double novoSalario = salario + resultado;
            Console.WriteLine($"Novo salario: {novoSalario:F2}");
            Console.WriteLine($"Reajuste ganho: {resultado:F2}");
            Console.WriteLine("Em percentual: 7%");
        }
        else if (salario > 2000.00)
        {
            double resultado = salario * 0.04;
            double novoSalario = salario + resultado;
            Console.WriteLine($"Novo salario: {novoSalario:F2}");
            Console.WriteLine($"Reajuste ganho: {resultado:F2}");
            Console.WriteLine("Em percentual: 4%");
        }   



    }

}