Feature: InterviewTest
	In order to use the web page
	As a user
	I want to specify the web page's behaviour


Scenario Outline: REQ-UI-01 The Title should be "UI Testing Site" on every site
	Given user is on the landing page
	And the <Button> is available
	When user clicks to the <Button>
	Then the <Page> loads
	And the title is "UI Testing Site"
	Examples: 
	| Button            | Page      |
	| UI Testing button | Home page |
	| Home button       | Home page |
	| Form button       | Form page |

Scenario Outline: REQ-UI-02 The Company Logo should be visible on every site
	Given user is on the landing page
	And the <Button> is available
	When user clicks to the <Button>
	Then the <Page> loads
	And The Company Logo is visible on the page
	Examples: 
	| Button            | Page      |
	| UI Testing button | Home page |
	| Home button       | Home page |
	| Form button       | Form page |

Scenario: REQ-UI-03 When I click on the Home button, I should get navigated to the Home page
	Given user is on the Form page
	And the Home button is available
	When user clicks to the Home button
	Then the Home page loads

Scenario: REQ-UI-04 When I click on the Home button, it should turn to active status
	Given user is on the Form page
	And the Home button is available
	When user clicks to the Home button
	Then the Home button is active

Scenario: REQ-UI-05 When I click on the Form button, I should get navigated to the Form page
	Given user is on the Home page
	And the Form button is available
	When user clicks to the Form button
	Then the Form page loads

Scenario: REQ-UI-06 When I click on the Form button, it should turn to active status
	Given user is on the Home page
	And the Form button is available
	When user clicks to the Form button
	Then the Form button is active

Scenario: REQ-UI-07 When I click on the Error button, I should get a 404 HTTP response code
	Given user is on the Home page
	And the Error button is available
	When user clicks to the Error button
	Then user get a 404 HTTP response code

Scenario: REQ-UI-08 When I click on the UI Testing button, I should get navigated to the Home page
	Given user is on the Form page
	And the UI Testing button is available
	When user clicks to the UI Testing button
	Then the Home page loads

Scenario: REQ-UI-09 The following text should be visible on the Home page in <h1> tag:
"Welcome to the Docler Holding QA Department"
	Given user is on the Form page
	And the Home button is available
	When user clicks to the Home button
	Then the Home page loads
	And "Welcome to the Docler Holding QA Department" text is visible on the Home page in h1 tag

Scenario: REQ-UI-10 The following text should be visible on the Home page in <p> tag:
"This site is dedicated to perform some exercises and demonstrate automated web testing."
	Given user is on the Form page
	And the Home button is available
	When user clicks to the Home button
	Then the Home page loads
	And "This site is dedicated to perform some exercises and demonstrate automated web testing." text is visible on the Home page in p tag

Scenario: REQ-UI-11 On the Form page, a form should be visible with one input box and one submit button
	Given user is on the Home page
	And the Form button is available
	When user clicks to the Form button
	Then the Form page loads
	And a form is visible
	And one input box is visible on the page
	And one submit button is visible on the page

Scenario Outline: REQ-UI-12 On the Form page, if you type <value> the input field and submit the form, you should get redirect to the Hello page, and the following text should appear: <result>
	Given user is on the Form page
	When user type <Value> to the input field
	And submit the form
	Then the page redirected to the Hello page
	And the following text is appear <Result>
	Examples: 
	| Value   | Result         |
	| John    | Hello John!    |
	| Sophia  | Hello Sophia!  |
	| Charlie | Hello Charlie! |
	| Emily   | Hello Emily!   |
