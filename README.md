# Ynov 2022 - Projet Dev

_Projet scolaire Dev 2022_

## 🐧 Sommaire

- [Ynov 2022 - Projet Dev](#ynov-2022---projet-dev)
  - [🐧 Sommaire](#-sommaire)
  - [🚀 Initialisation du projet](#-initialisation-du-projet)
    - [📅 Dates :](#-dates-)
    - [Idées de projets :](#idées-de-projets-)
    - [Explication du projet Gatcha / Autobattler :](#explication-du-projet-gatcha--autobattler-)
    - [Diagramme UML](#diagramme-uml)
    - [Code First](#code-first)
    - [Point d'entrée dans le projet](#point-dentrée-dans-le-projet)

## 🚀 Initialisation du projet

### 📅 Dates :

**Début 22/03/2022**

**Fin : 15/05/2022**

[Les groupes](https://auvencecom-my.sharepoint.com/:x:/g/personal/calvin_seaphanh_ynov_com/EUxJSOmsdAxIrsbqKYzvEjsBMn_ozul2SBlZ9ViMvaduCg?e=mo5wek)

### Idées de projets :

- Gatcha / AutoBatller ✔
- Flappy Bird Multi

### Explication du projet Gatcha / Autobattler :

Un jeu où on a des persos / cartes avec des statistiques définies. Un système de drop d'équipement aux stats aléatoires et des combats automatiques.

- Système de compte pour les joueurs - Modèle de donnée : 1 point
- Système de héros avec des statistiques fixes par niveau : Modèle de donnée + CRUD : 4 points
- Possibilité de créer une équipe de héros : 1 point
- Système d'expérience et de niveau pour les héros : 1 point
- Système d'équipement par héros : 3-4 points
- Système de loot aléatoire d'item défini (en % table de loot) : 3 points de base
- Système de gain de monnaie en fin de combat (Deux monnaies, une pour l'achat, l'autre pour l'upgrade)
- Monnaie 1 (Gold) permet de : Acheter des héros et de l'équipement
- Monnaie 2 (Cristaux) permet de : Upgrade équipements et héros
- Système de shop
- Système de combat automatique contre des Mobs : 4-5 points
- Gestion de tours de jeu pour les combats (système de vitesses et de stats pour les dégats) : 4-5 points
- Faire un GUI même moche

**Calcul des points de difficultés :**

| Points         | Fonctionnalités                                        |
| -------------- | ------------------------------------------------------ |
| 1              | Système de compte utilisateur                          |
| 4              | Système de héros avec des statistiques fixe par niveau |
| 1              | Possibilité de créer une équipe de héros               |
| 1              | Système d'expérience et de niveau pour les héros       |
| 2              | Système d'équipements améliorable                      |
| 4              | Système d'équipements par héro                         |
| 3              | Système de loot - Table de loot                        |
| 5              | Système de combat automatique contre des Mobs          |
| 5              | Gestion de tours de jeu pour les combats               |
| 2              | Système de gain de monnaie                             |
| 1              | Système d'upgrade avec la monnaie                      |
| 1              | Système d'achat avec la monnaie                        |
| 2              | Système de shop                                        |
| 3              | GUI Fonctionnelle                                      |
| **Total : 33** | 🎉                                                     |

### Diagramme UML

https://lucid.app/lucidchart/ba20625b-2ae6-41d8-b6c5-4e794edd410d/edit?invitationId=inv_13cb8111-dd2e-45eb-8264-245a8df27aba

### Code First

Pour le projet nous décidons de partir sur une approche **"Code First"**.
Nous allons donc créer les classes correspondantes à nos Models de données et créer des relations entre elle avec des données tempons.

### Point d'entrée dans le projet

Le point d'entrée sera la page : Créer un groupe de héro.

Sprint :

En premier : Mettre en place l'ORM (EntityFramework) avec la DB Docker

- [ ] Créer la page "Créer le groupe"
- [ ] Ajouter de la naviguation vers la page
- [ ] Récupérer une liste de 10 héros
- [ ] Afficher les 10 héros sur la page de création de groupe
- [ ] (Possiblement) Mettre en place la gestion de compte
