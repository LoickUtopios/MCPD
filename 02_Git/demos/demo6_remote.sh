# Ajouter une origin distante au repository
git remote add origin https://votre-repo.git

# Vérifier les dépôts distants configurés
git remote -v

# Lister toutes les branches locales et distantes après le fetch
git branch -a

# Récupérer les dernières modifications du dépôt distant
git fetch

# Fusionner les modifications de 'nouvelle-branche' dans 'main'
git merge origin/nouvelle-branche

# Récupérer les dernière modification et les fusionner directement
git pull origin main

# Pousser la nouvelle branche vers le dépôt distant
git push origin nouvelle-branche

# Pour récupérer le travail d'un depot distant et ajouté directement le remote.
git clone url_github