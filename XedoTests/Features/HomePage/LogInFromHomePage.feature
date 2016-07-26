Feature: LogInFromHomePage
	In order log in
	As a user on the home page
	I want to submit valid login credentials

Background: 
	Given I am on the home page

@homepage @login
Scenario: user logs in with valid credentials via sidebar on home page
	When I attempt to sign into the via the sidebar with username "sbullets200@mailinator.com" and password "password"
	Then I should be logged in
	
@homepage @login
Scenario Outline: user fails to log in with invalid credentials via sidebar on home page
	When I attempt to sign into the via the sidebar with username "<email>" and password "<password>"
	Then I should be not logged in

	Examples: 
	| email                      | password |
	|                            | password |
	| sbullets200@mailinator.com |          |
	|                            |          |
	| not@anemail.com            | password |
	| sbullets200@mailinator.com | pass     |
