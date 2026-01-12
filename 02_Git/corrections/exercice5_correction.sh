git init
touch file1
git add .
git commit -m "C1"

nano file1
git add .
git commit -m "C2"

git checkout -b feature1
touch file2
git add .
git commit -m "F1"

git log
git checkout 9b919ab

git checkout -b feature2
nano file1
git add .
git commit -m "F2"

git checkout main
git merge feature1
git log

git merge feature2
nano file1
git status
git add .
git commit -m "Fusion de feature2 dans main (C4)"

git log