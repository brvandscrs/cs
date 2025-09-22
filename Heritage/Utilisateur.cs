public class Utilisateur
{
    // Propriétés

    public Utilisateur(string Nom, string Prenom)
    {
        Nom = Nom;
        Prenom = Prenom;
    }

    // Méthodes

    public void Afficher()
    {
        Console.WriteLine($"Solde: {Solde}");
    }
}