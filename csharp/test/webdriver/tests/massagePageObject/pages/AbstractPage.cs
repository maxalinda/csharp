using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp.test.webdriver.tests.massagePageObject
{
    class AbstractPage
    {
        public AbstractPage(IWebDriver driver)
        {
            this.driver = driver;
        }

        public IWebDriver driver;
        public const String baseUrl = "http://moncherleo.github.io/";
        
        public void TypeText(By locator, String text)
        {
            IWebElement webElement;
            webElement = driver.FindElement(locator);
            webElement.Clear();
            webElement.SendKeys(text);
        }

        public void Click(By locator)
        {
            IWebElement webElement;
            webElement = driver.FindElement(locator);
            webElement.Click();            
        }
    }
}
