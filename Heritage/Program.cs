public class Heritage
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Héritage C#");
        // Instanciation d'un utilisateur + initialisation du Nom et Prenom, puis afficher l'utilisateur
        Utilisateur user = new Utilisateur();
        user.Nom = "Dupont";
        user.Prenom = "Jean";
        user.Afficher();

        // Transférer la classe Utilisateur du fichier Program.cs au fichier Utilisateur.cs
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