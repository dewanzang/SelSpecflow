using System;
using System.Threading;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace EnergyJourney.Pages {
    public class PaymentMethodPage {
        private readonly IWebDriver driver;

        public PaymentMethodPage(IWebDriver driver) {
            this.driver = driver;
            PageFactory.InitElements(driver, this);
        }

        [FindsBy(How = How.Id, Using = "directDebit")]
        private IWebElement btnMonthlyDirectDebit;

        [FindsBy(How = How.Id, Using = "quarterly")]
        private IWebElement btnQuarterly;

        [FindsBy(How = How.Id, Using = "pay-as-you-go")]
        private IWebElement btnPayAsYouGo;

        [FindsBy(How = How.XPath, Using = "//input[@class='next']")]
        private IWebElement btnNextOk;

        public void SelectSmartMeter(String paymentMethod) {
            Thread.Sleep(1000);
            if (paymentMethod.Equals("Monthly Direct Debit")) {
                btnMonthlyDirectDebit.Click();
            } else if (paymentMethod.Equals("Quarterly")) {
                btnQuarterly.Click();
            } else if (paymentMethod.Equals("PayAsYouGo")) 
                btnPayAsYouGo.Click();

            ((IJavaScriptExecutor)driver).ExecuteScript("arguments[0].scrollIntoView(true);", btnNextOk);

            //WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(20));
            //IWebElement myDynamicElement = wait.Until<IWebElement>(d => btnNextOk)));
            Thread.Sleep(1000);
            ((IJavaScriptExecutor)driver).ExecuteScript("arguments[0].click();", btnNextOk);

        }
    }
}
