﻿Feature: LoginTests
	In order to avoid silly mistakes
	As a math idiot
	I want to be told the sum of two numbers

#User want log in witch active account
@TEST_IB-129
Scenario: User want log in witch active account
		Given Registration by api 
		When Accept registration by emain
		And User input credentials on login page
		Then User is logged to account


Scenario: User login by API
	When Registration by api 
	And Accept registration by emain
	When User send correct data to log in
