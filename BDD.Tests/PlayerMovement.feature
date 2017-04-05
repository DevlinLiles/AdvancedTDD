Feature: PlayerMovement
	In Order to play the game of monopoly
	as a player
	I want to move around the board

Scenario: Move the spaces rolled from start
	Given I have a player at the start of the board
	When the player rolls an 11
	Then the player should be on 11 square of the board

Scenario: Move the spaces rolled to pass go
	Given I have a player at 36 place of the board
	When the player rolls an 11
	Then the player should be on the 8 square of the board

Scenario: Move to jail on GoTo Jail Sqaure
	Given I have a player on the 28th square
	When the player rolls an 2
	Then the player should be on 10 square of the board

Scenario Template: Moving
	Given I have a player at {placeOnBoard} place of the board
	When the player rolls an {diceValue}
	Then the player should be on {expectedSquareIndex} square of the board

Examples: 
	| placeOnBoard | diceValue | expectedSquareIndex |
	| 10           | 6         | 16                  |
	| 20           | 7         | 27                  |
