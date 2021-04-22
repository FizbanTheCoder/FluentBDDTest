Feature: LoginTests
	In order to avoid silly mistakes
	As a math idiot
	I want to be told the sum of two numbers


Scenario: User want log in witch active account
	Given User have active account and is on login screen
	When User input credentials on login page
	Then User is logged to account

Scenario: User login by API
	When User send correct data to log in