namespace ConsoleChess.Table
{
    public class Board
    {
        public int Rows { get; set; }
        public int Columns { get; set; }
        private Piece[,] Pieces { get; set; }

        public Board(int rows, int columns)
        {
            Rows = rows;
            Columns = columns;
            Pieces = new Piece[columns, rows];
        }

        public Piece getPiece(int row, int column)
        {
            return Pieces[row, column];
        }
    }
}