using System;

class URI
{
    static void Main(string[] args)
    {
        double salario = double.Parse(Console.ReadLine());


        if(salario <= 2000)
        {
            Console.WriteLine("Isento");
        }else if (salario > 2000 && salario <= 3000) {
            double imposto = (salario - 2000) * 0.08;
            Console.WriteLine($"R$ {imposto:F2}");
        } else if (salario > 3000 && salario <= 4500) {
            double imposto = 80 + (salario - 3000) * 0.18;
            Console.WriteLine($"R$ {imposto:F2}");
        } else if (salario > 4500)
        {
            double imposto = 80 + 270 + (salario - 4500) * 0.28;
            Console.WriteLine($"R$ {imposto:F2}");
        }
    }
}