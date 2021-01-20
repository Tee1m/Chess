﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Chess.Board;
using Chess.Game.TeamFolder;

namespace Chess.Pieces
{
    public class Bishop : Piece
    {
        public Bishop(string Name, string PieceSignature, TeamColor Color) : base(Name, PieceSignature, Color)
        {
            this.Name = Name;
            this.PieceSignature = PieceSignature;
            this.Color = Color;
        }

        public override void GenerateLegalMove(Dashboard Board)
        {
            PieceFinder pieceFinder = new PieceFinder(Board);
            pieceFinder.FindPieceOnDashboard(Name, Color);

            if (pieceFinder.RowIndex == pieceFinder.ColumnIndex)
            {
                for (int i = 0; i < 8; i++)
                {
                    if (pieceFinder.RowIndex + i < 8 && pieceFinder.ColumnIndex + i < 8)
                    {
                        Board.Field[pieceFinder.RowIndex + i, pieceFinder.ColumnIndex + i].SetNextLegalMove = true;
                    }

                    if (pieceFinder.RowIndex - i >= 0 && pieceFinder.RowIndex - i >= 0)
                    {
                        Board.Field[pieceFinder.RowIndex - i, pieceFinder.ColumnIndex - i].SetNextLegalMove = true;
                    }
                }
            }
            
            for (int i = 0; i < 8; i++)
            {
                if (pieceFinder.ColumnIndex + i < 8 && pieceFinder.RowIndex - i >= 0 )
                {
                    Board.Field[pieceFinder.RowIndex - i, pieceFinder.ColumnIndex + i].SetNextLegalMove = true;

                }

                if (pieceFinder.RowIndex + i < 8 && pieceFinder.ColumnIndex - i >= 0 )
                {
                    Board.Field[pieceFinder.RowIndex + i, pieceFinder.ColumnIndex - i].SetNextLegalMove = true;
                   
                }

                if (pieceFinder.RowIndex - i >= 0 && pieceFinder.ColumnIndex - i >= 0)
                {
                    Board.Field[pieceFinder.RowIndex - i, pieceFinder.ColumnIndex - i].SetNextLegalMove = true;
                }

                if (pieceFinder.RowIndex + i < 8 && pieceFinder.ColumnIndex + i < 8)
                {
                    Board.Field[pieceFinder.RowIndex + i, pieceFinder.ColumnIndex + i].SetNextLegalMove = true;
                }
            }
        }
    }
}
