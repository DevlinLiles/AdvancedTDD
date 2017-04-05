using System;
using System.Linq;
using BDD.Monopoly;
using FluentAssertions;
using TechTalk.SpecFlow;

namespace BDD.Tests
{
    [Binding]
    public class PlayerMovementSteps
    {
        [Given(@"I have a player at the start of the board")]
        public void GivenIHaveAPlayerAtTheStartOfTheBoard()
        {
            var board = new Board();
            var player = new Player();
            player.Location = board.Squares.First();

            ScenarioContext.Current.Add("Board", board);
            ScenarioContext.Current.Add("Player", player);
        }
        
        [Given(@"I have a player at (.*) place of the board")]
        public void GivenIHaveAPlayerAtPlaceOfTheBoard(int placeOnBoard)
        {
            var board = new Board();
            var player = new Player();
            player.Location = board.Squares.First();

            for (int i = 0; i < placeOnBoard; i++)
            {
                player.Location = player.Location.Next;
            }

            ScenarioContext.Current.Add("Board", board);
            ScenarioContext.Current.Add("Player", player);
        }
        
        [When(@"the player rolls an (.*)")]
        public void WhenThePlayerRollsAn(int diceValue)
        {
            var player = ScenarioContext.Current.Get<Player>("Player");
            player.Move(new FakeDice(diceValue));
        }
        
        [Then(@"the player should be on (.*) square of the board")]
        public void ThenThePlayerShouldBeOnTheSquareOfTheBoard(int expectedSquareIndex)
        {
            var player = ScenarioContext.Current.Get<Player>("Player");
            var board = ScenarioContext.Current.Get<Board>("Board");
            player.Location.Should().BeSameAs(board.Squares.ElementAt(expectedSquareIndex));
        }
    }

    public class FakeDice : Dice
    {
        private readonly int _spaces;

        public FakeDice(int spaces)
        {
            _spaces = spaces;
        }

        public override int Roll()
        {
            return _spaces;
        }
    }
}
