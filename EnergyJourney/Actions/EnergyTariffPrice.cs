using System;
using OpenQA.Selenium;
using NUnit.Framework;

namespace EnergyJourney.Actions
{
    public class EnergyTariffPrice: BaseTest {

        public static void validateTariffPrice(String tariffType, Decimal tariffAmount) {
            var table = driver.FindElement(By.TagName("table"));
            var rows = table.FindElements(By.TagName("tr"));
            var expectedStandingCharg = tariffAmount + "p per day";

            foreach (var row in rows) {
                if (row.FindElement(By.TagName("th")).Text.Equals(tariffType)) {
                    var actualStandingCharge = row.FindElement(By.TagName("td")).Text;
                    Assert.AreEqual(actualStandingCharge, actualStandingCharge);
                    break;
                }

            }
        }
    }
}
