int[] tableau = new int[15];

for (int i = 0; i < tableau.Length; i++)
{
    Console.WriteLine("Saisir note n°"+ (i+1) + " : ");
    int note = int.Parse(Console.ReadLine());

    tableau[i] = note;
}

foreach(int j in tableau)
{
    Console.WriteLine(j);
}