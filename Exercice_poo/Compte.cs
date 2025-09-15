// Créer une classe Compte

public class Compte
{
    public decimal Solde { get; private set; }

    // Constructeur
    public Compte(string titulaire, decimal soldeInitial)
    {
        Solde = soldeInitial;
    }

    public void AfficherSolde()
    {
        Console.WriteLine($"Solde: {Solde}");
    }
}