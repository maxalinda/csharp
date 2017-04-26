using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp.test.webdriver.tests.massagePageObject.tests
{
    class BaseTest
    {
        public IWebDriver driver;      
       
        [SetUp]
        public void SetUp()
        {
            var options = new FirefoxOptions();
            options.BrowserExecutableLocation = @"C:\Program Files\Mozilla Firefox\firefox.exe";
            driver = new FirefoxDriver(options);
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            driver.Navigate().GoToUrl(AbstractPage.baseUrl);
        }

        [TearDown]
        public void TearDown()
        {
            driver.Quit();
        }

    }
}
