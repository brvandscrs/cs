// Exercice 3

// Ecrire un programme qui demande à l'utilisateur d'entrer des nombres (un par un).
// La saisie s'arrête lorsqu'il entre 0.
// Avec une boucle while, calculer et afficher la somme des nombres saisis.

int nombre = Convert.ToInt32(Console.ReadLine());
int iterations = 1;

while (nombre != 0)
{
    nombre = Convert.ToInt32(Console.ReadLine());
    iterations += 1;
}

Console.WriteLine("Nombres d'itérations : " + iterations);
Console.WriteLine("Boucle 3 terminée.");