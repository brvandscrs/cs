public class Utilisateur
{
    public string Nom { get; set; }
    public string Prenom { get; set; }

    public Utilisateur()
    {
        Nom = "";
        Prenom = "";
    }

    public void Afficher()
    {
        Console.WriteLine($"{Nom} {Prenom}");
    }
}

public class Administrateur : Utilisateur
{

}

public class Client : Utilisateur
{
    public Client()
    {
        Adresse = "";
    }

    public string Adresse { get; set; }

    public void Afficher()
}

public class Employe : Utilisateur
{
    public Employe()
    {
        Poste = "";
    }

    public string Poste { get; set; }
}