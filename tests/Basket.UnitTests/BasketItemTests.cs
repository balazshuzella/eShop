using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using eShop.Basket.API.Model;
using Xunit;

namespace eShop.Basket.UnitTests
{
    public class BasketItemTests
    {
        [Theory]
        [InlineData(1, true)]
        [InlineData(5, true)]
        [InlineData(0, false)]
        [InlineData(-1, false)]
        public void Validate_Quantity_Checks(int quantity, bool isValid)
        {
            // Arrange
            var item = new BasketItem
            {
                Id = "1",
                ProductId = 10,
                ProductName = "Testprodukt",
                UnitPrice = 9.99m,
                OldUnitPrice = 12.99m,
                Quantity = quantity,
                PictureUrl = "https://example.com/bild.png"
            };

            // Act
            var results = new List<ValidationResult>(item.Validate(new ValidationContext(item)));

            // Assert
            if (isValid)
            {
                Xunit.Assert.Empty(results);
            }
            else
            {
                Xunit.Assert.NotEmpty(results);
            }
        }
    }
}
