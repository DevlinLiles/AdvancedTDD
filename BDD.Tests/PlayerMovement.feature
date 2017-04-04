Feature: PlayerMovement
	In Order to play the game of monopoly
	as a player
	I want to move around the board

Scenario: Move the spaces rolled from start
	Given I have a player at the start of the board
	When I press roll an 11
	Then the player should be on the 11 square of the board

Scenario: Move the spaces rolled to pass go
	Given I have a player at Park Place
	When I press roll an 11
	Then the player should be on the 8 square of the board
