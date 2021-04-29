Feature: Registration
	To start using apligation
	As a new user
	I want to create account

	@TEST_IB-142
	Scenario: Correct registration process
		When User input all data on registration page
		And Confirm by click 
		Then User see confirmation message
		And After confirmation email message user can log in
