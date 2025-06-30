namespace eShop.Basket.API.Model;

public class BasketItem : IValidatableObject
{
    public string Id { get; set; }
    public int ProductId { get; set; }
    public string ProductName { get; set; }
    public decimal UnitPrice { get; set; }
    public decimal OldUnitPrice { get; set; }
    public int Quantity { get; set; }
    public string PictureUrl { get; set; }

    /// <summary>
    /// Überprüft die Eigenschaften des <see cref="BasketItem"/>-Objekts auf Gültigkeit.
    /// Stellt sicher, dass die Anzahl (<c>Quantity</c>) mindestens 1 ist.
    /// Gibt eine Liste von <see cref="ValidationResult"/> zurück, die alle Validierungsfehler enthält.
    /// </summary>
    /// <param name="validationContext">Der Kontext, in dem die Validierung ausgeführt wird.</param>
    /// <returns>
    /// Eine Auflistung von <see cref="ValidationResult"/>, die alle gefundenen Validierungsfehler enthält.
    /// Ist die Liste leer, sind alle geprüften Eigenschaften gültig.
    /// </returns>
    public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
    {
        var results = new List<ValidationResult>();

        if (Quantity < 1)
        {
            results.Add(new ValidationResult("Invalid number of units", new[] { "Quantity" }));
        }

        return results;
    }
}
