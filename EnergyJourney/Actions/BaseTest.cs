using System;
using EnergyJourney.Pages;
using TechTalk.SpecFlow;

namespace EnergyJourney.Actions
{
    public class BaseTest: BasePage {
        public HomePage _homePage;
        public FuelTypePage _fuelTypePage;
        public EconomyMeterPage _economyMeterPage;
        public SmartMeterPage _smartMeterPage;
        public PaymentMethodPage _paymentMethodPage;
        public TariffPage _tariffPage;
        public PaperlessBillingPage _paperlessBillingPage;
        public EnergyUsagePage _energyUsagePage;

        [BeforeScenario]
        public void Setup() {
            Initialize();
            _homePage = new HomePage(driver);
            _fuelTypePage = new FuelTypePage(driver);
            _economyMeterPage = new EconomyMeterPage(driver);
            _smartMeterPage = new SmartMeterPage(driver);
            _paymentMethodPage = new PaymentMethodPage(driver);
            _tariffPage = new TariffPage(driver);
            _paperlessBillingPage = new PaperlessBillingPage(driver);
            _energyUsagePage = new EnergyUsagePage(driver);
        }
                
        [AfterScenario]
        public void TearDown() {
            Close();
        }
    }
}
