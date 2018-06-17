using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using TechTalk.SpecFlow;
using System.Threading;

namespace EnergyJourney.Pages
{
    public class EnergyUsagePage
    {
        private readonly IWebDriver driver;

        public EnergyUsagePage (IWebDriver driver)
        {
            this.driver = driver;
            PageFactory.InitElements(driver, this);
        }

        [FindsBy(How = How.Id, Using = "elUsage")]
        private IWebElement inputElectricity;

        [FindsBy(How = How.Id, Using = "gasUsage")]
        private IWebElement inputGas;

        [FindsBy(How = How.Id, Using = "dissableOnClick")]
        private IWebElement btnSubmit;

        public void enterFuelUsage(int annualElectricity, int annualGas) {
            
            var fuel = ScenarioContext.Current["selectedFuelType"];

            switch (fuel) {
                case "Gas & Electricity":
                    inputElectricity.SendKeys(annualElectricity.ToString());
                    inputGas.SendKeys(annualGas.ToString());
                    btnSubmit.Click();
                    break;
                case "Electricity":
                    inputElectricity.SendKeys(annualElectricity.ToString());
                    btnSubmit.Click();
                    break;
                case "Gas":
                    inputGas.SendKeys(annualGas.ToString());
                    btnSubmit.Click();
                    break;
                default:
                    throw new ArgumentException("Invalid Fuel. We don't cater for this fuel type at the moment");
            }
        }
    }
}
