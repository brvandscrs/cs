// Exercice 4

// Le programme choisit un nombre aléatoire entre 1 et 100.
// Avec une boucle do... while..., demander à l'utilisateur de deviner le nombre.
// Continuer jusqu'à ce que l'utilisateur trouve la bonne réponse.
// A chaque essai, indiquer si le nombre est trop grand ou trop petit.

int nombreAleatoire = Math.Randint();
int essais = 0;

do
{
    int devinette = Convert.ToInt32(Console.ReadLine());
}
while (devinette != nombreAleatoire);