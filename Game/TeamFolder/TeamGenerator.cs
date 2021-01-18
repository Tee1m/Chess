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
        //Team team;
        //public TeamGenerator(string team_color) : base(team_color) { }
        public TeamGenerator(string team_color):base(team_color) { }


        public Cell[] TeamLineFormationKingRow(Cell[] RowFormation)
        {
            
            RowFormation[0].piece = left_rook_piece;
            RowFormation[1].piece = left_knight_piece;
            RowFormation[2].piece = left_bishop_piece;
            RowFormation[3].piece = queen_piece;
            RowFormation[4].piece = king_piece;
            RowFormation[5].piece = right_bishop_piece;
            RowFormation[6].piece = right_knight_piece;
            RowFormation[7].piece = right_rook_piece;
            return RowFormation;
        }
        public Cell[] FirstLineFormationPawnsRow(Cell[] RowFormation)
        {
            RowFormation[0].piece = pawn_one;
            RowFormation[1].piece = pawn_two;
            RowFormation[2].piece = pawn_three;
            RowFormation[3].piece = pawn_four;
            RowFormation[4].piece = pawn_five;
            RowFormation[5].piece = pawn_six;
            RowFormation[6].piece = pawn_seven;
            RowFormation[7].piece = pawn_eight;
            return RowFormation;
        }
    }
}
