Feature: ProfileInfo_TimeType
	The functionalities of time type in profile page left pad.

@profile_timetype
Scenario Outline: Verify the user is able to edit the availability time type
	Given Click availability edit icon
	When Choose the availability "<Time Type>"
	Then The availability should be update as "<Time Type>"
	Then The alert dialog "<Notification>" should be displayed
Examples:
	| Time Type | Notification         |
	| Part Time | Availability updated |
	| Full Time | Availability updated |

Scenario: Verify the user is able to cancel on time type
	Given Click availability edit icon
	When Click time type cancel icon
	Then The timetype should not change