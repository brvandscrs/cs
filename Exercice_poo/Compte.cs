// Créer une classe Compte

public class Compte
{
    // Propriétés

    public Compte(string Nom, string Prenom, string Adresse, string CodePostal, string Ville, string Tel, string Email, decimal soldeInitial)
    {
        Nom = Nom;
        Prenom = Prenom;
        Adresse = Adresse;
        CodePostal = CodePostal;
        Ville = Ville;
        Tel = Tel;
        Email = Email;
        soldeInitial = soldeInitial;
    }
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

    public void Afficher()
    {
        Console.WriteLine($"Solde: {Solde}");
    }
}