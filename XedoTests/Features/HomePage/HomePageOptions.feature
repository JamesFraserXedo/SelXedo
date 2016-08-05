Feature: HomePageOptions

Background: 
	Given I am on the home page

Scenario: The Let's Get Started button should take me to the collections page
	When I click the home page banner lets-get-started button
	Then I should be taken to the collections page

Scenario: The Perfect Match Get Started button should take me to the collections page
	When I click the perfect match get-started button
	Then I should be taken to the collections page

Scenario: The How It Works Get Started button should take me to the collections page
	When I click the how it works get-started button
	Then I should be taken to the collections page

Scenario Outline: The collections should create a popup displaying the correct details
	When I click the home page collection at index <index>
	Then a product details popup should appear
	And the product details should display the correct image
	And the product details should display the correct name
	And the product details should display the correct price

	Examples: 
	| index |
	| 0     |	
	| 1     |
	| 2     |
	| 3     |
	| 4     |
	| 5     |
	| 6     |
	| 7     |
	| 8     |
	| 9     |
	| 10    |
	| 11    |
	| 12    |
	| 13    |
	| 14    |
	| 15    |
	| 16    |
	| 17    |