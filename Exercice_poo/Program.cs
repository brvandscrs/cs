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
        Titulaire monTitulaire = new Titulaire();
        monTitulaire.Nom = "Dupont";
        monTitulaire.Prenom = "Alice";
        monTitulaire.Adresse = "123 Rue Principale";
        monTitulaire.CodePostal = "75001";
        monTitulaire.Ville = "Paris";
        monTitulaire.Tel = "0123456789";
        monTitulaire.Email = "alice.dupont@email.com";

        // Utilisation de la méthode Afficher() de l'objet monTitulaire
        monTitulaire.Afficher();
    }
}