Console.WriteLine("Exercice 2");

// if/else

int note = 10;

if (note >= 10)
{
    Console.WriteLine("Réussi");
}
else
{
    Console.WriteLine("Echec");
}

// Si une seule instruction dans le bloc, {} inutiles

if (note >= 10)
    Console.WriteLine("Réussi");
else
    Console.WriteLine("Echec");

// if/else if/else

if (note >= 15)
    Console.WriteLine("Très bien");
else if (note >= 10)
    Console.WriteLine("Bien");
else if (note >= 5)
    Console.WriteLine("Passable");
else
    Console.WriteLine("Mauvais");

// Switch

switch (note)
{
    case >= 15:
        Console.WriteLine("Très bien");
        Console.WriteLine("Bravo");
        break;

    case >= 10:
        Console.WriteLine("Bien");
        break;

    case >= 5:
        Console.WriteLine("Passable");
        break;

    default:
        Console.WriteLine("Mauvais");
}

// Exercice
// Déclarer deux variables pour les âges de Pierre et Paul
// Afficher lequel des deux est le plus âgé, avec des if, puis avec un switch

int agePierre = 14;
int agePaul = 15;

if (agePierre > agePaul)
    Console.WriteLine("Pierre est plus âgé que Paul.");
else if (agePierre < agePaul)
    Console.WriteLine("Paul est plus âgé que Pierre.");
else
    Console.WriteLine("Pierre et Paul ont tous les deux le même âge.");

switch (agePierre)
{
    case > agePaul:
        Console.WriteLine("Pierre est plus âgé que Paul.");

    case < agePaul:
        Console.WriteLine("Paul est plus âgé que Pierre.");

    default:
        Console.WriteLine("Pierre et Paul ont tous les deux le même âge.");
}