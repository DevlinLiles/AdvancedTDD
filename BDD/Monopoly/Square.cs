namespace BDD.Monopoly
{
    public class Square
    {
        public string Name { get; set; }
        public Square Next { get; set; }

        public Square(string name)
        {
            Name = name;
        }

        public virtual void PassBy(Player player)
        {
            
        }

        public virtual void LandOn(Player player)
        {
        }
    }
}