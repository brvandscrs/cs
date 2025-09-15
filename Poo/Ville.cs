// Classe "normale"
public class Ville
{
    // Constructeur par défaut (optionnel, car implicite si non défini)
    // Signature : public NomDeLaClasse
    public Ville()
    {
        Nom = "Avignon";
    }
    // Données de la classe : Propriétés / Attributs
    public string Nom { get; set; }
    public string? CodePostal { get; set; }

    // Comportements de la classe : Méthodes (fonctions)
    public void Afficher()
    {
        Console.WriteLine($"{CodePostal} {Nom}");
    }
    private void Test()
    {
        Console.WriteLine("Test");
    }
}