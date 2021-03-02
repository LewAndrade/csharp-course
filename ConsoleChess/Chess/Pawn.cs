using ConsoleChess.Table;

namespace ConsoleChess.Chess
{
    public class Pawn: Piece
    {
        public Pawn(Color color, Board board) : base(color, board)
        {
        }

        public override string ToString()
        {
            return "P";
        }
    }
}