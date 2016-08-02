Feature: Ensure regressions do not reoccur
	

Background: 
	Given I am on the home page
	And I am logged in

@mytag
Scenario: [SU-2333] Error page - Can't view legacy Try On
	Given I am on the outfit builder
	When I select a suit
	And I select neckwear
	And I proceed to the outfit summary
	And I order a try on
	And I view the try on from the orders page
	Then I should be on the complete your order page
