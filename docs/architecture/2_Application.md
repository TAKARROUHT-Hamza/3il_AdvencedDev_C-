# Architecture : Couche Application

La couche Application orchestre les interactions entre le monde extérieur (API) et le Domaine. Elle contient les cas d'utilisation (Use Cases) du système.

## Services

### ProductService

Service responsable de la manipulation des produits.

**Dépendances :**

- `IProductRepository` : Pour récupérer et sauvegarder les entités.

**Méthodes (Cas d'Utilisation) :**

#### `ChangeProductPrice`

Permet de modifier le prix d'un produit existant.

**Signature :**

```csharp
void ChangeProductPrice(Guid productId, ChangePriceRequest request)
```

**Logique d'exécution :**

1.  **Récupération** : Appelle le repository pour obtenir le produit via son `ID`.
    - _Erreur_ : Si le produit est null, renvoie une erreur (ou lève une exception non-domaine, ex: `ApplicationServiceException` ou `KeyNotFoundException`).
2.  **Action Métier** : Appelle `product.ChangePrice(...)` sur l'entité récupérée.
3.  **Persistance** : Appelle `_repo.Save(product)` pour valider la transaction.

## DTOs (Data Transfer Objects)

Objets simples utilisés pour passer des données à la couche Application.

- **ChangePriceRequest** : Contient le `NewPrice`.
