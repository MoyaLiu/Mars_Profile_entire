Feature: ProfileInfo
	The functionalities in profile page left pad.

@profile_functionality
Scenario Outline: Verify the user is able to edit the name
	Given Click Name 
	And Enter values in "<First Name>" and "<Last Name>" 
	When Click Save
	Then The name is display as "<First Name>""<Last Name>"

Examples:
	| First Name | Last Name |
	| Moyaa      | Lii       |


Scenario Outline: Verify the user is able to edit the availability time type
	Given Click availability edit icon
	When Choose the availability "<Time Type>"
	Then The availability should be update as "<Time Type>"
Examples:
	| Time Type |
	| Part Time |
	| Full Time |

Scenario Outline: Verify the user is able to edit the availability hours
	Given Click hours edit icon
	When Choose the hours "<Hours>"
	Then The Hours should be update as "<Hours>"
Examples:
	| Hours                    |
	| Less than 30hours a week |
	| More than 30hours a week |
	| As needed                |

Scenario Outline: Verify the user is able to edit the availability earn target
	Given Click target edit icon
	When Choose the target "<Earn Target>"
	Then The Earn Target should be update as "<Earn Target>"
Examples:
	| Earn Target                      |
	| Less than $500 per month         |
	| Between $500 and $1000 per month |
	| More than $1000 per month        |




