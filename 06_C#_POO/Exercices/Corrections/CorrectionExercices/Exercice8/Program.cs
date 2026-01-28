using Exercice8.Classes;

CompteBancaire cb = new CompteBancaire("Toto", 2000, "Eur");
cb.Deposer(500);
cb.Retirer(5000);
cb.Retirer(50);
cb.AfficherSolde(); 

CompteEpargne ce = new CompteEpargne("Titi", 1000, "Dol", 4);
ce.Deposer(500);
ce.Retirer(2000);
ce.Retirer(500);
ce.AfficherSolde();
Console.WriteLine(ce.CalculerInteret()); 

CompteCourant cc = new CompteCourant("Tutu", 500, "Yen", 10000);
cc.Deposer(500);
cc.Retirer(15000);
cc.RetirerAvecDecouvert(15000);
cc.RetirerAvecDecouvert(10000);
cc.AfficherSolde();