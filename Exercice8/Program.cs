Console.WriteLine("Exercice 8");

// Demander deux nombres et un opérateur (+, -, *, /). Utiliser un switch pour afficher le résultat

int somme = 0;
int difference = 0;
int produit = 0;
int quotient = 0;
int nombre1 = int.Parse(Console.ReadLine());
int nombre2 = int.Parse(Console.ReadLine());
string operateur = Console.ReadLine();

switch (operateur)
{
    case "+":
        somme = nombre1 + nombre2;
        Console.WriteLine(nombre1 + operateur + nombre2 + " = " + somme);
        break;

    case "-":
        if (nombre1 > nombre2)
        {
            difference = nombre1 - nombre2;
            Console.WriteLine(nombre1 + operateur + nombre2 + " = " + difference);
        }
        else if (nombre1 < nombre2)
        {
            difference = nombre2 - nombre1;
            Console.WriteLine(nombre2 + operateur + nombre1 + " = " + difference);
        }
        else
            Console.WriteLine(difference);
        break;

    case "*":
        produit = nombre1 * nombre2;
        Console.WriteLine(nombre1 + operateur + nombre2 + " = " + produit);
        break;

    case "/":
        if (nombre1 > nombre2)
        {
            quotient = nombre1 / nombre2;
            Console.WriteLine(nombre1 + operateur + nombre2 + " = " + quotient);
        }
        else if (nombre1 < nombre2)
        {
            quotient = nombre2 / nombre1;
            Console.WriteLine(nombre2 + operateur + nombre1 + " = " + quotient);
        }
        else
            Console.WriteLine(1);
        break;

    default:
        Console.WriteLine("Opérateur non reconnu. Recommencez.");
        break;
}