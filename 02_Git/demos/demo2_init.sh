# Pour initialiser un projet git (créer un dossier .git invisible)
git init

# Pour afficher l'état actuel de mes fichiers dans le dossier courant.
git status

# Les différents états des fichiers sont : 
# - Untracked (rouge) : fichier/dossier qui n'ont jamais été commit (sauvegardé).
# - Modified (rouge) : Fichiers qui ont été modifié ou supprimé.
# - Staged (vert) : Le fichier a été préparé pour le prochain commit.
# - Unmodified (invisible) : L'état des fichiers/dossier qui n'ont pas été manipulé.

# Permet d'ajouter un ficher dans le prochain commit
git add <nom_fichier>

# Permet d'ajouter tout les fichiers présent dans le dossier courant en staged
git add . 
git add --all
git add -A 

# Pour "sauvegarder" l'état actuel de notre projet (ce qui a été ajouter via add), nous devons utiliser commit
git commit -m "Message du commit"

# Dans le cas ou aucun nouveau fichier n'a été créé, on peut ne pas préciser le add.
# Pour cela nous ajoutons l'option -am afin d'ajouter directement les modifications.
git commit -am "Message du commit"

# Pour afficher l'historique de nos commit
git log

# Pour afficher un nombre de précis des derniers commit
git log -p -2 # 2 dernier commits

# Pour afficher l'historique sur une ligne
git log --oneline

# Pour afficher l'historique sous forme de "graph"
git log --oneline --graph --all

# Nous pouvons connaitre la difference entre le commit actuel et un commit spécifié
git diff <commit_id>

# Il est également possible de voir la différence entre 2 commit spécifique
git diff <commit_id> <commit_id2>
