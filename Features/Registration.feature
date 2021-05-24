Feature: Registration 
	To get possibility to fast buying
	As an unregistered user 
	I want to create new account

Scenario: Unregister user want register
	Given Unregister user want to create an account
	When Unregister user input all data on registration page
	And Unregister user confirm registration
	Then Unregister user now is registred

Scenario: Unregister user made mistake on email validation
	Given Unregister user want to create an account
	When Unregister user input email in wrong format on registration
	Then Unregister user is still unregister becouse made mistake in email

Scenario: Unregister user made input wrong expiration date
	Given Unregister user want to create an account
	When Unregister user input wrong expiration date on registration
	And Unregister user confirm registration
	Then Unregister user is still unregister becouse made mistake in expiration date

Scenario: Unregister user inputed two different passwords
	Given Unregister user want to create an account
	When Unregister user input two different passwords on registration
	And Unregister user confirm registration
	Then Unregister user is still unregister becouse input two different passwords

Scenario: Unregister user missed required data on registration page
	Given Unregister user want to create an account
	When Unregister user miss some data on registration
	And Unregister user confirm registration
	Then Unregister user is still unregister becouse miss some data

Scenario: Register user want create the same account
	Given Register user want to create an account
	When Register user input all data on registration page
	And Register user confirm registration
	Then Register user cannot create new account with the same data