using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Chess.Board;
using Chess.Game.GUI;
using Chess.Game.TeamFolder;

namespace Chess.Game
{
    class ChessGame
    {   
        Dashboard GamingBoard;
        CursorOnDashboard CursorDashboard;
        Team FirstTeam;
        Team SecondTeam;

        public ChessGame(SetUpGame SetGame)
        {
            GamingBoard = new Dashboard();
            SetGame.SetUpDashboard();
            GamingBoard.Field = SetGame.SetUpDashboard();
            FirstTeam = SetGame.WhiteTeam;
            SecondTeam = SetGame.BlackTeam;
        }

        public void StartGame()
        {   
            CursorDashboard = new CursorOnDashboard(GamingBoard);
            CursorDashboard.ChosingPiece(FirstTeam);
            Console.ReadKey();
            Console.ReadKey();
        }
    }
}
