using Chess.Board;
using Chess.Game.Team;

namespace Chess.Game
{
    class SetUpGame
    {   
        TeamGenerator WhiteTeam;
        TeamGenerator BlackTeam;
        public Dashboard SetUpDashBoard;
        public SetUpGame() { }
        public SetUpGame(string color_of_first_team, string color_of_second_team)
        {
            WhiteTeam = new TeamGenerator(color_of_first_team);
            BlackTeam = new TeamGenerator(color_of_second_team);
            SetUpDashBoard = new Dashboard(8,8);   
        }
        public virtual Cell[,] SetUpDashboard()//TODO
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

        }//TODO
        void SetUpRow(Cell[]tab,int row)
        {
            for (int i = 0; i < 8; i++)
            {
                SetUpDashBoard.Board[row,i].piece=tab[i].piece;
                //SetUpDashBoard.GameBoard[row, i].SetCellColor();
            }
        }
    }
}
