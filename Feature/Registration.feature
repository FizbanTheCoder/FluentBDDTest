Feature: Registration
	To start using apligation
	As a new user
	I want to create account

Scenario: Create Account with corect data
	Given User without account want create new on registration page
	When Input all correct data and confirm
	Then User se succed message and get conrfirmation email
	And After corfimation user can log in

Scenario: Creating account with wrong format data
	Given User without accont want create newon registration page
	And User put data in wrong format on registration page
	Then User cannot create new accout

Scenario: Creating account with incomplete data
	Given User without accont want create newon registration page
	And User put incomplete data  on registration page
	Then User cannot create new accout

	
Scenario: Creating account with complete data bat dond give aggre by checkbox
	Given User without accont want create newon registration page
	And User put complete data but dont mark checkboxes on registration
	Then User cannot create new accout

Scenario: Registration by API
	When Registration by api 