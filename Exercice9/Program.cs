Console.WriteLine("Exercice 9");

// Demander une note (entre 0 et 20). Utiliser un switch avec des plages (when) pour afficher :
// [0 à 9] : "Insuffisant"
// [10 à 13] : "Moyen"
// [14 à 16] : "Bien"
// [17 à 20] : "Excellent"

int note = int.Parse(Console.ReadLine());

switch (note)
{
    case int f when (f >= 0 & f <= 9):
        Console.WriteLine("Insuffisant");
        break;

    case int f when (f >= 10 & f <= 13):
        Console.WriteLine("Moyen");
        break;

    case int f when (f >= 14 & f <= 16):
        Console.WriteLine("Bien");
        break;

    case int f when (f >= 17 & f <= 20):
        Console.WriteLine("Excellent");
        break;

    default:
        Console.WriteLine("Note non reconnue.Recommencez.");
        break;
}