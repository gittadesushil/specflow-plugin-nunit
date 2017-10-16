@ignore
Feature: Test Code Generation
	In order to avoid namespace clashes
	As a user of SpecFlow with NUnit
	I want namespace to be preceded with the "global" keyword in the generated tests

Background:
	Given a valid calculator

@ignore
Scenario: Simple Scenario
	Given I have entered 50 into the calculator
	And I have entered 70 into the calculator
	When I press add
	Then the result should be 120 on the screen

Scenario Outline: Scenario Outline
	Given I have entered <addend1> into the calculator
	And I have entered <addend2> into the calculator
	When I press add
	Then the result should be <sum> on the screen

	Examples: 
		| addend1 | addend2 | sum |
		| 50      | 70      | 120 |
		| 60      | 70      | 130 |