Feature: UserForm
	Feature which hold all user details

@mytag
Scenario: UserForm entry verification
	Given I navigate to application
	And I enter username and password
	      |Username|Password|
		  |admin   | admin  |
	And I click login
	And I start entering user form details
	      |Name|Age|
		  |admin   | 12  |
    And I click submit button
	Then I should see the user logined to the page
