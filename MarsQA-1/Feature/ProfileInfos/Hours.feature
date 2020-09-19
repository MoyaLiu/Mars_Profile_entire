Feature: ProfileInfo_Hours
	The functionalities of hours in profile page left pad.

@profile_hours
Scenario Outline: Verify the user is able to edit the availability hours
	Given Click hours edit icon
	When Choose the hours "<Hours>"
	Then The Hours should be update as "<Hours>"
	Then The alert dialog "<Notification>" should be displayed
Examples:
	| Hours                    | Notification         |
	| Less than 30hours a week | Availability updated |
	| More than 30hours a week | Availability updated |
	| As needed                | Availability updated |

Scenario: Verify the user is able to cancel on hours
	Given Click hours edit icon
	When Click hours cancel icon
	Then The hours should not change