Console.Write("Veuillez entrer n : "); 
int saisie = int.Parse(Console.ReadLine());
string message = ""; 

for(int i = 1; i <= saisie; i++)
{
    message += i + " "; 
    Console.WriteLine(message);
}