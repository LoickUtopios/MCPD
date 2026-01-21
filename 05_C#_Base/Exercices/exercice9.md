## Exercice — Connexion simplifiée (?:, ??, ??=, priorité && / ||)

### Sujet

Demander à l’utilisateur :

- un identifiant (`login`) (peut être vide)
- un mot de passe (`password`) (peut être vide)
- un code admin (`adminCode`) (peut être vide)

Règles :

- Si `login` est null ou vide, le remplacer par `"Invite"` en utilisant `??=` **ou** une logique équivalente.
- L’utilisateur est **connecté** si :

  - (`login` n’est pas `"Invite"` ET `password` vaut `"1234"`) **OU**
  - (`adminCode` vaut `"ADMIN"`)

- Afficher `Acces autorise` ou `Acces refuse` en utilisant **l’opérateur ternaire** `?:`.
- Attention à la priorité `&&` / `||` : parenthèses obligatoires.
