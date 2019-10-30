using System;
using System.Linq;
using System.Text.RegularExpressions;
using OpenQA.Selenium;

namespace autmationpractice_model.Model.Products {
    public class Product {

        private IWebElement rootElement;

        public Product(IWebElement rootElement) {
            this.rootElement = rootElement;
        }

        public double GetOriginalPrice() {
            double price = GetDoubleValue(By.ClassName("old-price"));
            return price == 0.0 ? GetPrice() : price;
        }

        public double GetDiscount() {
            return GetDoubleValue(By.ClassName("price-percent-reduction"));
        }

        public string GetName() {
            return rootElement.FindElement(By.ClassName("product-name")).Text;
        }

        public double GetPrice() {
            return GetDoubleValue(By.ClassName("price"));
        }

        private double GetDoubleValue(By locator) {
            try {
                return rootElement.FindElements(locator).Where(e => e.Displayed).Select(e => Double.Parse(Regex.Replace(e.Text, "[^\\d\\.]", ""))).First();
            } catch {
                return 0.0;
            }
        }
    }
}
