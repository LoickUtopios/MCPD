git init
git status
nano fichier1.txt
git add fichier1.txt
git commit -m "Ajout de fichier 1"
git status
nano fichier1.txt
git add fichier1.txt
git commit -m "Premiere modification de fichier 1"
git tag temp
git log
nano fichier1.txt
git commit -am "Deuxieme modification de fichier 1"
git log
git tag -a v1.0 -m "Version 1.0 de mon exercice" cb3c0fb
git log
git tag
git checkout temp
git log
git checkout main
git log
git reset --hard v1.0
git log
git tag
git show v1.0