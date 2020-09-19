Feature: ProfileInfo_Name
	The functionalities of Name in profile page left pad.

@profile_name
Scenario Outline: Verify the user is able to edit the name
	Given Click Name 
	And Enter values in "<First Name>" and "<Last Name>" 
	When Click Save
	Then The name is display as "<First Name>""<Last Name>"

Examples:
	| First Name | Last Name |
	| Moyaa      | Lii       |