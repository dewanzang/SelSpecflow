using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using TechTalk.SpecFlow;
using System.Threading;

namespace EnergyJourney.Pages
{
    public class FuelTypePage {
        private readonly IWebDriver driver;

        public FuelTypePage(IWebDriver driver)
        {
            this.driver = driver;
            PageFactory.InitElements(driver, this);
        }

        [FindsBy(How = How.Id, Using = "gas-electricity")]
        private IWebElement btnGasElectricity;

        [FindsBy(How = How.Id, Using = "electricity")]
        private IWebElement btnElectricity;

        [FindsBy(How = How.Id, Using = "gas")]
        private IWebElement btnGas;

        [FindsBy(How = How.XPath, Using = "//input[@class='next']")]
        private IWebElement btnSubmit;

        public void SelectFuelType(String fuelType) {
            ScenarioContext.Current["selectedFuelType"] = fuelType;
            //WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(20));
            //IWebElement myDynamicElement = wait.Until<IWebElement>(d => btnGasElectricity)));
            Thread.Sleep(7000); //bad practice but ok for now since above WebDriverWait is not working for some reason

            switch (fuelType)
            {
                case "Gas & Electricity":
                    btnGasElectricity.Click();
                    btnSubmit.Click();
                    break;
                case "Electricity":
                    btnElectricity.Click();
                    btnSubmit.Click();
                    break;
                case "Gas":
                    btnGas.Click();
                    btnSubmit.Click();
                    break;
                default:
                    throw new ArgumentException("Invalid Fuel Type. We don't cater for this fuel type at the moment");
            }
        }
    }
}
