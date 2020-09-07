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


Scenario Outline: Verify the user is able to edit the availability
	Given Click availability edit icon
	When Choose the availability "<Time Type>"
	Then The availability should be update as "<Time Type>"
Examples: 
	| Time Type |
	| Part Time |
	| Full Time |




