Feature: BuyItem
	To get new .net t-shirt
	As a register user
	I want to order new one

Scenario: Buy Item
	Given Logged user who want buy item
	When I buy some item 
	Then Item is buyed and result is in history
