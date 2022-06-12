# BookStoreApp
## Développé par Mike Godfrinne et Jordan Godfrinne

1) Application
L'application est une gestion de livres réalisé avec les CRUD. Ce qui veut dire que nous pouvons ajouter, supprimer, visualiser et éditer un livre par le biais d'une interface graphique que nous n'avons pas réalisé nous même. Nous avons pris le template proposé par microsoft qui est à onglet. Notre objectif était de faire une application fonctionnel et non visuel car ce n'est que subsidaire d'après nous et certains fichier sont inutiles mais n'ont pas encore été supprimé. (Du moins pour le moment).

2) Développement futur

- Barre de recherche
- Ajout de favoris
- Statistique de prix
- Et bien d'autre

3) Installation
- Visual Studio et émulateur Android
- Modification du port dans le fichier Services/BookDataStore à la ligne 18
- Chargement des dépendances mongoDriver, newtonsoft.json,...

4) Les difficultés rencontrées

Nous avons eu beaucoup de mal à réalisé le projet par manque de connaissances et par manque de temps.

- Le pattern MVVM, nous n'avions pas trop compris comment l'utiliser mais finalement nous avons compris.
- Nous avons eu du mal avec Git également pour finalement le laisser de côté et le comprendre une fois le projet fonctionnel.

# Tests Fonctionnels

1) Ouverture de l'application : ok
2) Navigation dans la booklist : ok
3) Bouton ajouter utilisable et renvois sur la page d'ajout: ok
4) Zone de texte fonctionelle : ok
5) Bouton ajouté utilisable et renvois sur la booklist avec le nouvelle élement : ok
6) Elément de la liste clivable et renvois sur la page d'édition et de surpression : ok
7) Zone de texte fonctionnelle : ok 
8) Bouton édition fonctionnelle et renvois sur la booklist avec les nouveaux éléments : ok
8bis) Bouton suppression fonctionnelle et renvois sur la booklist en supprimant l'élément : ok
