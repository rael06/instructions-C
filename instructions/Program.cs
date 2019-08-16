using System;
using System.Security.Cryptography;

namespace instructions
{
    class Program
    {
        static void Main(string[] args)
        {
//            int limit = Convert.ToInt32(Console.ReadLine());
//            Console.WriteLine(limit);
//            int min = 0;
//            int max = 0;
//            for (int i = 0; i < limit; i++)
//            {
//                Random random = new Random();
//                int j = random.Next(1, 10);
//                if (j <= 5) min++;
//                if (j > 5) max++;
//            }
//
//            Console.WriteLine("Proportions min et max : " + ((double) min) / limit * 100 + " " +
//                              ((double) max) / limit * 100);
            char a = Convert.ToChar(Console.ReadLine());
            Console.WriteLine(char.IsLetter(a) ? "vrai" : "faux");
        }
    }
}
