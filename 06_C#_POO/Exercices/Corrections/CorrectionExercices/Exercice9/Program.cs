//# Salariés avec Heritage

//## Sujet

//Créer une classe **Commercial** en dérivant la classe **Salarie** de l'exercice Salarié (exerice 5).

//- Créer les **deux constructeurs** de la classe Commercial. Ne pas oublier d'appeler les constructeurs équivalents de **la classe de base** (mère).

//- Surcharger la méthode **AfficherSalaire**() pour calculer le salaire réel (**fixe + commission**).

//- Ajoutez des méthodes **ToString** pour l'affichage des salariés et comMerciaux.

//- Écrire un programme (**IHM**) qui permet à une entreprise de 20 Employés (Salariés et commerciaux) :
//  -D’**ajouter * *des employés
//  - D’**afficher les salaires** de chaque employé
//  - De **rechercher** un employé par le début de son nom et afficher son **salaire**


using Exercice.Classes;

Salarie chloe = new Salarie("Chloe", "IT", 24000);
Salarie pierre = new Salarie("Pierre", "Comptabilité", 30000);
Salarie sam = new Salarie("Sam", "Managment", 36000);

chloe.AfficherSalaire();
pierre.AfficherSalaire();
sam.AfficherSalaire();

Salarie.AfficherTotalSalaire();
Salarie.LicenciementTotal();
