using System;

namespace methodes
{
    class Program
    {

        public static Livre SaisieLivre(int compteur)
        {
            Livre monLivre = new Livre();
            monLivre.Reference = compteur;
            Console.WriteLine("Veuillez saisir le titre du livre");
            monLivre.Titre = Console.ReadLine();
            Console.WriteLine("Veuillez saisir l'auteur du livre");
            monLivre.Auteur = Console.ReadLine();
            Console.WriteLine("Veuillez saisir le genre du livre");
            monLivre.Genre = Console.ReadLine();
            Console.WriteLine("Veuillez saisir la maison d'édition du livre");
            monLivre.Editeur = Console.ReadLine();
            return monLivre;
        }
        public static void AjouterLivre(Livre[] meslivres, ref int compteur)
        {
            meslivres[compteur] = SaisieLivre(compteur + 1);
            compteur++;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Veuillez saisir le nombre de livre à ajouter : ");
            int nbreLivre = Convert.ToInt32(Console.ReadLine());

            Livre[] meslivres = new Livre[nbreLivre];

            int compteur = 0;
            for (int i = 0; i < nbreLivre; i++)
            {
                AjouterLivre(meslivres, ref compteur);
            }

            foreach (Livre livre in meslivres)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine(livre.ToString());
            }
        }
    }
}
