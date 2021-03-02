using ConsoleChess.Table;

namespace ConsoleChess.Chess
{
    public class ChessPosition
    {
        public int Row { get; set; }
        public char Column { get; set; }

        public ChessPosition(int row, char column)
        {
            Row = row;
            Column = column;
        }

        public Position ToPosition() => new Position(8 - Row, Column - 'a');

        public override string ToString() => $"{Column}{Row}";
    }
}