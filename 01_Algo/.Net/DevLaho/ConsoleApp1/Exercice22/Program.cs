const int NB_MATIERE = 3;
const int NB_NOTES = 3;

int[,] notes = new int[NB_MATIERE, NB_NOTES];
string[] matieres = ["Français", "Math", "Histoire"]; 

for(int i = 0; i < NB_MATIERE; i++)
{
    Console.WriteLine("Veuillez saisir les notes de " + matieres[i]);

    for(int j =  0; j < NB_NOTES; j++)
    {
        Console.WriteLine("Saisie de la note n°" + j + " : "); 
        notes[i, j] = int.Parse(Console.ReadLine());
    }
}

for (int i = 0; i < NB_MATIERE; i++)
{
    Console.WriteLine("Voici les notes de " + matieres[i]);

    for (int j = 0; j < NB_NOTES; j++)
    {
        Console.Write(notes[i, j] + " , "); 
    }
}