using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace EnergyJourney.Pages
{
    public class HomePage {

        private readonly IWebDriver driver;

        public HomePage(IWebDriver driver) {
            this.driver = driver;
            PageFactory.InitElements(driver, this);
        }

        [FindsBy(How = How.Id, Using = "postcode-energy")]
        private IWebElement inputPostCode;

        [FindsBy(How = How.XPath, Using = "//input[@type='submit']")]
        private IWebElement btnSubmit;

        public void EnterPostCode(String postCode) {
            inputPostCode.SendKeys(postCode);
        }

        public void clickSubmitButton() {
            btnSubmit.Click();
        }

    }
}
