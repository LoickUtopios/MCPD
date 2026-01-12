1. Créer un nouveau repository Git (créer un dossier et initialiser un projet git)
2. Ajouter un fichier et le commiter
3. Modifier le fichier et le commiter
4. Observer l’historique (on doit voir les deux commits)

# Créer un nouveau repository Git
git init

# Ajouter un fichier
nano fichier1

# Pour vérifier que le fichier est untracked
git status

# Préparer fichier1 à la sauvegarde
git add fichier1

# Sauvagarder fichier1 dans git
git commit -m "Ajout de fichier 1"

# Modification de fichier1
nano fichier1

# Préparation et sauvegarde dans git
git add fichier1
git commit -m "Modification de fichier1"

# Affichage de l'historique des commits
git log
