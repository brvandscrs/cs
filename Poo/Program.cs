class Program
{
    // Point d'entrée du programme : méthode statique appelée Main qui retourne void
    static void Main(string[] args)
    {
        Console.WriteLine("Début");

        // Instanciation (créer un objet) d'un objet Ville
        Ville maVille = new Ville();

        // A partir d'ici, on peut utiliser l'objet maVille
        maVille.Nom = "Avignon";        // Affectation du Nom
        maVille.CodePostal = "84000";   // Affectation du CodePostal

        // Utilisation de la méthode Afficher() de l'objet maVille
        maVille.Afficher();
    }
}