# Calculateur de chaine
## Enoncé

1. Creer un calculateur a base de chaine en entrée, par exemple avec une méthode `int Add(String numbers)`
+ La méthode peut prendre 0, 1 ou 2 nombres et retourne leur somme.
  + vous pouvez avoir en entrée des choses comme : `""`, `"1"` ou `"1,2"`
  + Si on vous passe une chaine vide vous retournez 0
+ Commencez avec un test sur une chaine vide, puis ajoutez la complexité graduellement, 1 chiffre, puis 2 etc...
+ La difficulté et d'écrire les bons tests, un bon moyen d'y arrivé et de se forcé à faire les choses le plus simple possible, afin de découvrir des tests auxquels on ne pensait pas.
+ Vous pouvez refactorez votre code aprés chaque test.
2. Maintenant faites evoluer votre code de manière à prendre en compte un nombre quelconque de nombres.
3. On doit pouvoir avoir des "retours chariots" entre les nombres plutot que des virgules
+ L'entrée suivante est valide:  `1\n2,3`  (la somme vaut 6)
+ L'entrée suivante, elle, est invalide : `1,\n`
4. Supporter des delimiteurs differents
+ Pour changer un délimiteur, au démarrage de la chaine on l'indique comme suis : `//[delimiteur]\n[nombres]` par exemple `//;\n1;2` doit donner comme somme 3 avec un delimiteur par défaut qui est `;`.
+ Oh, la ligne de définition d'un délimiteur est optionelle, les scénarios précédents doivent toujours fonctionner.

Si vous en êtes ici, et que vous avez déjà passer le cap de la demi-heure, vous pouvez vous arreter. Sinon vous pouvez continuez :

5. Les nombres plus grand que 1000 sont ignorés, par exemple ajouter 2 à 1001 donne 2.
6. Les délimiteurs peuvent avoir n'importe quelle longueur et plus juste un seul caractere. par exemple `//[***]\n1***2***3` doit donner 6.
7. Proposez plusieurs délimiteurs : `//[delim1][delim2]\n` par exemple `//[*][%]\n1*2%3` doit retourner 6.
+ Vérifiez bien que vous pouvez utilisez des délimiteurs plus long qu'un seul caractere.
