namespace BDD.Monopoly
{
    public class GoSquare : Square
    {
        public GoSquare() : base("Go") { }

        public override void PassBy(Player player)
        {
            player.Money += 200;
            base.PassBy(player);
        }
    }
}