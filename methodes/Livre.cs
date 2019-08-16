namespace methodes
{
    public class Livre
    {
        public int Reference;
        public string Titre;
        public string Auteur;
        public string Genre;
        public string Editeur;

        public override string ToString()
        {
            return "Référence : " + Reference +
                   ", titre : " + Titre +
                   ", auteur : " + Auteur +
                   ", genre : " + Genre +
                   ", éditeur : " + Editeur;
        }

    }
}
