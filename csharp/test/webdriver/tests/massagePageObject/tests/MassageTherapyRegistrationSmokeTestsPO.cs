using csharp.test.webdriver.tests.massagePageObject.pages;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp.test.webdriver.tests.massagePageObject.tests
{
    class MassageTherapyRegistrationSmokeTestsPO : BaseTest
    {
        [Test]
        public void ErrorsForEmptyFullNameAndAdressTest()
        {
            new FormPage(driver)
                .SubmitFormDataWithEmptyFields()
                .AssertEmptyFieldsErrors();
        }
        [Test]
        public void FullNameWithAdressTest() {
            new FormPage(driver)
                .FillFullName("Max", "Sergeyevich", "Petrosian")
                .FillStreetsAddresses("Balzaka", "83/2")
                .FillCityAndState("Kiev", "Kievskaya")
                .FillPostalCodeCountry("02032", "Ukraine")
                .SubmitFormData()
                .AssertCOnfirmationPageDisplayed();

        }
        
    }
}
