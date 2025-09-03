Console.WriteLine("Exercice 5");

// Demander à 'utilisateur son âge et afficher "Tu es mineur" si l'âge est < 18 ou "Tu es majeur" si l'âge >= 18

int ageUtilisateur = Console.ReadLine();

if (ageUtilisateur < 18)
    Console.WriteLine("Tu es mineur.");
else
    Console.WriteLine("Tu es majeur.");