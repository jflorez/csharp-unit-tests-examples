using System;
using autmationpractice_model.Model.Pages;
using autmationpractice_model.Model.Products;
using NUnit.Framework;

namespace automationpractice_nunit.Tests {
    public class StoreFrontTests : BaseTests {

        [Test]
        public void ValidateCorrectDiscount() {
            FrontPage frontPage = new FrontPage(driver);
            Product product = frontPage.GetProduct(p => p.GetName().Equals("Printed Summer Dress") && p.GetDiscount() == 5);
            double originalPrice = product.GetOriginalPrice();
            double discountedPrice = Math.Round(originalPrice - (product.GetDiscount() * originalPrice / 100), 2);
            Assert.AreEqual(discountedPrice, product.GetPrice());
        }
    }
}
