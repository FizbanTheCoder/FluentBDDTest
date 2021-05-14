Feature: Registration
	To start using apligation
	As a new user
	I want to create account

@IB-142
@backEnd
@frontEnd
Scenario: Correct registration process
	When User input all data on registration page
	And Confirm by click
	Then User see confirmation message
	And After confirmation email message user can log in

@IB-192
Scenario: Failed registration process
	When User don't input all data on registration page and confirm
	Then account is not created in database