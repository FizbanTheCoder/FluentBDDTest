Feature: Login
	To get accet to my accont
	As a register user
	I want to be able to get my account

Scenario: Login to shop
	Given Register user want log in
	When Input autorization data and confirm
	Then User is logged
