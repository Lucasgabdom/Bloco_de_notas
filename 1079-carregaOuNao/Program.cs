using System;

class URI
{

    static void Main(string[] args)
    {

        string line;
        while ((line = Console.ReadLine()) != null)
        {
            line = line.Trim();
            if (line == "") continue;

            string[] parts = line.Split(' ');
            uint a = uint.Parse(parts[0]);
            uint b = uint.Parse(parts[1]);

            Console.WriteLine(a ^ b);
        }

    }

}