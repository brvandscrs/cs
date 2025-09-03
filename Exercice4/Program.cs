Console.WriteLine("Exercice 4");

// Demander à l'utilisateur d'entrer un nombre et afficher s'il est pair ou impair

int nombre = Console.ReadLine();

if (nombre % 2 == 0)
{
    Console.WriteLine(nombre + " est pair.");
}
else
{
    Console.WriteLine(nombre + " est impair.");
}