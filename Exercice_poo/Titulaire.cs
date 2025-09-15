public class Titulaire
{
    // Propriétés

    public string _id { get; set; }
    private string Id
    {
        get { return id; }
        set { id = value; }
    }

    public string _prenom { get; set; }
    private string Prenom
    {
        get { return _prenom; }
        set { _prenom = value; }
    }

    public string _adresse { get; set; }
    private string Adresse
    {
        get { return _adresse; }
        set { _adresse = value; }
    }

    public string _codePostal { get; set; }
    private string CodePostal
    {
        get { return _codePostal; }
        set { _codePostal = value; }
    }

    public string _ville { get; set; }
    private string Ville
    {
        get { return _ville; }
        set { _ville = value; }
    }

    public string _tel { get; set; }
    private string Tel
    {
        get { return _tel; }
        set { _tel = value; }
    }

    public string _email { get; set; }
    private string Email
    {
        get { return _email; }
        set { _email = value; }
    }

    // Constructeur

    public Titulaire(string id, string prenom, string adresse, string codePostal, string ville, string tel, string email)
    {
        Id = id;
        Prenom = prenom;
        Adresse = adresse;
        CodePostal = codePostal;
        Ville = ville;
        Tel = tel;
        Email = email;
    }

    // Méthodes

    public void AfficherTitulaire()
    {
        Console.WriteLine($"ID: {Id}, Prénom: {Prenom}, Adresse: {Adresse}, Code Postal: {CodePostal}, Ville: {Ville}, Téléphone: {Tel}, Email: {Email}");
    }
}