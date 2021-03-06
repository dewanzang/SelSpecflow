﻿// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by SpecFlow (http://www.specflow.org/).
//      SpecFlow Version:2.3.2.0
//      SpecFlow Generator Version:2.3.0.0
// 
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------
#region Designer generated code
#pragma warning disable
namespace EnergyJourney.Features
{
    using TechTalk.SpecFlow;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "2.3.2.0")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [TechTalk.SpecRun.FeatureAttribute("EnergyTariffPrice", Description="In order to check the prices displayed for different tariff offerings \r\nAs a user" +
        " of the website\r\nI want to sign up for different tarriff", SourceFile="Features\\EnergyTariffPrice.feature", SourceLine=0)]
    public partial class EnergyTariffPriceFeature
    {
        
        private TechTalk.SpecFlow.ITestRunner testRunner;
        
#line 1 "EnergyTariffPrice.feature"
#line hidden
        
        [TechTalk.SpecRun.FeatureInitialize()]
        public virtual void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "EnergyTariffPrice", "In order to check the prices displayed for different tariff offerings \r\nAs a user" +
                    " of the website\r\nI want to sign up for different tarriff", ProgrammingLanguage.CSharp, ((string[])(null)));
            testRunner.OnFeatureStart(featureInfo);
        }
        
        [TechTalk.SpecRun.FeatureCleanup()]
        public virtual void FeatureTearDown()
        {
            testRunner.OnFeatureEnd();
            testRunner = null;
        }
        
        public virtual void TestInitialize()
        {
        }
        
        [TechTalk.SpecRun.ScenarioCleanup()]
        public virtual void ScenarioTearDown()
        {
            testRunner.OnScenarioEnd();
        }
        
        public virtual void ScenarioSetup(TechTalk.SpecFlow.ScenarioInfo scenarioInfo)
        {
            testRunner.OnScenarioStart(scenarioInfo);
        }
        
        public virtual void ScenarioCleanup()
        {
            testRunner.CollectScenarioErrors();
        }
        
        public virtual void TheStandingChargeForSSE1YearFixedV15ShouldBe19_18(string postCode, string fuelType, string smartMeter, string economy7, string paymentType, string paperlessBilling, string annualElectricity, string annualGas, string electricityStandingCharge, string gasStandingCharge, string[] exampleTags)
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("The standing charge for SSE 1 Year Fixed v15 should be 19.18", exampleTags);
#line 7
this.ScenarioSetup(scenarioInfo);
#line 8
 testRunner.Given("User is at the Energy Home Page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 9
 testRunner.When(string.Format("User enter the PostCode {0}", postCode), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 10
 testRunner.And(string.Format("Select Fuel Type {0}", fuelType), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 11
 testRunner.And(string.Format("Select Smart Meter {0}", smartMeter), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 12
 testRunner.And(string.Format("Select Economy 7 {0}", economy7), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 13
 testRunner.And(string.Format("Select Payment Type {0}", paymentType), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 14
 testRunner.And(string.Format("Select Paperless Billing {0}", paperlessBilling), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 15
 testRunner.And(string.Format("Enter Annual Electricity {0} and Gas usage {1}", annualElectricity, annualGas), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 16
 testRunner.Then(string.Format("The Electricity Standing Charge value is displayed on Electricity tariff informat" +
                        "ion {0}", electricityStandingCharge), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 17
 testRunner.And(string.Format("The Gas Standing Charge value is displayed on the tariff information {0}", gasStandingCharge), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("The standing charge for SSE 1 Year Fixed v15 should be 19.18, Variant 0", SourceLine=20)]
        public virtual void TheStandingChargeForSSE1YearFixedV15ShouldBe19_18_Variant0()
        {
#line 7
this.TheStandingChargeForSSE1YearFixedV15ShouldBe19_18("\'PO9 1QH\'", "\'Gas & Electricity\'", "true", "false", "\'Monthly Direct Debit\'", "true", "4500", "4520", "19.18", "19.18", ((string[])(null)));
#line hidden
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("The standing charge for SSE 1 Year Fixed v15 should be 19.18, Variant 1", SourceLine=20)]
        public virtual void TheStandingChargeForSSE1YearFixedV15ShouldBe19_18_Variant1()
        {
#line 7
this.TheStandingChargeForSSE1YearFixedV15ShouldBe19_18("\'PO9 1QH\'", "\'Electricity\'", "true", "false", "\'Monthly Direct Debit\'", "true", "4500", "4520", "19.18", "19.18", ((string[])(null)));
#line hidden
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("The standing charge for SSE 1 Year Fixed v15 should be 19.18, Variant 2", SourceLine=20)]
        public virtual void TheStandingChargeForSSE1YearFixedV15ShouldBe19_18_Variant2()
        {
#line 7
this.TheStandingChargeForSSE1YearFixedV15ShouldBe19_18("\'PO9 1QH\'", "\'Gas\'", "true", "false", "\'Monthly Direct Debit\'", "true", "4500", "4520", "19.18", "19.18", ((string[])(null)));
#line hidden
        }
        
        [TechTalk.SpecRun.TestRunCleanup()]
        public virtual void TestRunCleanup()
        {
            TechTalk.SpecFlow.TestRunnerManager.GetTestRunner().OnTestRunEnd();
        }
    }
}
#pragma warning restore
#endregion
