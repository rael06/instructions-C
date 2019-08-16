using System;

namespace iteration
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] jours = new[]
            {
                "lundi",
                "mardi",
                "mercredi",
                "jeudi",
                "vendredi",
                "samedi",
                "dimanche"
            };


            foreach (string jour in jours)
            {
                string message;
                message = jour == "samedi" || jour == "dimanche" ? "Weekend" : "Semaine";
                Console.WriteLine("{0} {1}",jour, message);
            }
        }
    }
}
