using System;
using ConsoleChess.Chessboard;

namespace ConsoleChess
{
    public class Screen
    {
        public static void DrawBoard(Board board)
        {
            Console.WriteLine("  a b c d e f g h ");
            for (var i = 0; i < board.Rows; i++)
            {
                Console.Write($"{8 - i} ");
                for (var j = 0; j < board.Columns; j++)
                {
                    Console.Write(board.getPiece(i, j) != null ? $"{board.getPiece(i, j)} " : "- ");
                }
                Console.Write($"{8 - i}");
                Console.WriteLine();
            }
            Console.WriteLine("  a b c d e f g h ");
        }
    }
}