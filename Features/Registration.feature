Feature: Registration 
	To get possibility to fast buying
	As an unregistered user 
	I want to create new account

Scenario: Registration with full data set
	Given Unregister user want to create an account
	When Input all data on registration page
	And Confirm registration
	Then User have created account and ca log in

Scenario: Email validation on registration
	Given Unregister user want to create an account
	When User input email in wrong format on registration
	Then System give him information about email mistake

Scenario: Card expiration date validation
	Given Unregister user want to create an account
	When User input wrong expiration date on registration
	And Confirm registration
	Then System give him information about expiration date mistake

Scenario: Password confirmation mistake
	Given Unregister user want to create an account
	When User input two different passwords on registration
	And Confirm registration
	Then System give him information about two different passwords

Scenario: Missed required data on registration page
	Given Unregister user want to create an account
	When User miss some data on registration
	And Confirm registration
	Then System give him information what required data is missed on registration 