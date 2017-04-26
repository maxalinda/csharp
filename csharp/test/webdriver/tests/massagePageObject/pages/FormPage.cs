using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp.test.webdriver.tests.massagePageObject.pages
{
    class FormPage : AbstractPage
    {       
        public FormPage(IWebDriver driver)
            : base(driver) { }

        By firstNamePath = By.XPath("//input[contains(@id,'first_64')]");
        By middleNamePath = By.XPath("//input[@id='middle_64'][@type='text']");
        By lastNamePath = By.XPath("//*[@data-type='control_fullname']//*[contains(text(),'Last Name')]/preceding-sibling::input");
             

        By streetAddressPath = By.XPath("//*[@class='form-address-table']//*[contains(@name,'addr_line1')]");
        By streetAddress2Path = By.XPath("//input[@id='input_66_addr_line2']");
        By cityPath = By.CssSelector(".form-address-table input[id$='city']");
        By statePath = By.CssSelector(".form-address-table .form-address-state");
        By postalPath = By.XPath("//input[@id='input_66_postal']");
        By countryPath = By.XPath("//select[@id='input_66_country']");
        By countrySelect = By.XPath("//select[@id='input_66_country']/option[@value='Ukraine']");

        By submitPath = By.XPath("//button[@id='input_62']");

        By errorEmptyFullNamePath = By.XPath("//div[@id = 'cid_64']/div[@class = 'form-error-message']");
        By errorEmptyAddressPath = By.XPath("//div[@id = 'cid_66']/div[@class = 'form-error-message']");

        public FormPage FillFullName(String firstName, String middleName, String lastName) {

            TypeText(firstNamePath, firstName);
            TypeText(middleNamePath, middleName);
            TypeText(lastNamePath, lastName);                                  
            return this;
        }

        public FormPage FillStreetsAddresses(String street1, String street2) {
            TypeText(streetAddressPath, street1);
            TypeText(streetAddress2Path, street2);
            return this;
        }

        public FormPage FillCityAndState(String city, String state) {
            TypeText(cityPath, city);
            TypeText(statePath, state);
            return this;
        }
        
        public FormPage FillPostalCodeCountry(String postalCode, String country)
        {
            TypeText(postalPath, postalCode);
            IWebElement select = driver.FindElement(countryPath);
            SelectElement dropdown = new SelectElement(select);
            dropdown.SelectByText(country);
            return this;
        }

        public ThankYouPage SubmitFormData()
        {
            Click(submitPath);            
            return new ThankYouPage(driver);
        }

        String emptyFullNameError = "This field is required.";
        String emptyAddressError = "This field is required.";        
        
        public FormPage AssertEmptyFieldsErrors() {
            Assert.AreEqual(emptyFullNameError, driver.FindElement(errorEmptyFullNamePath).Text);
            Assert.AreEqual(emptyAddressError, driver.FindElement(errorEmptyAddressPath).Text);
            return this;
        }

        public FormPage SubmitFormDataWithEmptyFields()
        {
            Click(submitPath);
            return this;
        }

    }
}
