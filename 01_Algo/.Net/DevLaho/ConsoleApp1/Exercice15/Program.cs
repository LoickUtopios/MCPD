
int resultat = 0;

for (int i = 1; i <= 10; i++)
{
    for(int j = 1; j <= 10; j++)
    {
        resultat = i * j;
        Console.WriteLine(i + " x " + j + " = " + resultat);
    }
    Console.WriteLine();
}