# Architecture : Couche Domaine

La couche Domaine est le cœur du logiciel. Elle ne dépend d'aucune autre couche et contient toute la logique métier, les règles de validation et le modèle de données conceptuel.

## Entités

### Product

L'entité principale gérant les produits.

**Propriétés :**

- `Id` (Guid) : Identifiant unique.
- `Price` (decimal) : Prix actuel du produit.
- `IsActive` (bool) : État du produit (Actif/Inactif). Initialisé à `true`.

**Règles Métier (Invariants) :**
Ces règles sont vérifiées à chaque modification de l'état de l'objet.

1.  **Validité du Prix** : Le prix ne peut jamais être inférieur ou égal à 0.
2.  **État Actif** : Il est interdit de modifier le prix d'un produit inactif (`IsActive == false`).

**Méthodes :**

- `ChangePrice(decimal newPrice)` :
  - Vérifie les invariants ci-dessus.
  - Lève une `DomainException` en cas d'erreur.
  - Met à jour la propriété `Price`.

## Exceptions

### DomainException

Exception spécialisée utilisée pour signaler toute violation d'une règle métier. Elle doit être capturée par la couche Application ou présentée proprement à l'utilisateur (via l'API).

## Interfaces Repository

Le domaine définit les contrats pour la persistance, mais ne les implémente pas.

- `IProductRepository` :
  - `GetById(Guid id)` : Récupération d'un agrégat.
  - `Save(Product product)` : Sauvegarde des changements.
