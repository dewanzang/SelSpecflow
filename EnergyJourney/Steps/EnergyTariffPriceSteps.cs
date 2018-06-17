using System;
using TechTalk.SpecFlow;
using OpenQA.Selenium;
using EnergyJourney.Actions;


namespace EnergyJourney.Steps
{
    [Binding]
    public class EnergyTariffPriceSteps: BaseTest {

        [Given(@"User is at the Energy Home Page")]
        public void UserIsAtTheEnergyHomePage() {
            NavigateToURL("https://sse.co.uk/Energy");
        }

        [When(@"User enter the PostCode '(.*)'")]
        public void UserEnterThePostCode(string postCode) {
            _homePage.EnterPostCode(postCode);
            _homePage.clickSubmitButton();
        }
        
        [When(@"Select Fuel Type '(.*)'")]
        public void SelectFuelType(string fuelType) {
                       
            _fuelTypePage.SelectFuelType(fuelType);            
        }

        [When(@"Select Smart Meter (true|false)")]
        public void SelectSmartMeter(Boolean smartMeter) {

            _smartMeterPage.SelectSmartMeter(smartMeter);
       }

        [When(@"Select Economy 7 (true|false)")]
        public void SelectEconomy7(Boolean Economy7) {

            _economyMeterPage.SelectSmartMeter(Economy7);
        }

        [When(@"Select Payment Type '(.*)'")]
        public void SelectPaymentType(String paymentType) {

            _paymentMethodPage.SelectSmartMeter(paymentType);
        }

        [When(@"Select Paperless Billing (true|false)")]
        public void SelectPaperlessBilling(Boolean paperlessBilling) {

            _paperlessBillingPage.SelectPaperlessBilling(paperlessBilling);
        }

        [When(@"Enter Annual Electricity (.*) and Gas usage (.*)")]
        public void EnterAnnualElectricityUsage(int annualElectricity, int annualGas) {

            _energyUsagePage.enterFuelUsage(annualElectricity, annualGas);
        }

        [Then(@"The Electricity Standing Charge value is displayed on Electricity tariff information (.*)")]
        public void TheElectricityStandingChargeIsDisplayed( Decimal electricityStandingCharg) {
            
            _tariffPage.navigateToElectricityInformation();
            EnergyTariffPrice.validateTariffPrice("Standing Charge", electricityStandingCharg);
        }
               
        [Then(@"The Gas Standing Charge value is displayed on the tariff information (.*)")]
        public void TheGasStandingChargeValueIsDisplayedOnTheTariffInformation(Decimal gasStandingCharg) {

            ((IJavaScriptExecutor)driver).ExecuteScript("location.reload()");
            _tariffPage.navigateToGasInformation();
            EnergyTariffPrice.validateTariffPrice("Standing Charge", gasStandingCharg);            
        }        
    }
}
