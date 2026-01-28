# Architecture : Couche Infrastructure

La couche Infrastructure fournit les implémentations techniques nécessaires au fonctionnement du système (Base de données, Appels API externes, Système de fichiers, etc.). Elle dépend de toutes les autres couches.

## Persistance (Repositories)

_(Section à compléter lors de l'implémentation de la BDD)_

La couche Infrastructure implémentera l'interface `IProductRepository` définie dans le Domaine.

### Responsabilités futures :

- Mapping Objet-Relationnel (ORM) avec Entity Framework Core.
- Gestion des transactions SQL.
- Conversions des types C# vers types SQL.

## Injection de Dépendances

L'infrastructure est généralement responsable de l'assemblage final des services dans le conteneur DI (Dependency Injection) lors du démarrage de l'application (souvent via des méthodes d'extension comme `services.AddInfrastructure()`).
