// Créer une classe Compte

public class Compte
{
    // Propriétés
    public decimal _solde { get; private set; }
    private decimal Solde
    {
        get { return _solde; }
        set { _solde = value; }
    }

    // Constructeur
    public Compte(decimal soldeInitial)
    {
        Solde = soldeInitial;
    }

    public void AfficherSolde()
    {
        Console.WriteLine($"Solde: {Solde}");
    }
}