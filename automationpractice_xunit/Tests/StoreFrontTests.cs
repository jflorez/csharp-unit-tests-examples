using System;
using autmationpractice_model.Model.Pages;
using autmationpractice_model.Model.Products;
using Xunit;

namespace automationpractice_xunit.Tests {
    public class StoreFrontTests : BaseTest {

        [Fact]
        public void ValidateCorrectDiscount() {
            FrontPage frontPage = new FrontPage(driver);
            Product product = frontPage.GetProduct(p => p.GetName().Equals("Printed Summer Dress") && p.GetDiscount() == 5);
            double originalPrice = product.GetOriginalPrice();
            double discountedPrice = Math.Round(originalPrice - (product.GetDiscount() * originalPrice / 100), 2);
            Assert.Equal(discountedPrice, product.GetPrice());
        }
    }
}
