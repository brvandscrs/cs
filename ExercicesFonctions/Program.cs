// Exercice 1

Console.WriteLine("Exercice 1");

// Ecrire une fonction qui calcule le carré d'un nombre

int Carre(int nombre)
{
    return Math.Pow(nombre, 2);
}

// Test 3 fois

int nombreCarre;

for (int i = 1; i <= 3; i++)
{
    nombreCarre = Convert.ToInt32(Console.ReadLine());
    Carre(nombreCarre);
}

// Exercice 2

Console.WriteLine("Exercice 3");

// Eccrire une fonction qui affiche "Bonjour" dans la console

string MessageBonjour()
{
    return "Bonjour";
}

MessageBonjour();

// Exercice 3

Console.WriteLine("Exercice 3");

// Ecrire une fonction qui retourne le plus grand de deux entiers

int PlusGrand(int entier1, int entier2)
{
    return Math.Max(entier1, entier2);
}

// Test 3 fois

int entier1;
int entier2;

for (int i = 1; i <= 3; i++)
{
    entier1 = Convert.ToInt32(Console.ReadLine());
    entier2 = Convert.ToInt32(Console.ReadLine());
    PlusGrand(entier1, entier2);
}