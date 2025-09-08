// for : quant on connait à l'avance le nombre d'itérations

for (int i = 1; i <= 10; i++)
{
    Console.WriteLine(i);
}

Console.WriteLine("Boucle for... terminée");

// while : quand on ne connait pas à l'avance le nombre d'itérations

int j = 0;

while (j < 10)
{
    Console.WriteLine(j);
    j++;
}

Console.WriteLine("Boucle while... terminée");

// do ... while : variante de while qui exécute au moins une fois le code de la boucle

int k = 0;
do
{
    Console.WriteLine(k);
    k++;
} while (k < 10);

Console.WriteLine("Boucle do ... while terminée");

// foreach : pour itérer sur les collections

int[] tableau = { 1, 31, 154, 5, 26 };
foreach (int element in tableau)
{
    Console.WriteLine(element);
}
Console.WriteLine("Boucle foreach... terminée");