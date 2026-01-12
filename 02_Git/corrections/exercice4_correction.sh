# Initialiser le projet git (1)
git init

# Ajout et commit d'un fichier (2)
touch file
git add .
git commit -m "Ajout de file"

# Ajout et commit d'un 2e fichier (3)
touch file2
git add .
git commit -m "Ajout de file"

# Afficher l'historique des commits (4)
git log

# Faire des modification et les commits (5)
nano file2
git add .
git commit -m "Modification de file2"

# Annuler le commit précédent (6)
git reset --hard HEAD^ # HEAD^ cible le commit précédent (pas besoin d'id)

# Afficher l'historique des commits (7)
git log

# Créer une branche sur le premier commit (8)
git checkout HEAD^ # Je reviens sur le premier commit
git branch dev # Je créer une branche sur ce commit
git checkout dev # Je rend la branch "dev" active. 

# J'ajoute et je commit un fichier 3 (9)
touch file3
git add .
git commit -m "Ajout de file3"

# Afficher l'historique des commits (10)
git log

# Afficher la liste des branches (7)
git branch

# Créer un tag sur le commit actuel
git tag dev1.0

# Revenir sur le dernier commit de la branch main
git checkout main

# Afficher tout les tags présents
git tag

# Supprimer la branche 'dev' (-D pour forcer la suppression)
git branch -D dev

# Afficher toutes les branches du projet
git branch