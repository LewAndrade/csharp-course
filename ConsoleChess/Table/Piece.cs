namespace ConsoleChess.Table
{
    public class Piece
    {
        public Position Position { get; set; }
        public Color Color { get; set; }
        public Board Board { get; set; }
        public int Moves { get; set; }

        public Piece(Color color, Board board)
        {
            Position = null;
            Color = color;
            Board = board;
            Moves = 0;
        }
    }
}