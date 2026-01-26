//# Exercice 18

//Un tableau contient des notes sur 20.

//Le programme doit :

//1.Parcourir le tableau.
//2.Appliquer les règles suivantes :

//   -une note inférieure à 10 devient 10
//   - une note supérieure à 20 devient 20

//3. Afficher le tableau après modification.

int[] notes = { 4, 5, 6, 12 , 13, 14, 22, 23};

for(int i = 0; i < notes.Length ; i++)
{
    if(notes[i] < 10)
        notes[i] = 10;

    if(notes[i] > 20)
        notes[i] = 20;
}

foreach(int i in notes)
{
    Console.Write(i + " - ");
}