//1.Demande à l’utilisateur de saisir des mots (chaînes de caractères).
//2. Tant que l’utilisateur ne saisit pas `"stop"`, le mot est ajouté dans une `List<string>`.
//3. À la fin :

//   *afficher le nombre total de mots saisis
//   * afficher tous les mots un par un

string input;
List<string> listeDeMots = new List<string>();

do
{
    Console.Write("Veuillez donner un mot : "); 
    input = Console.ReadLine() ?? "";
    
    if (input.ToLower() == "stop")
        break;
    
    listeDeMots.Add(input);

}while (true);


Console.WriteLine("Il y a " + listeDeMots.Count + " mots dans la liste");

foreach(string str in listeDeMots)
{
    Console.WriteLine(str);
}