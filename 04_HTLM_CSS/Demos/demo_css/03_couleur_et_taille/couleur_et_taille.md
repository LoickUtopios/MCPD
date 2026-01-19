### Notations de Couleur

En CSS, les couleurs peuvent être définies de plusieurs façons. Voici les plus courantes :

1. **Noms de Couleurs** :
   ```css
   color: red;
   ```

2. **Hexadécimal** :
   ```css
   color: #ff0000; /* Rouge */
   color: #f00; /* Rouge court */
   ```

3. **RGB (Red, Green, Blue)** :
   ```css
   color: rgb(255, 0, 0); /* Rouge */
   ```

4. **RGBA (Red, Green, Blue, Alpha)** :
   ```css
   color: rgba(255, 0, 0, 0.5); /* Rouge avec 50% d'opacité */
   ```

5. **HSL (Hue, Saturation, Lightness)** :
   ```css
   color: hsl(0, 100%, 50%); /* Rouge */
   ```

6. **HSLA (Hue, Saturation, Lightness, Alpha)** :
   ```css
   color: hsla(0, 100%, 50%, 0.5); /* Rouge avec 50% d'opacité */
   ```

### Unités de Taille

Les unités de taille les plus courantes en CSS incluent :

1. **Pixels (px)** :
   ```css
   font-size: 16px;
   ```

2. **Em (em)** :

   - `em` est relatif à la taille de police de l'élément parent.
   - Par défaut, 1 `em` = 16 pixels (si la taille de police de l'élément parent n'est pas modifiée).

   ```css
   font-size: 1.5em; /* 1.5 fois la taille de police de l'élément parent */
   ```

3. **Rem (root em)** : 

   - `rem` est relatif à la taille de police de l'élément racine (`<html>`).
   - Par défaut, 1 `rem` = 16 pixels (si la taille de police de l'élément `<html>` n'est pas modifiée).

   ```css
   font-size: 1rem; /* 1 fois la taille de police de l'élément racine (html) */
   ```

4. **Pourcentage (%)** :
   ```css
   font-size: 150%; /* 150% de la taille de police de l'élément parent */
   ```

5. **Viewport Width (vw)** :
   ```css
   font-size: 10vw; /* 10% de la largeur de la fenêtre */
   ```

6. **Viewport Height (vh)** :
   ```css
   font-size: 10vh; /* 10% de la hauteur de la fenêtre */
   ```

