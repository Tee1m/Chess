using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Chess.Board;

namespace Chess.Game.TeamFolder
{
    class TeamGenerator:Team
    {
        public TeamGenerator(TeamColor Color):base(Color) { }

        public Cell[] TeamLineFormationKingRow(Cell[] RowFormation)
        {
            RowFormation[0].Piece = LeftRookPiece;
            RowFormation[1].Piece = LeftKnightPiece;
            RowFormation[2].Piece = LeftBishopPiece;
            RowFormation[3].Piece = QueenPiece;
            RowFormation[4].Piece = KingPiece;
            RowFormation[5].Piece = RightBishopPiece;
            RowFormation[6].Piece = RightKnightPiece;
            RowFormation[7].Piece = RightRookPiece;
            return RowFormation;
        }

        public Cell[] FirstLineFormationPawnsRow(Cell[] RowFormation)
        {
            RowFormation[0].Piece = PawnOne;
            RowFormation[1].Piece = PawnTwo;
            RowFormation[2].Piece = PawnThree;
            RowFormation[3].Piece = PawnFour;
            RowFormation[4].Piece = PawnFive;
            RowFormation[5].Piece = PawnSix;
            RowFormation[6].Piece = PawnSeven;
            RowFormation[7].Piece = PawnEight;
            return RowFormation;
        }
    }
}
