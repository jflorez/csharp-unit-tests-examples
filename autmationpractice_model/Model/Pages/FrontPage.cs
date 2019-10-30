using System;
using System.Linq;
using autmationpractice_model.Model.Products;
using OpenQA.Selenium;

namespace autmationpractice_model.Model.Pages {
    public class FrontPage :BasePage {
        public FrontPage(IWebDriver driver) : base(driver) {
        }

        public Product GetProduct(Func<Product, bool> comparator) {
           return driver.FindElements(By.ClassName("ajax_block_product")).Select(e => new Product(e)).First(p => comparator(p));
        }
    }
}
