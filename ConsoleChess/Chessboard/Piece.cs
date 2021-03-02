namespace ConsoleChess.Chessboard
{
    public class Piece
    {
        public Position Position { get; set; }
        public Color Color { get; set; }
        public Board Board { get; set; }
        public int Moves { get; set; }

        public Piece(Position position, Color color, Board board)
        {
            Position = position;
            Color = color;
            Board = board;
            Moves = 0;
        }
    }
}