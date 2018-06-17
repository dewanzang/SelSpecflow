Feature: EnergyTariffPrice
In order to check the prices displayed for different tariff offerings 
As a user of the website
I want to sign up for different tarriff


Scenario Outline: The standing charge for SSE 1 Year Fixed v15 should be 19.18
	Given User is at the Energy Home Page
	When User enter the PostCode <PostCode>
	And Select Fuel Type <Fuel Type>
	And Select Smart Meter <Smart Meter>
	And Select Economy 7 <Economy 7>
	And Select Payment Type <Payment Type>
	And Select Paperless Billing <Paperless Billing>
	And Enter Annual Electricity <Annual Electricity> and Gas usage <Annual Gas>	
	Then The Electricity Standing Charge value is displayed on Electricity tariff information <Electricity Standing Charge>  
	And The Gas Standing Charge value is displayed on the tariff information <Gas Standing Charge> 
		
	Examples: 
	| PostCode  | Fuel Type          | Smart Meter | Economy 7 | Payment Type           | Paperless Billing | Annual Electricity | Annual Gas | Electricity Standing Charge | Gas Standing Charge |
	| 'PO9 1QH' | 'Gas & Electricity'| true        | false     | 'Monthly Direct Debit' | true              | 4500               | 4520       | 19.18                       | 19.18               |