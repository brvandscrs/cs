class Program
{
    // Point d'entrée du programme
    static void Main(string[] args)
    {
        // Instanciation (créer un objet) d'un objet Compte
        Compte monCompte = new Compte();

        // Affectation du Solde
        monCompte.Solde = 150.75m;          // Cast par postfixe
        monCompte.Solde = (decimal)150.75;  // Cast explicite

        // Utilisation de la méthode Afficher() de l'objet maVille
        maVille.AfficherSolde();
    }
}