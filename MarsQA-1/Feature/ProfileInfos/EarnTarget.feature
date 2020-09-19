Feature: ProfileInfo_EarnTarget
	The functionalities of earn target in profile page left pad.

@profile_target
Scenario Outline: Verify the user is able to edit the availability earn target
	Given Click target edit icon
	When Choose the target "<Earn Target>"
	Then The Earn Target should be update as "<Earn Target>"
Examples:
	| Earn Target                      |
	| Less than $500 per month         |
	| Between $500 and $1000 per month |
	| More than $1000 per month        |

Scenario: Verify the user is able to cancel on earn target
	Given Click target edit icon
	When Click target cancel icon
	Then The target should not change




