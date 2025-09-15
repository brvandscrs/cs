// Créer une classe Compte

public class Compte
{
    // Propriétés
    private decimal Solde { get; private set; }

    // Constructeur
    public Compte(decimal soldeInitial)
    {
        Solde = soldeInitial;
    }

    // Méthodes
    public void Deposer(decimal montant)
    {
        if (montant > 0)
        {
            Solde += montant;
            Console.WriteLine($"{montant} déposé. Nouveau solde : {Solde}");
        }
        else
        {
            Console.WriteLine("Le montant à déposer doit être positif.");
        }
    }

    public void Retirer(decimal montant)
    {
        if (montant > 0 && montant <= Solde)
        {
            Solde -= montant;
            Console.WriteLine($"{montant} retiré. Nouveau solde : {Solde}");
        }
        else
        {
            Console.WriteLine("Montant invalide ou fonds insuffisants.");
        }
    }

    public void AfficherSolde()
    {
        Console.WriteLine($"Solde: {Solde}");
    }
}