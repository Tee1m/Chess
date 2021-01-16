using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Chess.Pieces;

namespace Chess.Board
{
    class Cell
    {
        public int column_number;
        public int line_number;
        bool it_is_busy;
        bool next_legal_move;
        public Piece piece;
        public ConsoleColor color_of_cell;
        public bool Next_Legal_Move
        {
            get => next_legal_move;
            set
            {
                if (it_is_busy == false)
                {
                    next_legal_move = value;
                }
                else if(it_is_busy == true)
                {
                    //  if (piece.Team_Color!=)
                    //{
                    //    next_legal_move = value;
                    //}
                    //TODO Klasa gracz lub kolejka. Będzie wskazywać kogo kolej jest oraz przekazywać kolor do właściwości
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
            this.it_is_busy = false;
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
