using ConsoleChess.Table;

namespace ConsoleChess.Chess
{
    public class Priest: Piece
    {
        public Priest(Color color, Board board) : base(color, board)
        {
        }

        public override string ToString()
        {
            return "B";
        }
    }
}