# Pour se déplacer à un commit spécifique
# Les autres commit ne seront pas supprimé, seul l'affichage du travail local sera
# dans l'état du commit spécifié.
git checkout <commit_id>

# Pour revenir au dernier commit d'une branche, il suffit de donner le nom de la branche en question.
git checkout <nom_branche>

# Pour créer un tag sur le commit courant
git tag v1.0 # ce tag est léger ( pas de description)

# Pour créer un tag sur commit spécifique
git tag v1.1 <commit_id>

# Pour donner une description à notre tag
git tag -a <nom_tag> -m <description_tag>

# Pour afficher les tags
git tag

# Pour afficher les informations du tag
git show <nom_tag>
ex: git show v1.0

# Pour se déplacer à un tag spécifique
git checkout <nom_tag>

# Pour supprimer un tag
git tag -d <nom_tag>
ex: git tag -d v1.0
