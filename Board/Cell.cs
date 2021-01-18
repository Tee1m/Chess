using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Chess.Pieces;
using Chess.Game;
namespace Chess.Board
{
    public class Cell
    {
        public int column_number;
        public int line_number;
        bool next_legal_move;
        public Piece piece;
        public ConsoleColor color_of_cell;
        public bool Next_Legal_Move
        {
            get => next_legal_move;
            set
            {
                if (piece is EmptyPlaceForPiece)
                {
                    next_legal_move = value;
                }
            }
        }
        public ConsoleColor ColorOfCell
        {
            get => color_of_cell;
        }
        public Cell(int column_number, int line_number)
        {
            CellColorEditor CellVisEdit = new CellColorEditor();
            this.column_number = column_number;
            this.line_number = line_number;
            this.next_legal_move = false;
            color_of_cell = CellVisEdit.ColorizeTheCell(column_number, line_number);
            piece = new EmptyPlaceForPiece();
        }
        public void SetCellColor()
        {
            CellColorEditor CellVisEdit = new CellColorEditor();
            color_of_cell = CellVisEdit.ColorizeTheCell(column_number, line_number);
        }
       
    }
}
