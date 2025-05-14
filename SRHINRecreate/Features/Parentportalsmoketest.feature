Feature: Parent Portal Smoke Test

Background: Valdiate the Login screen
	Given on loading the url 
	When passing the username and password
	And clicking on the login button
	Then Dashboard should be displayed

@ProfilePage
Scenario: Validate the Profile screen	
	Given on clicking the profile icon
	Then Profile header should be displayed

@CurriculumPage
Scenario: Validate the Curriculum Page
	When I click the Curriculum button
	Then I should be redirected to the Curriculum page
	
@HomeworkPage
Scenario: Validate the Homework Page
	When I click the Homework button	
	Then I should be redirected to the Homework page
	
@FeedbackPage	
Scenario: Validate the Feedback Page
	When I click the Feedback button
	Then I should be redirected to the Feedback page
	
@NotificationPage
Scenario: Validate the Notification Page
	When I click the Notification button
	Then I should be redirected to the Notification page
	
@FeesPage	
Scenario: Validate the Fees Page
	When I click the Fees button
	Then I should be redirected to the Fees page

@LogoutPage	
Scenario: Validate the Logout Page
	When I click the Logout button
	And I should be redirected to the Login page