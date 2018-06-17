using System;
using System.Threading;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using TechTalk.SpecFlow;

namespace EnergyJourney.Pages
{
    public class TariffPage {
        private readonly IWebDriver driver;

        public TariffPage(IWebDriver driver) {
            this.driver = driver;
            PageFactory.InitElements(driver, this);
        }

        [FindsBy(How = How.LinkText, Using = "Electricity information")]
        private IWebElement lnkElectricityInformation;

        [FindsBy(How = How.LinkText, Using = "Gas information")]
        private IWebElement lnkGasInformation;

        public void navigateToElectricityInformation() {
            lnkElectricityInformation.Click();
        }

        public void navigateToGasInformation() {
            
            lnkGasInformation.Click();
        }
    }
}
