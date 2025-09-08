Console.WriteLine("Fonctions");

// Modèle abstrait d'une fonction
// typeDeRetour NomDeLaFonction
// {
//     Instriction...
//     return valeurDeRetour
// }

// Déclaration de la fonction Addition
int Addition(int nbEntier1, int nbEntier2)
{
    return nbEntier1 + nbEntier2;
}

int total = Addition(2, 3);

Console.WriteLine(total);