using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BDD.Monopoly
{
    public class Board
    {
        public Board()
        {
            Squares = new[]
            {
                new GoSquare(),
                new Square("2"),
                new Square("3"),
                new Square("4"),
                new Square("5"),
                new Square("6"),
                new Square("7"),
                new Square("8"),
                new Square("9"),
                new Square("10"),
                new Square("11"),
                new Square("12"),
                new Square("13"),
                new Square("14"),
                new Square("15"),
                new Square("16"),
                new Square("17"),
                new Square("18"),
                new Square("19"),
                new Square("20"),
                new Square("21"),
                new Square("22"),
                new Square("23"),
                new Square("24"),
                new Square("25"),
                new Square("26"),
                new Square("27"),
                new Square("28"),
                new Square("29"),
                new Square("30"),
                new Square("31"),
                new Square("32"),
                new Square("33"),
                new Square("34"),
                new Square("35"),
                new Square("36"),
                new Square("37"),
                new Square("38"),
                new Square("39"),
                new Square("40")
            };
            for (int index = 0; index < Squares.Length; index++)
            {
                var square = Squares[index];
                square.Next = index != Squares.Length - 1 ? Squares[index + 1] : Squares[0];
            }
        }

        public Square[] Squares { get; set; }
    }
}
