Feature: AlertTests
	As a User I want to confirm
	an alert to submit provided data

@AUTO
Scenario: Closing an alert after clicking submit button
	When User click submit button alert appears
	#Then Alert message is displayed, user confirms it with button

	@AUTO
Scenario: Accepting an alert after clicking submit button
	When User click submit button and confirms alert that appears
