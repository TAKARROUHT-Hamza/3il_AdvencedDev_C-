# Documentation API

Ce document liste les endpoints exposés par l'API `AdvencedDevSample.API`.

## Vue d'ensemble

L'API est construite sur **ASP.NET Core Minimal APIs**. Elle expose une documentation OpenAPI (Swagger) accessible en environnement de développement via `/swagger` ou `/scalar` selon la configuration.

## Endpoints

### WeatherForecast

_Exemple de Endpoint généré par le template._

- **URL** : `/weatherforecast`
- **Méthode** : `GET`
- **Description** : Renvoie des prévisions météo aléatoires pour tester la connectivité de l'API.
- **Réponse (200 OK)** : `application/json`
  ```json
  [
    {
      "date": "2026-01-29",
      "temperatureC": 10,
      "summary": "Bracing",
      "temperatureF": 49
    },
    ...
  ]
  ```

### Produits (À venir)

Les services métier pour les produits (`ProductService`) sont prêts dans la couche Application mais ne sont pas encore exposés via des endpoints HTTP.

**Endpoints prévus :**
| Méthode | URL | Description |
|OS|Endpoint|Description|
|---|---|---|
| `POST` | `/products/{id}/price` | Changer le prix d'un produit |
