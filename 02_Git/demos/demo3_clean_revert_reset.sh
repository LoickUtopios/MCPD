# clean est utilisé pour supprimé les fichiers non-suivies
# l'option -n affiche seulement les fichiers qui risque d'être supprimé.
git clean -n

# Pour supprimer les fichiers non-suivies
git clean -f

# Pour supprimer les fichier et les dossiers non-suivies
git clean -fd

# Pour supprimer les fichiers présent dans le .gitignore (pratique pour partagé un projet sans fournir d'éléments importants ou inutiles)
git clean -fx

# Pour annuler un commit sans modifier l'historique (log)
# Nous pouvons utiliser "git revert" avec l'identifiant du commit à inverser.
# Pratique quand on veut revenir en arrière sans supprimer/modifier l'historique (sans incidence définite).
git revert <commit_id>

# Annuler les modifications du commit précédent.
git revert HEAD

# Permet de réinitialiser l'index (staging) et l'arbre de travail au commit spécifié.
# Par défaut, reset est en --mixed
# Reviens au commit précédent sans perdre les modifications locales mais nécessite un ajout (add) puis un commit.
git reset <commit_id>
git reset --mixed <commit_id>

# Nous pouvons aussi réinitialiser l'indexage.
git reset HEAD # retirer ce qui a été add

# Pour revenir au commit précisé sans perte local et est directement prêt au commit.
git reset --soft <commit_id>

# Pour revenir au commit spécifié en supprimant toutes les modifications locales.
# !!!!!!!! ATTENTION, car l'historique est effacé et il n'y aura donc aucun retour possible.
git reset --hard <commit_id> 