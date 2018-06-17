using System;
using System.Threading;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace EnergyJourney.Pages
{
    public class EconomyMeterPage {
        private readonly IWebDriver driver;

        public EconomyMeterPage(IWebDriver driver) {
            this.driver = driver;
            PageFactory.InitElements(driver, this);
        }

        [FindsBy(How = How.Id, Using = "economy7-yes")]
        private IWebElement btnEconomyMeterYes;

        [FindsBy(How = How.Id, Using = "economy7-no")]
        private IWebElement btnEconomyMeterNo;

        [FindsBy(How = How.XPath, Using = "//input[@class='next']")]
        private IWebElement btnNextOk;

        public void SelectSmartMeter(Boolean smartMeter) {
            //WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(20));
            //IWebElement myDynamicElement = wait.Until<IWebElement>(d => btnNextOk)));
            Thread.Sleep(1000);
            if (smartMeter) {
                btnEconomyMeterYes.Click();
            } else
                btnEconomyMeterNo.Click();

            ((IJavaScriptExecutor)driver).ExecuteScript("arguments[0].scrollIntoView(true);", btnNextOk);
                        
            ((IJavaScriptExecutor)driver).ExecuteScript("arguments[0].click();", btnNextOk);

        }
    }
}
