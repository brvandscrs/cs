public class Heritage
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Héritage C#");
        Utilisateur user = new Utilisateur();
        user.Nom = "Descours";
        user.Prenom = "Bryan";
        user.Afficher();
    }
}

public class Utilisateur
{
    public string Nom { get; set; }
    public string Prenom { get; set; }

    public void Afficher()
    {
        Console.WriteLine($"{Nom} {Prenom}");
    }
}