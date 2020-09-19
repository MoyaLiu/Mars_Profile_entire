Feature: ProfileAttributes
        The functionalities of Languages/Skills/Education/Certifications

@profile_language
Scenario Outline: Verify the user is able to add new languages
	Given Click Languages Tab
	And Click Add New button
	And Enter the "<Language>" and "<Level>"
	When Click Add
	#Then The "<Language>" and "<Level>" should be displayed
	Then The alert dialog "<Notification>" should be displayed
	
	Examples: 
	| Language | Level            | Notification                                          |
	| English  | Basic            | has been added to your languages                      |
	|          | Basic            | Please enter language and level                       |
	| Chinese  |                  | Please enter language and level                       |
	| English  | Basic            | This language is already exist in your language list. |
	| English  | Fluent           | Duplicated data                                       |

Scenario Outline: Verify the user is able to edit the language item
	Given Click the language item edit button
	And Enter the "<language>" and "<level>"
	When Click update
	Then The alert dialog "<notification>" should be displayed

	Examples: 
	| language | level  | notification                       |
	| Chinese  | Fluent | has been updated to your languages |

Scenario Outline: Verify the user is able to cancel edit the language item
	Given Click the language item edit button
	And Enter the "<language>" and "<level>"
	When Click cancel
	Then The alert dialog should not be displayed

	Examples: 
	| language | level  | notification                       |
	| Chinese  | Fluent | has been updated to your languages |

Scenario Outline: Verify the user is able to delete the language item
	Given Click the language item delete button
	Then The alert dialog "<notification>" should be displayed

	Examples: 
	| notification                         |
	| has been deleted from your languages |

@profile_skills
Scenario Outline: Verify the user is able to add new skills
	Given Click Add New button
	And Enter the "<Skill>" and "<Level>"
	When Click Add
	Then The "<skills>" and "<Level>" should be displayed

	Examples: 
	| Skill    | Level        |
	| Selenium | Beginner     |
	| Java     | Intermediate |
	| C#       | Expert       |

@profile_Education
Scenario Outline: Verify the user is able to add new education
	Given Click Add New button
	And Enter the "<University>", "<Country>", "<Title>", "<Degree>" and "<Graduation Year>"
	When Click Add
	Then The "<University>", "<Country>", "<Title>", "<Degree>" and "<Graduation Year>" should be displayed

	Examples: 
	| University | Country | Title  | Degree | Graduation Year |
	| Sdf        | Canada  | B.Tech | 98     | 2018            |

@profile_Certifications
Scenario Outline: Verify the user is able to add new certification
	Given Click Add New button
	And Enter the "<Certificate>", "<From>" and "<Year>"
	When Click Add
	Then The <Certificate>", "<From>" and "<Year>" should be displayed

	Examples: 
	| Certificate | From  | Year |
	| Sdf         | Adobe | 2017 |