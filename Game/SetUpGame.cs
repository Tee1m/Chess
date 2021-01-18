using Chess.Board;
using Chess.Game.TeamFolder;

namespace Chess.Game
{
    class SetUpGame
    {   
        public TeamGenerator WhiteTeam;
        public TeamGenerator BlackTeam;
        public Dashboard SetUpDashBoard;
        public SetUpGame() { }
        public SetUpGame(TeamGenerator first_team, TeamGenerator second_team)
        {
            WhiteTeam = first_team;
            BlackTeam = second_team;
            SetUpDashBoard = new Dashboard(8,8);   
        }
        public virtual Cell[,] SetUpDashboard()
        {
            Cell[] tab = new Cell[8];
            for (int j = 0; j < 8; j++)
            {
                tab[j] = new Cell(j,0);
            }
            tab = WhiteTeam.TeamLineFormationKingRow(tab);
            SetUpRow(tab,7);
            tab = WhiteTeam.FirstLineFormationPawnsRow(tab);
            SetUpRow(tab,6);
            
            tab = BlackTeam.TeamLineFormationKingRow(tab);
            SetUpRow(tab,0);
            tab = BlackTeam.FirstLineFormationPawnsRow(tab);
            SetUpRow(tab,1);
            return SetUpDashBoard.Board;
        }
        void SetUpRow(Cell[]tab,int row)
        {
            for (int i = 0; i < 8; i++)
            {
                SetUpDashBoard.Board[row,i].piece=tab[i].piece;
            }
        }
    }
}
