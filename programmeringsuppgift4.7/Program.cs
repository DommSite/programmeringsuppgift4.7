using System;

namespace inlämningsuppgift4_7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Skriv in ett flerordat meddelande");
            string meddelande = Console.ReadLine();
            Console.WriteLine("Hur många steg åt höger vill du ha dina meddelanden");
            int steg = int.Parse(Console.ReadLine());
            for (int a = 0; a < meddelande.Length; a++)
            {
                string bokstav = meddelande[i].ToString();
                for (int b = 0; b < steg; b++)
                {
                    Console.Write(" ");
                }
                Console.WriteLine(bokstav);
            }
            Console.ReadKey();
        }
    }
}
