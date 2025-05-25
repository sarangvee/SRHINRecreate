Feature: Dashboard

Validate all the modules in Dashboard

Background: Valdiate the Login screen
	Given on loading the url 
	When passing the username and password
	And clicking on the login button
	Then Dashboard should be displayed

@GradesOverview
Scenario: Validate the Dashboard sections
	Given on the Dashboard page
	Then the Grade Overview section should display below the name section
	And the Yearly Attendance Overview section should display below the grade overview
	And the School & Class Calendar section should display below the Attendance overview
	And the Performance Chart section should display next to name section
	And the Events section should display below the Performance chart
	And the Upcoming Events Holidays section should display below the Events section
	And the Upcoming Classmates Birthdays section should display below the Upcoming Events Holidays section
	




	
	
