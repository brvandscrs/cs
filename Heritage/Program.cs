public class Heritage
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Héritage C#");

        Utilisateur user = new Utilisateur();
        user.Nom = "Descours";
        user.Prenom = "Bryan";
        user.Afficher();

        Utilisateur user = new Utilisateur("Bryan", "Descours");
        user.Afficher();

        Client client = new Client();
        client.Nom = "Dupont";
        client.Prenom = "Jacques";
        client.Adresse = "Place Jean Jaurès 84740 Velleron";
        client.Afficher();

        Client client = new Client("Jacques", "Dupont", "Place Jean Jaurès 84740 Velleron");
        client.Afficher();

        Employe employe = new Employe();
        employe.Nom = "Martin";
        employe.Prenom = "Paul";
        employe.Poste = "Secrétaire";
        employe.Afficher();

        Employe employe = new Employe("Paul", "Martin", "Secrétaire");
        employe.Afficher();
    }
}