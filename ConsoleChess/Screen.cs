using System;
using ConsoleChess.Table;

namespace ConsoleChess
{
    public class Screen
    {
        public static void DrawBoard(Board board)
        {
            Console.WriteLine("  a b c d e f g h ");
            for (var row = 0; row < board.Rows; row++)
            {
                Console.Write($"{8 - row} ");
                for (var column = 0; column < board.Columns; column++)
                {
                    DrawSpace(row, column, board.GetPiece(row, column));
                }

                Console.WriteLine($" {8 - row}");
            }

            Console.WriteLine("  a b c d e f g h ");
        }

        private static void DrawSpace(int row, int column, Piece piece)
        {
            Console.BackgroundColor = (row + column) % 2 == 0 ? ConsoleColor.Gray : ConsoleColor.DarkGray;

            if (piece != null)
            {
                Console.ForegroundColor = (ConsoleColor) piece.Color;
                Console.Write($"{piece} ");
            }
            else
                Console.Write("  ");

            Console.ResetColor();
        }
    }
}