Feature: Projects
	In order to create a new project
	As a new user
	I need to create organization, investment and business unit before I can create a project
	
	@TEST_IB-202
	Scenario: User want log in with active account
		And Create and login user by Api
		And user have contract type, project stage, organization, investment and business unit created
	##	When User creates a new project
	##	Then new project is created in database
