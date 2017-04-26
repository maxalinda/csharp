using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp.test.webdriver.tests.massagePageObject.pages
{
    class ThankYouPage : AbstractPage
    {       
        public ThankYouPage(IWebDriver driver)
            : base(driver) { }

        String thankYouMessage = "Thank You!";
        By thank = By.XPath("//span[contains(text(),'Thank You!')]");

        public ThankYouPage AssertCOnfirmationPageDisplayed() {
            Assert.AreEqual(thankYouMessage, driver.FindElement(thank).Text);
            return this;
        }



    }
}
