Feature: Home Page Load Time
	

Scenario Outline: First time home page loads in good time
	Given I am on the outfit builder page
	When I go to the home page
	Then the page load time will be less than <Timeout> seconds

	Examples:
	 | Timeout |
	 | 3       |
	 | 3       |
	 | 3       |
	 | 3       |
	 | 3       |

Scenario Outline: Subsequent home page loads in good time
	Given I am on the home page
	When I go to the home page
	Then the page load time will be less than <Timeout> seconds

	Examples:
	 | Timeout |
	 | 3       |
	 | 3       |
	 | 3       |
	 | 3       |
	 | 3       |