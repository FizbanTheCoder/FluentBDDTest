#TODO: Delete
Feature: Projects
	In order to create a new project
	As a new user
	I need to create organization, investment and business unit before I can create a project

@IB-202 
@AUTO
Scenario: User wants to create a new project
	Given Create and login user by Api
	And user have contract type, project stage, organization, investment and business unit created
	When User creates a new project
	Then new project is created in database

@IB-205
@AUTO
Scenario: Create new project
	Given Create and login user by Api
	And user have contract type, project stage, organization, investment and business unit created
	And Accept registration by email
	And User input credentials on login page
	When User submits form to create new project
	Then new project is created