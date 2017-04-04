using System;

namespace BDD.Monopoly
{
    public class Player
    {
        public void Move(Dice dice)
        {
            throw new NotImplementedException();
        }
        public Square Location { get; set; }
        public int Money { get; set; }
    }
}