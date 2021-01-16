using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Chess.Pieces;

namespace Chess.Board
{
    class Dashboard
    {
        public Cell[,] Board { get; set; }
        public int column_size=0;
        public int line_size=0;
        public Dashboard(int column_size, int line_size)
        {
            this.column_size = column_size;
            this.line_size = line_size;
            Board = new Cell[column_size,line_size];

            for(int i = 0; i < column_size;i++)
            {
                for(int j = 0; j < line_size;j++)
                {
                    Board[i,j] = new Cell(i, j);
                    Board[i,j].SetCellColor();
                }
            }
        }
        public void ShowDashBoard()
        {
            for (int i = 0; i < column_size; i++)
            {
                Console.SetCursorPosition(1, 1+i);
                for (int j = 0; j < line_size; j++)
                {
                    Console.CursorSize = 10;
                    Console.BackgroundColor = Board[i, j].ColorOfCell;
                    Console.ForegroundColor = Board[i, j].piece.Team_Color;
                    Console.Write(Board[i,j].piece.Piece_Index);
                }
            }
            Console.ResetColor();
        }

    }
}