using ConsoleChess.Table;

namespace ConsoleChess.Chess
{
    public class Knight: Piece
    {
        public Knight(Color color, Board board) : base(color, board)
        {
        }

        public override string ToString()
        {
            return "N";
        }
    }
}