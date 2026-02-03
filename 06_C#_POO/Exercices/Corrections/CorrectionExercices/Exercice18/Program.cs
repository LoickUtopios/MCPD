using Exercice18.Classes;

Bibliotheque bibliotheque = new Bibliotheque();

Livre l1 = new Livre(1, "Tintin", "Hergé", 10);
Livre l2 = new Livre(2, "The witcher", "Andrej. S", 10);
Livre l3 = new Livre(3, "Salem", "Stephen King", 10);
Livre l4 = new Livre(4, "La critique de la raison pure", "Emmanuel Kant", 10);
Livre l5 = new Livre(5, "L'écume des jours", "Borris Vian", 10);

bibliotheque.Ajouter(l1);
bibliotheque.Ajouter(l2);
bibliotheque.Ajouter(l3);
bibliotheque.Ajouter(l4);
bibliotheque.Ajouter(l5);

bibliotheque.AfficherLivres();

bibliotheque.RechercherLivreParTitre("The witcher");
bibliotheque.RechercherLivreParTitre("Marco Polo");

bibliotheque.RechercherLivreParAuteur("Hergé");

bibliotheque.Supprimer(2);

bibliotheque.AfficherLivres();