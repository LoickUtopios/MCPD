# Version de git
git --version

# Configuration utilisateur
git config --global user.name "Loick"
git config --global user.email "loick@utopios.solutions"

# Retirer toutes les variables de configurations d'un élément
git config --global --unset-all user.name
git config --global --unset-all user.email

# Information sur les différentes commandes git
git help <commande>
git <commande> --help

# Afficher toutes les commandes git
git

# Voir les informations de configurations
git config --list

# Si la branche par défaut n'est pas main
git config --global init.defaultBranch main