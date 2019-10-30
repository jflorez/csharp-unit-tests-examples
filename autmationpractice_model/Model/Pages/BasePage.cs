using System;
using OpenQA.Selenium;

namespace autmationpractice_model.Model.Pages {
    public abstract class BasePage {

        protected IWebDriver driver;

        protected BasePage(IWebDriver driver) {
            this.driver = driver;
        }
    }
}
