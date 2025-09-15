public class Titulaire
{
    // Propriétés

    private string _id { get; set; }
    public string Id
    {
        get { return id; }
        set { id = value; }
    }

    private string _nom { get; set; }
    public string Nom
    {
        get { return _nom; }
        set { _nom = value; }
    }

    private string _prenom { get; set; }
    public string Prenom
    {
        get { return _prenom; }
        set { _prenom = value; }
    }

    private string _adresse { get; set; }
    public string Adresse
    {
        get { return _adresse; }
        set { _adresse = value; }
    }

    private string _codePostal { get; set; }
    public string CodePostal
    {
        get { return _codePostal; }
        set { _codePostal = value; }
    }

    private string _ville { get; set; }
    public string Ville
    {
        get { return _ville; }
        set { _ville = value; }
    }

    private string _tel { get; set; }
    public string Tel
    {
        get { return _tel; }
        set { _tel = value; }
    }

    private string _email { get; set; }
    public string Email
    {
        get { return _email; }
        set { _email = value; }
    }

    // Constructeur

    public Titulaire(string id, string nom, string prenom, string adresse, string codePostal, string ville, string tel, string email)
    {
        // Id = id;
        Nom = nom;
        Prenom = prenom;
        Adresse = adresse;
        CodePostal = codePostal;
        Ville = ville;
        Tel = tel;
        Email = email;
    }

    // Méthodes

    public void Afficher()
    {
        Console.WriteLine($"ID: {Id}, Nom: {Nom}, Prénom: {Prenom}, Adresse: {Adresse}, Code Postal: {CodePostal}, Ville: {Ville}, Téléphone: {Tel}, Email: {Email}");
    }
}