using Xunit;
namespace AdvencedDevSample.test.Domain.Entities
{
    public class PriceTests
    {
        [Fact]
        public void constructor_should_create_price_when_value_is_positive()
        {
            // Arrange
            var price = new Price(10);

            // Act & Assert
            Assert.Equal(10, price.Value);
        }

        [Fact]
        public void constructor_should_throw_when_value_is_zero_or_negative()
        {
            var exception = Assert.Throws<DomainException>(() => new Price(0));
            Assert.Equal("Le prix doit être positif.", exception.Message);
        }

        [Fact]
        public void ChangePrice_Should_Throw_Exception_When_Product_Is_Inactive()
        {
            // Arrange
            var product = new Product();
            product.ChangePrice(10);
            // Simulate deactivating the product
            typeof(Product).GetProperty(nameof(product.IsActive))!.SetValue(product, false);
            // Act & Assert
            var exception = Assert.Throws<InvalidOperationException>(() => product.ChangePrice(20));
            Assert.Equal("Cannot change price of an inactive product.", exception.Message);
        }

        [Fact]
        public void ApplyDiscount_Should_DeccreasePrice()
        {
            // Arrange
            var product = new Product();
            product.ChangePrice(100);
            // Act
            product.ApplyDiscount(30); // 30% discount
            // Assert
            Assert.Equal(90, product.Price);
        }

        [Fact]
        public void ApplyDiscount_Should_Throw_When_Resulting_Price_Is_InvalidO()
        {
            // Arrange
            var product = new Product();
            product.ChangePrice(20); // valeur initiale
            // Act & Assert
            Assert.Throws<DomainException>(() => product.ApplyDiscount(30));
        }
    }

}