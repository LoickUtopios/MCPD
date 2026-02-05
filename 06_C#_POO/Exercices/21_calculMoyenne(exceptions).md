# Calcul de moyenne

Ecrivez une fonction `calculMoyenne()` qui prend un tableau de notes en argument et qui renvoie la moyenne des notes.

- Si le tableau est vide, la fonction doit lever une exception personnalisé `InvalidArrayException` avec le message:
"Le tableau de notes ne peut pas être vide". 

- Si au moins une note est inférieure à 0 ou supérieure à 20, la fonction doit lever une exception  `ArgumentOutOfRangeException` avec le message :
"Les notes doivent être entre 0 et 20.".