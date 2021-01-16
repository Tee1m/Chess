using System;

namespace Chess.Board
{
    class CellColorEditor
    {
        public ConsoleColor ColorizeTheCell(int index_of_column, int index_of_line)
        {
            if (index_of_column == index_of_line)
            {
                return ConsoleColor.Blue;
            }
            else if ((index_of_column - index_of_line) % 2 == 0)
            {
                return ConsoleColor.Blue;
            }
            else
            {
                return ConsoleColor.DarkBlue;
            }
        }  
    }
}
