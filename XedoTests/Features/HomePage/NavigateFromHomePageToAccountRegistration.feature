Feature: NavigateFromHomePageToAccountRegistration
	In order to reach the account registration page
	As a user on the home page
	I want to be able to navigate to the registration page

Background: 
	Given I am on the home page
	
@homepage
Scenario: Click register now link
	When I click the register now link in the sidebar
	Then I am on the Xedo AccountRegistration page
