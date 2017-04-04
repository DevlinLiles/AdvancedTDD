using System;

namespace BDD.Monopoly
{
    public class Dice
    {
        private static Random _random = new Random();
        public virtual int Roll()
        {
            return _random.Next(1, 7) + _random.Next(1, 7);
        }
    }
}