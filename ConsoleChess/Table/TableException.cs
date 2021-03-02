using System;

namespace ConsoleChess.Table
{
    public class TableException : Exception
    {
        public TableException(string message) : base(message)
        {
        }
    }
}