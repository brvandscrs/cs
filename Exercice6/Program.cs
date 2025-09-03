Console.WriteLine("Exercice 6");

// Demander deux nombres et afficher lequel est le plus grand, ou si ce sont les mêmes

int nombre1 = int.Parse(Console.ReadLine());
int nombre2 = int.Parse(Console.ReadLine());

// int lePlusGrand = Math.Max(nombre1, nombre2);

if (nombre1 != nombre2)
    Console.WriteLine("Le plus grand nombre des deux est " + Math.Max(nombre1, nombre2) + ".");
else
    Console.WriteLine("Les deux nombres sont exactement les mêmes : " + nombre1 + ".");