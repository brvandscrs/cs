Console.WriteLine("Exercice 7");

// Demander un nombre entre 1 et 7, puis utiliser un switch pour afficher le jour correspondant (1 = Lundi, 2 = Mardi, etc.)

int jour = int.Parse(Console.ReadLine());

switch (jour)
{
    case == 1:
        Console.WriteLine("Nous sommes lundi");
        break;

    case == 2:
        Console.WriteLine("Nous sommes mardi");
        break;

    case == 3:
        Console.WriteLine("Nous sommes mercredi");
        break;

    case == 4:
        Console.WriteLine("Nous sommes jeudi");

    case == 5:
        Console.WriteLine("Nous sommes vendredi");
        break;

    case == 6:
        Console.WriteLine("Nous sommes samedi");
        break;

    case == 7:
        Console.WriteLine("Nous sommes dimanche");
        break;

    default:
        Console.WriteLine("Numéro de jour incorrect. Recommencez.");
        break;
}