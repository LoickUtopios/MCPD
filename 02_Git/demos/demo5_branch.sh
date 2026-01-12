# Lister les branches (locales)
git branch

# Lister les branches à distances
git branch -r

# Créer une nouvelle branche
git branch <nom_branche>

# Se déplacer sur une branche (existante)
git checkout <nom_branche>
git switch <nom_branche>

# Créer une branche et s'y déplacer
git checkout -b <nom_branche>
git switch -c <nom_branche>

# Pour supprimer une branche
git branch -d <nom_branche>
git branch -D <nom_branche> # Force la suppression même si elle n'a pas été fusionné (sauvegardé ailleurs)

# Pour renommer la branche active
git branch -m <nouveau_nom_de_branche>

# Pour fusionner 2 branche, nous utilisons la commande.

# 3 possibilité :
#   - Fast-forward : le travail est linéaire et donc le pointeur de la branche principal avance (pas de conflit, tout est automatique)
#   - Merge (sans-conflit) : il y a une divergence de travail et la fusion va nécessiter un commit de fusion (pas de conflit donc seul un message de commit sera nécessaire)
#   - Merge (avec conflit) : Il y a une divergence de travail et la fusion va nécessiter un commit de fusion mais également la résolution du conflit.

# !!!! Pour résoudre un conflit, vous devez vous placer dans le fichier problématique et retirer les symboles suivant : <<<< branch / ====== / >>>>>> branch
# Une fois, le conflit résolue, nous devons sauvegarder la résolution (git add + git commit)
git merge <nom_branch>

