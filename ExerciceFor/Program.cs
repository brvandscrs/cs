// Exercice 1

// Ecrire un programme qui utilise une boucle for pour afficher tous les nombres paires de 0 à 20

for (int i = 0; i <= 20; i++)
{
    if (i % 2 == 0)
    {
        Console.WriteLine(i);
    }
}

Console.WriteLine("Boucle 1 terminée.");

// Exercice 2

// Ecrire un programme qui demande à l'utilisateur un nombre, puis affiche sa table de multiplication de 1 à 10 avec une boucle for

int nombre = Convert.ToInt32(Console.ReadLine());
int table = 0;

for (int j = 1; j <= 10; j++)
{
    table = nombre * j;
    Console.WriteLine(nombre + " * " + j + " = " + table);
}

Console.WriteLine("Boucle 2 terminée.");