
// Cas 1 : utilisation de SortedSet pour le trie et éviter les doublons
SortedSet<string> pseudos = new SortedSet<string>();
pseudos.Add("Jdg");
pseudos.Add("Zerator");
pseudos.Add("Zerator");
pseudos.Add("KennyS");
pseudos.Add("Sardoche");
pseudos.Add("Sardoche");
pseudos.Add("JLTommy");


Console.WriteLine("Cas 1 : \n");
foreach (string pseudo in pseudos)
{
    Console.WriteLine(pseudo);
}

if (pseudos.Contains("Zerator"))
    Console.WriteLine("Zerator participe à la compétition.");
else
    Console.WriteLine("Zerator n'est pas inscrit...");


// Cas 2 

Console.WriteLine("Cas 2 : \n");
Queue<string> noms = new Queue<string>();
noms.Enqueue("Tom Cruise"); 
noms.Enqueue("Dwayne Johnson"); 
noms.Enqueue("Patrick Stewart"); 
noms.Enqueue("Marlon Brando"); 
noms.Enqueue("Jason Momoa");

Console.WriteLine("Voici toutes les personnes en attentes, veuillez taper 'Entree' pour la suite : '");
while (noms.Count > 0)
{
    Console.WriteLine("La personne en cours de traitement est : " + noms.Dequeue());
    Console.WriteLine("Il reste " + noms.Count + " personnes a traiter.");
    Console.ReadLine();
}

Console.WriteLine("C'est l'heure de la pause café ^^");

// Cas 3 

//-Tâches :
//    -Ajoutez plusieurs élèves avec leurs notes respectives.
//    - Modifiez la note du troisième élève ajouté.
//    - Affichez la note du dernier élève ajouté.
//    - Affichez la liste complète des élèves et leurs notes.

Console.WriteLine("Cas 3 : \n");
Dictionary<string, int> notes = new Dictionary<string, int>();
notes["Toto"] = 10; 
notes["Tata"] = 15; 
notes["Titi"] = 13; 
notes["Tutu"] = 7; 
notes["Trotro"] = 9;

notes["Titi"] = 20;
notes[notes.ElementAt(2).Key] = 20;

Console.WriteLine("La note du dernier élève est : " + notes.Last().Value);

foreach(var note in notes)
{
    Console.WriteLine(note.Key + " a eu " + note.Value + "/20");
}



