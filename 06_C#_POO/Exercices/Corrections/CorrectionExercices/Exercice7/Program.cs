using Exercice7.Classes;

Citerne c1 = new Citerne(100, 5000);
Citerne c2 = new Citerne(200, 2000);

Console.WriteLine("Volume total : " + Citerne.TotalVolume);
c1.Remplir(2500);
c2.Remplir(1000);
c2.Remplir(3000);
c1.Vider(3000); 
c2.Vider(1000);


Console.WriteLine("Volume total : " + Citerne.TotalVolume);