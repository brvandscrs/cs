// Créer une classe Compte

public class Compte
{
    public decimal Solde { get; private set; }

    public Compte(decimal soldeInitial)
    {
        Solde = soldeInitial;
    }

    public void AfficherSolde()
    {
        Console.WriteLine($"Solde: {Solde}");
    }
}