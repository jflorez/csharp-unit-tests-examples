using System;
using OpenQA.Selenium;
using NUnit.Framework;
using OpenQA.Selenium.Chrome;

namespace automationpractice_nunit.Tests {
    public class BaseTests {
        protected IWebDriver driver;

        [SetUp]
        public void Setup() {
            driver = new ChromeDriver(); //The type of driver should be read from env vars or config and built according to that value
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(3); //Length of implicit wat should be read from env vars or config
            driver.Manage().Window.Maximize();
            driver.Navigate().GoToUrl("http://automationpractice.com/index.php"); //Test environment URL should be read from env vars or config
            //To decide between using env vars or config have a look at https://12factor.net/config
        }

        [TearDown]
        public void Teardown() {
            driver.Quit();
        }
    }
}
