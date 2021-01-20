using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Chess.Pieces;
using Chess.Game.TeamFolder;

namespace Chess.Board
{
    public class Cell
    {
        public int ColumnIndex;
        public int RowIndex;
        public Piece Piece;
        public CellColor Color;

        public bool NextLegalMove { get; private set; }
        public bool SetNextLegalMove
        {
            set
            {
                if (Piece is EmptyPlaceForPiece)
                {
                    NextLegalMove = value;
                }
            }
        }

        public Cell(int ColumnIndex, int RowIndex)
        { 
            this.ColumnIndex = ColumnIndex;
            this.RowIndex = RowIndex;
            this.NextLegalMove = false;
            Piece = new EmptyPlaceForPiece(" ", " ", TeamColor.NoColor);
            CellColorEditor FieldColorEditor = new CellColorEditor();
            Color = FieldColorEditor.ColorizeTheCell(ColumnIndex, RowIndex); 
        }

        public void SetCellColor()
        {
            CellColorEditor FieldColorEditor = new CellColorEditor();
            Color = FieldColorEditor.ColorizeTheCell(ColumnIndex, RowIndex);
        }
    }
}
