Feature: ProfileInfo_Hours
	The functionalities of hours in profile page left pad.

@profile_hours
Scenario Outline: Verify the user is able to edit the availability hours
	Given Click hours edit icon
	When Choose the hours "<Hours>"
	Then The Hours should be update as "<Hours>"
Examples:
	| Hours                    |
	| Less than 30hours a week |
	| More than 30hours a week |
	| As needed                |

Scenario: Verify the user is able to cancel on hours
	Given Click hours edit icon
	When Click hours cancel icon
	Then The hours should not change