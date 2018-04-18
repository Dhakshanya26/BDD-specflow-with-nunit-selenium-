Feature: Login
	Check if login functionality works

@mytag
Scenario: Login user as admin
	Given I navigate to application
	And I enter username and password
	      |Username|Password|
		  |admin   | admin  |
	And I click login
	Then I should see the user logined to the page
