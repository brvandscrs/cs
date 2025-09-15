class Program
{
    // Point d'entrée du programme
    static void Main(string[] args)
    {
        // Instanciation (créer un objet) d'un objet Compte
        Compte monCompte = new Compte();

        // Affectation du Solde
        monCompte.Solde = 150.75m;
        // Cast par postfixe : 150.75m
        // Cast explicite : (decimal)150.75

        // Utilisation de la méthode Afficher() de l'objet maVille
        maVille.AfficherSolde();

        // Instanciation (créer un objet) d'un objet Titulaire
        Titulaire monTitulaire = new Titulaire("T001", "Alice Dupont", "123 Rue Principale", "75001", "Paris", "0123456789", "alide.dupont@email.com");
        monTitulaire
    }
}