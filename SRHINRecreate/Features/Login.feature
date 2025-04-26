Feature: Login

Validate the SRHIN Parent portal Login

@LoginScreen
Scenario: Valdiate the Login screen
	Given on loading the url 
	When passing the username and password
	And clicking on the login button
	Then Dashboard should be displayed
