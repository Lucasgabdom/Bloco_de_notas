using System;

class URI
{

    static void Main(string[] args)
    {

        int N = int.Parse(Console.ReadLine());
        int[] notas = { 100, 50, 20, 10, 5, 2, 1 };

        Console.WriteLine(N);

        foreach (int nota in notas)
        {
            int quantidade = N / nota;
            N = N % nota; /*O operador % é o operador de módulo, que retorna o restante da divisão inteira.
                           Ele está praticamente dizendo: "Olha, N a partir de agora é o que sobrou depois de 
                           retirar as notas que já foram contadas".
                           */
            Console.WriteLine($"{quantidade} nota(s) de R$ {nota},00");


            /* "nota" guarda a posição do array. na primeira volta nota é 100, na segunda 50, na terceira 20, 
             * e assim por diante. Já "notas" é o array que guarda as notas disponíveis.*/


        }


    }

}