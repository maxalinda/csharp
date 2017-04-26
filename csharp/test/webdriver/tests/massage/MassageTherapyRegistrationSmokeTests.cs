using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp.test.webdriver.tests.massage
{
    class MassageTherapyRegistrationSmokeTests
    {
        IWebDriver driver;

        String baseUrl = "http://moncherleo.github.io/";
        String thankYouMessage = "Thank You!";

        By firstName = By.XPath("//input[contains(@id,'first_64')]");
        By middleName = By.XPath("//input[@id='middle_64'][@type='text']");
        By lastName = By.XPath("//*[@data-type='control_fullname']//*[contains(text(),'Last Name')]/preceding-sibling::input");

        By streetAddress = By.XPath("//*[@class='form-address-table']//*[contains(@name,'addr_line1')]");
        By streetAddress2 = By.XPath("//input[@id='input_66_addr_line2']");
        By city = By.CssSelector(".form-address-table input[id$='city']");
        By state = By.CssSelector(".form-address-table .form-address-state");
        By postal = By.XPath("//input[@id='input_66_postal']"); 
        By country = By.XPath("//select[@id='input_66_country']");
        By countrySelect = By.XPath("//select[@id='input_66_country']/option[@value='Ukraine']");

        By submit = By.XPath("//button[@id='input_62']");
        By thank = By.XPath("//span[contains(text(),'Thank You!')]");

        [SetUp]
        public void SetUp()
        {
            var options = new FirefoxOptions();
            options.BrowserExecutableLocation = @"C:\Program Files\Mozilla Firefox\firefox.exe";
            driver = new FirefoxDriver(options);
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            driver.Navigate().GoToUrl(baseUrl);           
        }

        [TearDown]
        public void TearDown()
        {
            driver.Quit();
        }

        [Test]
        public void FullNameWithAdressTest() {
            driver.FindElement(firstName).SendKeys("Sasha");
            driver.FindElement(middleName).SendKeys("Igorevich");
            driver.FindElement(lastName).SendKeys("Cvetkov");

            driver.FindElement(streetAddress).SendKeys("Balzaka");
            driver.FindElement(streetAddress2).SendKeys("83/2");
            driver.FindElement(state).SendKeys("Kievskaya");
            driver.FindElement(city).SendKeys("Kiev");
            driver.FindElement(postal).SendKeys("09287");

            IWebElement select = driver.FindElement(country);
            SelectElement dropdown = new SelectElement(select);
            dropdown.SelectByText("Ukraine");

            driver.FindElement(submit).Click();

            Assert.AreEqual(thankYouMessage, driver.FindElement(thank).Text);

        }
    }
}
