using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Chess.Board;
namespace Chess.Game.Team
{
    class TeamGenerator
    {
        Team team;
        //public TeamGenerator(string team_color) : base(team_color) { }
        public TeamGenerator(string team_color)
        {
            team = new Team(team_color);
        }        
        

        public Cell[] TeamLineFormationKingRow(Cell[] RowFormation)
        {
            
            RowFormation[0].piece = team.left_rook_piece;
            RowFormation[1].piece = team.left_knight_piece;
            RowFormation[2].piece = team.left_bishop_piece;
            RowFormation[3].piece = team.queen_piece;
            RowFormation[4].piece = team.king_piece;
            RowFormation[5].piece = team.right_bishop_piece;
            RowFormation[6].piece = team.right_knight_piece;
            RowFormation[7].piece = team.right_rook_piece;
            return RowFormation;
        }
        public Cell[] FirstLineFormationPawnsRow(Cell[] RowFormation)
        {
            RowFormation[0].piece = team.pawn_one;
            RowFormation[1].piece = team.pawn_two;
            RowFormation[2].piece = team.pawn_three;
            RowFormation[3].piece = team.pawn_four;
            RowFormation[4].piece = team.pawn_five;
            RowFormation[5].piece = team.pawn_six;
            RowFormation[6].piece = team.pawn_seven;
            RowFormation[7].piece = team.pawn_eight;
            return RowFormation;
        }
    }
}
