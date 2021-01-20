using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chess.Board
{
    public class Dashboard
    {
        public Cell[,] Field;

        public Dashboard()
        {
            Field = new Cell[8,8];

            for(int i = 0; i < 8;i++)
            {
                for(int j = 0; j < 8;j++)
                {
                    Field[i, j] = new Cell(i, j);
                }
            }
        }

        public void ShowDashBoard()
        {
            for (int i = 0; i < 8; i++)
            {
                Console.SetCursorPosition(1, 1 + i);
                for (int j = 0; j < 8; j++)
                {
                    Console.CursorSize = 10;
                    if (Field[i, j].NextLegalMove == true)
                        Console.BackgroundColor = ConsoleColor.Cyan;
                    else
                        Console.BackgroundColor = (ConsoleColor)Field[i, j].Color;

                    Console.ForegroundColor = (ConsoleColor)Field[i, j].Piece.Color;
                    Console.Write(Field[i, j].Piece.PieceSignature);
                }
            }

            Console.ResetColor();
        }
    }
}