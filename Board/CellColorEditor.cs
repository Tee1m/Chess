using System;

namespace Chess.Board
{
    class CellColorEditor
    {
        public CellColor ColorizeTheCell(int ColumnIndex, int RowIndex)
        {
            if (ColumnIndex == RowIndex)
            {
                return CellColor.Blue;
            }
            else if ((ColumnIndex - RowIndex) % 2 == 0)
            {
                return CellColor.Blue;
            }
            else
            {
                return CellColor.DarkBlue;
            }
        }  
    }
}
