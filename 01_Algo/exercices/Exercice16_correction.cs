int min = 0;
int max = 0;
int somme = 0;
int saisie = 0;
double moyenne = 0.0;
int nbNote = 20;

// On boucle pour saisir les 20 notes, une par une
for(int i =  0; i < nbNote; i++)
{
    // On demande la note à l'utilisateur et on la recupere en tant que nombre
    Console.Write("Veuillez saisir le note n°" + (i+1) + " : ");
    saisie = int.Parse(Console.ReadLine());

    // Si c'est la premiere note alors elle est la note min et max de base
    if (i == 0)
    {
        min = saisie;
        max = saisie;
    }
    else
    {
        // Si c'est l'une des 19 notes suivantes, nous les comparons avec le min et max actuel
        if(min > saisie)
            min = saisie;

        if(max < saisie)
            max = saisie;
    }
    // A chaque saisie, nous l'additionnons à la somme total pour la moyenne. 
    somme += saisie;
}

// Choix sera la saisie de l'utilisateur dans le menu
int choix = 0;
// finMenu est un booléen pour savoir quand arrete le programme
bool finMenu = true;

// On utilise un do..While pour demander le choix de l'utilisateur avant de vérifier la condition
do
{
    // J'affiche le menu et demande son choix à l'utilisateur
    Console.WriteLine("1. Afficher le max");
    Console.WriteLine("2. Afficher le min");
    Console.WriteLine("3. Afficher la moyenne");
    Console.WriteLine("0. Quitter");
    Console.WriteLine("Veuillez donner votre choix : ");
    choix = int.Parse(Console.ReadLine());

    // Le switch va afficher l'information correspondante selon le choix de l'utilisateur
    switch (choix)
    {
        case 1:
            Console.WriteLine("Le max est : " + max);
            break;
        case 2:
            Console.WriteLine("Le min est : " + min);
            break;
        case 3:
            Console.WriteLine("La moyenne est : " + (somme / nbNote));
            break;
        case 0:
            // Si l'utilisateur donne le choix 0, alors on affiche un message et on change
            // le booléen pour sortir du programme
            Console.WriteLine("Au revoir");
            finMenu = false;
            break;
        default:
            Console.WriteLine("Choix incorrect !");
            break;
    }
    Console.WriteLine();

}while (finMenu);