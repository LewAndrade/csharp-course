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

        public Piece GetPiece(int row, int column) => Pieces[row, column];

        public Piece GetPiece(Position position) => Pieces[position.Row, position.Column];

        public void SetPiece(Piece piece, Position position)
        {
            if (IsPositionOccupied(position))
                throw new TableException("Position already occupied");
            
            Pieces[position.Row, position.Column] = piece;
            piece.Position = position;
        }

        public bool IsPositionOccupied(Position position)
        {
            ValidatePosition(position);
            return GetPiece(position) != null;
        }

        public bool IsValidPosition(Position position) => position.Row >= 0 && position.Row < Rows &&
                                                          position.Column >= 0 && position.Column < Columns;

        private void ValidatePosition(Position position)
        {
            if (!IsValidPosition(position))
                throw new TableException("Invalid Position");
        }
    }
}