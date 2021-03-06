﻿using System;
using System.Threading;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace EnergyJourney.Pages
{
    public class PaperlessBillingPage {
        private readonly IWebDriver driver;

        public PaperlessBillingPage(IWebDriver driver) {
            this.driver = driver;
            PageFactory.InitElements(driver, this);
        }

        [FindsBy(How = How.Id, Using = "paperless-yes")]
        private IWebElement btnPaperlessBillingYes;

        [FindsBy(How = How.Id, Using = "paperless-no")]
        private IWebElement btnPaperlessBillingNo;

        [FindsBy(How = How.XPath, Using = "//input[@class='next']")]
        private IWebElement btnNextOk;

        public void SelectPaperlessBilling(Boolean paperlessBilling) {
            //WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(20));
            //IWebElement myDynamicElement = wait.Until<IWebElement>(d => btnNextOk)));
            Thread.Sleep(1000);
            if (paperlessBilling) {
                btnPaperlessBillingYes.Click();
            } else
                btnPaperlessBillingNo.Click();

            ((IJavaScriptExecutor)driver).ExecuteScript("arguments[0].scrollIntoView(true);", btnNextOk);

            ((IJavaScriptExecutor)driver).ExecuteScript("arguments[0].click();", btnNextOk);

        }
    }
}
