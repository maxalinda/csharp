using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace csharp.test.webdriver
{
    class BaseTest
    {
        public IWebDriver driver;

        [SetUp]
        public void SetUp() {
            var options = new FirefoxOptions();
            options.BrowserExecutableLocation = @"C:\Program Files\Mozilla Firefox\firefox.exe";
            driver = new FirefoxDriver(options);
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
        }

        [TearDown]
        public void TearDown() {
            driver.Quit();
        }

        [Test]
        public void MySeleniumTest() {
            driver.Navigate().GoToUrl("https://www.google.com/");
            IWebElement query = driver.FindElement(By.Name("q"));
            query.SendKeys("Cheese");
            query.Submit();

            Thread.Sleep(10000);
            IReadOnlyCollection<IWebElement> webElements;
            webElements = driver.FindElements(By.CssSelector(".r>a"));
            Assert.True(webElements.Count > 0 );

        }


    }
}
