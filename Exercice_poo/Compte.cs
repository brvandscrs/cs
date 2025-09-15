// Créer une classe Compte

public class Compte
{
    // Propriétés

    private decimal _solde { get; private set; }
    public decimal Solde
    {
        get { return _solde; }
        set { _solde = value; }
    }

    // Constructeur

    public Compte(decimal soldeInitial)
    {
        Solde = soldeInitial;
    }

    // Méthodes

    public void Afficher()
    {
        Console.WriteLine($"Solde: {Solde}");
    }
}