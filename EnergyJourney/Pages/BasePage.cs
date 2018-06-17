using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;


namespace EnergyJourney.Pages
{
    public class BasePage {
        public static IWebDriver driver { get; set; }

        public static void Initialize() {
            //driver = new FirefoxDriver();
            //driver.Manage().Window.Maximize();

            ChromeOptions options = new ChromeOptions();
            options.AddArgument("--start-maximized");
            driver = new ChromeDriver(options);
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
        }

        public static void Close() {
            
            driver.Quit();
        }
        public static void NavigateToURL(String url) {
            driver.Navigate().GoToUrl(url);
        }        
    }
}
