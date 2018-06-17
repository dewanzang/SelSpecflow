using System;
using System.Threading;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace EnergyJourney.Pages
{
    public class SmartMeterPage {
        private readonly IWebDriver driver;

        public SmartMeterPage(IWebDriver driver) {
            this.driver = driver;
            PageFactory.InitElements(driver, this);
        }

        [FindsBy(How = How.Id, Using = "smart-meter-yes")]
        private IWebElement btnSmartMeterYes;

        [FindsBy(How = How.Id, Using = "smart-meter-no")]
        private IWebElement btnSmartMeterNo;

        [FindsBy(How = How.XPath, Using = "//input[@class='next']")]
        private IWebElement btnNextOk;

        public void SelectSmartMeter(Boolean smartMeter) {
            Thread.Sleep(1000); 

            if (smartMeter) {
                btnSmartMeterYes.Click();
            } else
                btnSmartMeterNo.Click();

            ((IJavaScriptExecutor)driver).ExecuteScript("arguments[0].scrollIntoView(true);", btnNextOk);

            ((IJavaScriptExecutor)driver).ExecuteScript("arguments[0].click();", btnNextOk);

        }
    }
}
