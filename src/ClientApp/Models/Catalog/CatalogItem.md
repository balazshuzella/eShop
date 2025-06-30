# Dokumentation: CatalogItem

## Übersicht
Die Klasse `CatalogItem` repräsentiert einen einzelnen Katalogartikel im eShop-System. Sie enthält alle relevanten Eigenschaften, um ein Produkt im Katalog zu beschreiben, einschließlich Name, Beschreibung, Preis, Bild, Marke und Typ.

## Eigenschaften

| Eigenschaft         | Typ             | Beschreibung                                      |
|---------------------|-----------------|---------------------------------------------------|
| `Id`                | int             | Eindeutige Kennung des Katalogartikels            |
| `Name`              | string          | Name des Produkts                                 |
| `Description`       | string          | Beschreibung des Produkts                         |
| `Price`             | decimal         | Preis des Produkts                                |
| `PictureUri`        | string          | URI zum Produktbild                               |
| `CatalogBrandId`    | int             | Fremdschlüssel zur Marke                          |
| `CatalogBrand`      | CatalogBrand    | Navigationsobjekt zur Marke                       |
| `CatalogTypeId`     | int             | Fremdschlüssel zum Produkttyp                     |
| `CatalogType`       | CatalogType     | Navigationsobjekt zum Produkttyp                  |

## Beispiel
```csharp
var item = new CatalogItem
{
    Id = 1,
    Name = "T-Shirt",
    Description = "Hochwertiges Baumwoll-T-Shirt",
    Price = 19.99m,
    PictureUri = "https://eshop.com/images/tshirt.png",
    CatalogBrandId = 2,
    CatalogTypeId = 3
};
```

## Hinweise
- Die Klasse wird typischerweise für die Anzeige und Verwaltung von Produkten im Katalog verwendet.
- Die Navigationseigenschaften `CatalogBrand` und `CatalogType` ermöglichen den Zugriff auf weitere Details zur Marke und zum Typ.

---

*Datei automatisch generiert am 30.06.2025.*
