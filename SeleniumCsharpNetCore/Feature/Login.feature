Feature: Login
	Simple calculator for adding two numbers

@Smoke
Scenario: Add two numbers first
	Given the first number is 50
	And the second number is 70
	When the two numbers are added
	Then the result should be 120


@Regression
Scenario: Add two numbers second
	Given the first number is 20
	And the second number is 30
	When the two numbers are added
	Then the result should be 50