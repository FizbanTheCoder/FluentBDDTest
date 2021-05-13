Feature: Organization
	In order to create a new organization
	As a new user
	I need to be signed in
	
	@TEST_IB-208
	Scenario: User wants to create a new organization
		Given Create and login user by Api
		When User creates a new organization
		Then new organization is created in database
